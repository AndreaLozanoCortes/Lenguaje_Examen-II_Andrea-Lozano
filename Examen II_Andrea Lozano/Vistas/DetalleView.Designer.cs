
namespace Examen_II_Andrea_Lozano.Vistas
{
    partial class DetalleView
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
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Detalle2DataGridView = new System.Windows.Forms.DataGridView();
            this.Detalle1DataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle2DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DetalleDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DetalleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(-1, 81);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.Size = new System.Drawing.Size(333, 513);
            this.DetalleDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "DETALLES DE TICKETS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Detalle2DataGridView
            // 
            this.Detalle2DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Detalle2DataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Detalle2DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Detalle2DataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.Detalle2DataGridView.Location = new System.Drawing.Point(-429, 81);
            this.Detalle2DataGridView.Name = "Detalle2DataGridView";
            this.Detalle2DataGridView.Size = new System.Drawing.Size(849, 513);
            this.Detalle2DataGridView.TabIndex = 3;
            // 
            // Detalle1DataGridView
            // 
            this.Detalle1DataGridView.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Detalle1DataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Detalle1DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Detalle1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Detalle1DataGridView.Location = new System.Drawing.Point(-194, 81);
            this.Detalle1DataGridView.Name = "Detalle1DataGridView";
            this.Detalle1DataGridView.Size = new System.Drawing.Size(293, 513);
            this.Detalle1DataGridView.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Examen_II_Andrea_Lozano.Properties.Resources.detalles;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // DetalleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(392, 592);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Detalle1DataGridView);
            this.Controls.Add(this.Detalle2DataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DetalleDataGridView);
            this.Name = "DetalleView";
            this.Text = "Detalles";
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle2DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DetalleDataGridView;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView Detalle2DataGridView;
        public System.Windows.Forms.DataGridView Detalle1DataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}