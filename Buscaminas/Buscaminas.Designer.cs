namespace Buscaminas
{
    partial class Buscaminas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTamanio = new System.Windows.Forms.ToolStripMenuItem();
            this.x10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDificultad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDificultadNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDificultadExtrema = new System.Windows.Forms.ToolStripMenuItem();
            this.cbMostrar = new System.Windows.Forms.CheckBox();
            this.lblValueMinasRestantes = new System.Windows.Forms.Label();
            this.lblMinasRestantes = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTamanio,
            this.mnuDificultad});
            this.menuStrip1.Location = new System.Drawing.Point(0, 10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 10, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(690, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tAMAÑOToolStripMenuItem
            // 
            this.mnuTamanio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x10ToolStripMenuItem,
            this.x20ToolStripMenuItem,
            this.x30ToolStripMenuItem});
            this.mnuTamanio.Name = "tAMAÑOToolStripMenuItem";
            this.mnuTamanio.Size = new System.Drawing.Size(83, 24);
            this.mnuTamanio.Text = "TAMAÑO";
            // 
            // x10ToolStripMenuItem
            // 
            this.x10ToolStripMenuItem.Name = "x10ToolStripMenuItem";
            this.x10ToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.x10ToolStripMenuItem.Text = "10 X 8";
            this.x10ToolStripMenuItem.Click += new System.EventHandler(this.mnuClick);
            // 
            // x20ToolStripMenuItem
            // 
            this.x20ToolStripMenuItem.Name = "x20ToolStripMenuItem";
            this.x20ToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.x20ToolStripMenuItem.Text = "20 X 12";
            this.x20ToolStripMenuItem.Click += new System.EventHandler(this.mnuClick);
            // 
            // x30ToolStripMenuItem
            // 
            this.x30ToolStripMenuItem.Name = "x30ToolStripMenuItem";
            this.x30ToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.x30ToolStripMenuItem.Text = "30 X 20";
            this.x30ToolStripMenuItem.Click += new System.EventHandler(this.mnuClick);
            // 
            // dIFICULTADToolStripMenuItem
            // 
            this.mnuDificultad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDificultadNormal,
            this.mnuDificultadExtrema});
            this.mnuDificultad.Name = "dIFICULTADToolStripMenuItem";
            this.mnuDificultad.Size = new System.Drawing.Size(100, 24);
            this.mnuDificultad.Text = "DIFICULTAD";
            // 
            // nORMALToolStripMenuItem
            // 
            this.mnuDificultadNormal.Name = "nORMALToolStripMenuItem";
            this.mnuDificultadNormal.Size = new System.Drawing.Size(149, 26);
            this.mnuDificultadNormal.Text = "NORMAL";
            this.mnuDificultadNormal.Click += new System.EventHandler(this.mnuClick);
            // 
            // eXTREMAToolStripMenuItem
            // 
            this.mnuDificultadExtrema.Name = "eXTREMAToolStripMenuItem";
            this.mnuDificultadExtrema.Size = new System.Drawing.Size(149, 26);
            this.mnuDificultadExtrema.Text = "EXTREMA";
            this.mnuDificultadExtrema.Click += new System.EventHandler(this.mnuClick);
            // 
            // cbMostrar
            // 
            this.cbMostrar.AutoSize = true;
            this.cbMostrar.Location = new System.Drawing.Point(225, 10);
            this.cbMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.cbMostrar.Name = "cbMostrar";
            this.cbMostrar.Size = new System.Drawing.Size(119, 21);
            this.cbMostrar.TabIndex = 1;
            this.cbMostrar.Text = "Mostrar minas";
            this.cbMostrar.UseVisualStyleBackColor = true;
            this.cbMostrar.CheckedChanged += new System.EventHandler(this.mostrarMinas);
            // 
            // label1
            // 
            this.lblValueMinasRestantes.AutoSize = true;
            this.lblValueMinasRestantes.Location = new System.Drawing.Point(490, 10);
            this.lblValueMinasRestantes.Name = "lblValueMinasRestantes";
            this.lblValueMinasRestantes.Size = new System.Drawing.Size(0, 17);
            this.lblValueMinasRestantes.TabIndex = 2;
            // 
            // label2
            // 
            this.lblMinasRestantes.AutoSize = true;
            this.lblMinasRestantes.Location = new System.Drawing.Point(370, 10);
            this.lblMinasRestantes.Name = "lblMinasRestantes";
            this.lblMinasRestantes.Size = new System.Drawing.Size(112, 17);
            this.lblMinasRestantes.TabIndex = 3;
            this.lblMinasRestantes.Text = "Minas restantes:";
            // 
            // Buscaminas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 353);
            this.Controls.Add(this.lblMinasRestantes);
            this.Controls.Add(this.lblValueMinasRestantes);
            this.Controls.Add(this.cbMostrar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Buscaminas";
            this.Text = "Buscaminas - Jorge Pascual";
            this.Load += new System.EventHandler(this.Buscaminas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTamanio;
        private System.Windows.Forms.ToolStripMenuItem x10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x20ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDificultad;
        private System.Windows.Forms.ToolStripMenuItem mnuDificultadNormal;
        private System.Windows.Forms.ToolStripMenuItem mnuDificultadExtrema;
        private System.Windows.Forms.CheckBox cbMostrar;
        private System.Windows.Forms.Label lblValueMinasRestantes;
        private System.Windows.Forms.Label lblMinasRestantes;
    }
}

