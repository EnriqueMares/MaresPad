namespace MaresPad
{
    partial class Buscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbcOpciones = new System.Windows.Forms.TabControl();
            this.tbpBuscar = new System.Windows.Forms.TabPage();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.lblPalabra = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbpReemplazar = new System.Windows.Forms.TabPage();
            this.btnBuscarReemplazar = new System.Windows.Forms.Button();
            this.lstBuscarReemplazar = new System.Windows.Forms.ListBox();
            this.lblReemplazar = new System.Windows.Forms.Label();
            this.lblReemplazarBuscar = new System.Windows.Forms.Label();
            this.txtReemplazar = new System.Windows.Forms.TextBox();
            this.txtReemplazarBuscar = new System.Windows.Forms.TextBox();
            this.btnReemplazar = new System.Windows.Forms.Button();
            this.tbpIrA = new System.Windows.Forms.TabPage();
            this.nudNumeroDeLinea = new System.Windows.Forms.NumericUpDown();
            this.lblNumeroDeLinea = new System.Windows.Forms.Label();
            this.btnIrA = new System.Windows.Forms.Button();
            this.btnReemplazarUno = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbcOpciones.SuspendLayout();
            this.tbpBuscar.SuspendLayout();
            this.tbpReemplazar.SuspendLayout();
            this.tbpIrA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroDeLinea)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(891, 154);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbcOpciones
            // 
            this.tbcOpciones.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbcOpciones.Controls.Add(this.tbpBuscar);
            this.tbcOpciones.Controls.Add(this.tbpReemplazar);
            this.tbcOpciones.Controls.Add(this.tbpIrA);
            this.tbcOpciones.HotTrack = true;
            this.tbcOpciones.Location = new System.Drawing.Point(12, 10);
            this.tbcOpciones.Name = "tbcOpciones";
            this.tbcOpciones.SelectedIndex = 0;
            this.tbcOpciones.Size = new System.Drawing.Size(470, 267);
            this.tbcOpciones.TabIndex = 2;
            // 
            // tbpBuscar
            // 
            this.tbpBuscar.Controls.Add(this.lstResultados);
            this.tbpBuscar.Controls.Add(this.lblPalabra);
            this.tbpBuscar.Controls.Add(this.txtBuscar);
            this.tbpBuscar.Controls.Add(this.btnBuscar);
            this.tbpBuscar.Location = new System.Drawing.Point(4, 25);
            this.tbpBuscar.Name = "tbpBuscar";
            this.tbpBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBuscar.Size = new System.Drawing.Size(462, 231);
            this.tbpBuscar.TabIndex = 0;
            this.tbpBuscar.Text = "Buscar";
            this.tbpBuscar.UseVisualStyleBackColor = true;
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(10, 48);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(438, 95);
            this.lstResultados.TabIndex = 7;
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabra.Location = new System.Drawing.Point(6, 14);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(151, 24);
            this.lblPalabra.TabIndex = 6;
            this.lblPalabra.Text = "Palabra a Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(163, 8);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(195, 29);
            this.txtBuscar.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(362, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 40);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // tbpReemplazar
            // 
            this.tbpReemplazar.Controls.Add(this.btnReemplazarUno);
            this.tbpReemplazar.Controls.Add(this.btnBuscarReemplazar);
            this.tbpReemplazar.Controls.Add(this.lstBuscarReemplazar);
            this.tbpReemplazar.Controls.Add(this.lblReemplazar);
            this.tbpReemplazar.Controls.Add(this.lblReemplazarBuscar);
            this.tbpReemplazar.Controls.Add(this.txtReemplazar);
            this.tbpReemplazar.Controls.Add(this.txtReemplazarBuscar);
            this.tbpReemplazar.Controls.Add(this.btnReemplazar);
            this.tbpReemplazar.Location = new System.Drawing.Point(4, 25);
            this.tbpReemplazar.Name = "tbpReemplazar";
            this.tbpReemplazar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpReemplazar.Size = new System.Drawing.Size(462, 238);
            this.tbpReemplazar.TabIndex = 1;
            this.tbpReemplazar.Text = "Reemplazar";
            this.tbpReemplazar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarReemplazar
            // 
            this.btnBuscarReemplazar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarReemplazar.Location = new System.Drawing.Point(321, 6);
            this.btnBuscarReemplazar.Name = "btnBuscarReemplazar";
            this.btnBuscarReemplazar.Size = new System.Drawing.Size(135, 40);
            this.btnBuscarReemplazar.TabIndex = 11;
            this.btnBuscarReemplazar.Text = "Buscar Siguiente";
            this.btnBuscarReemplazar.UseVisualStyleBackColor = true;
            this.btnBuscarReemplazar.Click += new System.EventHandler(this.btnBuscarReemplazar_Click);
            // 
            // lstBuscarReemplazar
            // 
            this.lstBuscarReemplazar.FormattingEnabled = true;
            this.lstBuscarReemplazar.Location = new System.Drawing.Point(6, 97);
            this.lstBuscarReemplazar.Name = "lstBuscarReemplazar";
            this.lstBuscarReemplazar.Size = new System.Drawing.Size(438, 95);
            this.lstBuscarReemplazar.TabIndex = 10;
            // 
            // lblReemplazar
            // 
            this.lblReemplazar.AutoSize = true;
            this.lblReemplazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReemplazar.Location = new System.Drawing.Point(3, 50);
            this.lblReemplazar.Name = "lblReemplazar";
            this.lblReemplazar.Size = new System.Drawing.Size(111, 24);
            this.lblReemplazar.TabIndex = 9;
            this.lblReemplazar.Text = "Reemplazar";
            // 
            // lblReemplazarBuscar
            // 
            this.lblReemplazarBuscar.AutoSize = true;
            this.lblReemplazarBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReemplazarBuscar.Location = new System.Drawing.Point(3, 15);
            this.lblReemplazarBuscar.Name = "lblReemplazarBuscar";
            this.lblReemplazarBuscar.Size = new System.Drawing.Size(68, 24);
            this.lblReemplazarBuscar.TabIndex = 9;
            this.lblReemplazarBuscar.Text = "Buscar";
            // 
            // txtReemplazar
            // 
            this.txtReemplazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReemplazar.Location = new System.Drawing.Point(120, 47);
            this.txtReemplazar.Name = "txtReemplazar";
            this.txtReemplazar.Size = new System.Drawing.Size(195, 29);
            this.txtReemplazar.TabIndex = 8;
            // 
            // txtReemplazarBuscar
            // 
            this.txtReemplazarBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReemplazarBuscar.Location = new System.Drawing.Point(120, 12);
            this.txtReemplazarBuscar.Name = "txtReemplazarBuscar";
            this.txtReemplazarBuscar.Size = new System.Drawing.Size(195, 29);
            this.txtReemplazarBuscar.TabIndex = 8;
            // 
            // btnReemplazar
            // 
            this.btnReemplazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReemplazar.Location = new System.Drawing.Point(7, 193);
            this.btnReemplazar.Name = "btnReemplazar";
            this.btnReemplazar.Size = new System.Drawing.Size(437, 40);
            this.btnReemplazar.TabIndex = 7;
            this.btnReemplazar.Text = "Reemplazar Todo";
            this.btnReemplazar.UseVisualStyleBackColor = true;
            this.btnReemplazar.Click += new System.EventHandler(this.btnReemplazar_Click);
            // 
            // tbpIrA
            // 
            this.tbpIrA.Controls.Add(this.nudNumeroDeLinea);
            this.tbpIrA.Controls.Add(this.lblNumeroDeLinea);
            this.tbpIrA.Controls.Add(this.btnIrA);
            this.tbpIrA.Location = new System.Drawing.Point(4, 25);
            this.tbpIrA.Name = "tbpIrA";
            this.tbpIrA.Size = new System.Drawing.Size(462, 231);
            this.tbpIrA.TabIndex = 2;
            this.tbpIrA.Text = "Ir a";
            this.tbpIrA.UseVisualStyleBackColor = true;
            // 
            // nudNumeroDeLinea
            // 
            this.nudNumeroDeLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumeroDeLinea.Location = new System.Drawing.Point(178, 8);
            this.nudNumeroDeLinea.Name = "nudNumeroDeLinea";
            this.nudNumeroDeLinea.Size = new System.Drawing.Size(68, 31);
            this.nudNumeroDeLinea.TabIndex = 13;
            // 
            // lblNumeroDeLinea
            // 
            this.lblNumeroDeLinea.AutoSize = true;
            this.lblNumeroDeLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDeLinea.Location = new System.Drawing.Point(16, 16);
            this.lblNumeroDeLinea.Name = "lblNumeroDeLinea";
            this.lblNumeroDeLinea.Size = new System.Drawing.Size(157, 24);
            this.lblNumeroDeLinea.TabIndex = 12;
            this.lblNumeroDeLinea.Text = "Numero de Linea";
            // 
            // btnIrA
            // 
            this.btnIrA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrA.Location = new System.Drawing.Point(303, 3);
            this.btnIrA.Name = "btnIrA";
            this.btnIrA.Size = new System.Drawing.Size(153, 40);
            this.btnIrA.TabIndex = 10;
            this.btnIrA.Text = "Ir a Linea Dada";
            this.btnIrA.UseVisualStyleBackColor = true;
            this.btnIrA.Click += new System.EventHandler(this.btnIrA_Click);
            // 
            // btnReemplazarUno
            // 
            this.btnReemplazarUno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReemplazarUno.Location = new System.Drawing.Point(323, 47);
            this.btnReemplazarUno.Name = "btnReemplazarUno";
            this.btnReemplazarUno.Size = new System.Drawing.Size(135, 40);
            this.btnReemplazarUno.TabIndex = 11;
            this.btnReemplazarUno.Text = "Reemplazar";
            this.btnReemplazarUno.UseVisualStyleBackColor = true;
            this.btnReemplazarUno.Click += new System.EventHandler(this.btnReemplazarUno_Click);
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 289);
            this.Controls.Add(this.tbcOpciones);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Buscar";
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.Buscar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbcOpciones.ResumeLayout(false);
            this.tbpBuscar.ResumeLayout(false);
            this.tbpBuscar.PerformLayout();
            this.tbpReemplazar.ResumeLayout(false);
            this.tbpReemplazar.PerformLayout();
            this.tbpIrA.ResumeLayout(false);
            this.tbpIrA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroDeLinea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tbcOpciones;
        private System.Windows.Forms.TabPage tbpBuscar;
        private System.Windows.Forms.TabPage tbpReemplazar;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage tbpIrA;
        private System.Windows.Forms.Label lblReemplazar;
        private System.Windows.Forms.Label lblReemplazarBuscar;
        private System.Windows.Forms.TextBox txtReemplazar;
        private System.Windows.Forms.TextBox txtReemplazarBuscar;
        private System.Windows.Forms.Button btnReemplazar;
        private System.Windows.Forms.Label lblNumeroDeLinea;
        private System.Windows.Forms.Button btnIrA;
        private System.Windows.Forms.NumericUpDown nudNumeroDeLinea;
        private System.Windows.Forms.Button btnBuscarReemplazar;
        private System.Windows.Forms.ListBox lstBuscarReemplazar;
        private System.Windows.Forms.Button btnReemplazarUno;
    }
}