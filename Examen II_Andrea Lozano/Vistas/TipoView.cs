using Examen_II_Andrea_Lozano.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_II_Andrea_Lozano.Vistas
{
    public partial class TipoView : Form
    {
        public TipoView()
        {
            InitializeComponent();
            TipoController controlador = new TipoController(this);
        }
    }
}
