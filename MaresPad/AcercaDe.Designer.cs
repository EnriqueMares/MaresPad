namespace MaresPad
{
    partial class AcercaDe
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
            this.txtLeyenda = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pctMaresPad = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctMaresPad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLeyenda
            // 
            this.txtLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeyenda.Location = new System.Drawing.Point(361, 12);
            this.txtLeyenda.Multiline = true;
            this.txtLeyenda.Name = "txtLeyenda";
            this.txtLeyenda.ReadOnly = true;
            this.txtLeyenda.Size = new System.Drawing.Size(391, 109);
            this.txtLeyenda.TabIndex = 2;
            this.txtLeyenda.Text = "MaresPad es un editor de texto sencillito y carismatico \r\ncreado por los alumnos:" +
                "\r\nLuis Enrique Mares Ortega\r\nFabiola Berenice Ramirez Esparza\r\nDoraly Lozano San" +
                " Miguel ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 206);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(737, 231);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // pctMaresPad
            // 
            this.pctMaresPad.Image = ((System.Drawing.Image)(resources.GetObject("pctMaresPad.Image")));
            this.pctMaresPad.Location = new System.Drawing.Point(15, 12);
            this.pctMaresPad.Name = "pctMaresPad";
            this.pctMaresPad.Size = new System.Drawing.Size(340, 188);
            this.pctMaresPad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMaresPad.TabIndex = 4;
            this.pctMaresPad.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(663, 443);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(89, 32);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 481);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pctMaresPad);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtLeyenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AcercaDe";
            this.Text = "Acerca de MaresPad";
            ((System.ComponentModel.ISupportInitialize)(this.pctMaresPad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLeyenda;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pctMaresPad;
        private System.Windows.Forms.Button btnAceptar;
    }
}