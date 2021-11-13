
namespace Examen_II_Andrea_Lozano.Vistas
{
    partial class TipoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IdTipoSoporte = new System.Windows.Forms.TextBox();
            this.cb_TipoSoporte = new System.Windows.Forms.ComboBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Tipo Soporte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Soporte:";
            // 
            // txt_IdTipoSoporte
            // 
            this.txt_IdTipoSoporte.Enabled = false;
            this.txt_IdTipoSoporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdTipoSoporte.Location = new System.Drawing.Point(160, 48);
            this.txt_IdTipoSoporte.Name = "txt_IdTipoSoporte";
            this.txt_IdTipoSoporte.ReadOnly = true;
            this.txt_IdTipoSoporte.Size = new System.Drawing.Size(121, 21);
            this.txt_IdTipoSoporte.TabIndex = 2;
            // 
            // cb_TipoSoporte
            // 
            this.cb_TipoSoporte.Enabled = false;
            this.cb_TipoSoporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TipoSoporte.FormattingEnabled = true;
            this.cb_TipoSoporte.Items.AddRange(new object[] {
            "Reparación de Celulares",
            "Reparación de Equipo de Cómputo"});
            this.cb_TipoSoporte.Location = new System.Drawing.Point(161, 88);
            this.cb_TipoSoporte.Name = "cb_TipoSoporte";
            this.cb_TipoSoporte.Size = new System.Drawing.Size(184, 23);
            this.cb_TipoSoporte.TabIndex = 3;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Agregar.Enabled = false;
            this.btn_Agregar.Location = new System.Drawing.Point(143, 144);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 4;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Limpiar.Enabled = false;
            this.btn_Limpiar.Location = new System.Drawing.Point(236, 144);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 5;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Nuevo.Location = new System.Drawing.Point(48, 144);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 6;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TipoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(373, 224);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.cb_TipoSoporte);
            this.Controls.Add(this.txt_IdTipoSoporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TipoView";
            this.Text = "Tipo";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_IdTipoSoporte;
        public System.Windows.Forms.ComboBox cb_TipoSoporte;
        public System.Windows.Forms.Button btn_Agregar;
        public System.Windows.Forms.Button btn_Limpiar;
        public System.Windows.Forms.Button btn_Nuevo;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}