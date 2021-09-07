
namespace WFA_FileBrowser
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboDirPath = new System.Windows.Forms.ComboBox();
            this.lstCarpetas = new System.Windows.Forms.ListBox();
            this.lstArchivos = new System.Windows.Forms.ListBox();
            this.pctImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDirPath
            // 
            this.cboDirPath.FormattingEnabled = true;
            this.cboDirPath.Location = new System.Drawing.Point(12, 12);
            this.cboDirPath.Name = "cboDirPath";
            this.cboDirPath.Size = new System.Drawing.Size(382, 21);
            this.cboDirPath.TabIndex = 0;
            this.cboDirPath.SelectedIndexChanged += new System.EventHandler(this.cboDirPath_SelectedIndexChanged);
            this.cboDirPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDirPath_KeyPress);
            // 
            // lstCarpetas
            // 
            this.lstCarpetas.FormattingEnabled = true;
            this.lstCarpetas.Location = new System.Drawing.Point(15, 48);
            this.lstCarpetas.Name = "lstCarpetas";
            this.lstCarpetas.Size = new System.Drawing.Size(172, 264);
            this.lstCarpetas.TabIndex = 1;
            this.lstCarpetas.Click += new System.EventHandler(this.lstCarpetas_Click);
            this.lstCarpetas.SelectedIndexChanged += new System.EventHandler(this.lstCarpetas_SelectedIndexChanged);
            this.lstCarpetas.DoubleClick += new System.EventHandler(this.lstCarpetas_DoubleClick);
            // 
            // lstArchivos
            // 
            this.lstArchivos.FormattingEnabled = true;
            this.lstArchivos.Location = new System.Drawing.Point(205, 47);
            this.lstArchivos.Name = "lstArchivos";
            this.lstArchivos.Size = new System.Drawing.Size(188, 264);
            this.lstArchivos.TabIndex = 2;
            this.lstArchivos.SelectedIndexChanged += new System.EventHandler(this.lstArchivos_SelectedIndexChanged);
            this.lstArchivos.DoubleClick += new System.EventHandler(this.lstArchivos_DoubleClick);
            // 
            // pctImagen
            // 
            this.pctImagen.Location = new System.Drawing.Point(412, 48);
            this.pctImagen.Name = "pctImagen";
            this.pctImagen.Size = new System.Drawing.Size(294, 263);
            this.pctImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctImagen.TabIndex = 3;
            this.pctImagen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctImagen);
            this.Controls.Add(this.lstArchivos);
            this.Controls.Add(this.lstCarpetas);
            this.Controls.Add(this.cboDirPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDirPath;
        private System.Windows.Forms.ListBox lstCarpetas;
        private System.Windows.Forms.ListBox lstArchivos;
        private System.Windows.Forms.PictureBox pctImagen;
    }
}

