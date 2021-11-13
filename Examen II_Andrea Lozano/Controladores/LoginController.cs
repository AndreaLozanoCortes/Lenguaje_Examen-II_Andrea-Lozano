using Examen_II_Andrea_Lozano.Modelos.DAD;
using Examen_II_Andrea_Lozano.Modelos.Entidades;
using Examen_II_Andrea_Lozano.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_II_Andrea_Lozano.Controladores
{
    public class LoginController
    {
        LoginView vista;

        public LoginController(LoginView view)
        {
            vista = view;

            vista.btn_Aceptar.Click += new EventHandler(ValidarUsuario);
        }

        private void ValidarUsuario(object serder, EventArgs e)
        {
            bool esValido = false;

            UsuarioDAD userDao = new UsuarioDAD();

            Usuario user = new Usuario();

            user.Email = vista.txt_Email.Text;
            user.Clave = EncriptarClave(vista.txt_Clave.Text);

            esValido = userDao.ValidarUsuario(user);

            if (esValido)
            {
                //MessageBox.Show("Usuario Correcto");

                MenuView menu = new MenuView();
                vista.Hide();

                //menu.EmailUsuario = user.Email;

                menu.Show();

            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }

        public static string EncriptarClave(string str)
        {
            string cadena = str + "ClaveSecretaEscondida";
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(cadena));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}



        

