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
            this.tAMAÑOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dIFICULTADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nORMALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXTREMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbMostrar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tAMAÑOToolStripMenuItem,
            this.dIFICULTADToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(690, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tAMAÑOToolStripMenuItem
            // 
            this.tAMAÑOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x10ToolStripMenuItem,
            this.x20ToolStripMenuItem,
            this.x30ToolStripMenuItem});
            this.tAMAÑOToolStripMenuItem.Name = "tAMAÑOToolStripMenuItem";
            this.tAMAÑOToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.tAMAÑOToolStripMenuItem.Text = "TAMAÑO";
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
            this.dIFICULTADToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nORMALToolStripMenuItem,
            this.eXTREMAToolStripMenuItem});
            this.dIFICULTADToolStripMenuItem.Name = "dIFICULTADToolStripMenuItem";
            this.dIFICULTADToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.dIFICULTADToolStripMenuItem.Text = "DIFICULTAD";
            // 
            // nORMALToolStripMenuItem
            // 
            this.nORMALToolStripMenuItem.Name = "nORMALToolStripMenuItem";
            this.nORMALToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.nORMALToolStripMenuItem.Text = "NORMAL";
            this.nORMALToolStripMenuItem.Click += new System.EventHandler(this.mnuClick);
            // 
            // eXTREMAToolStripMenuItem
            // 
            this.eXTREMAToolStripMenuItem.Name = "eXTREMAToolStripMenuItem";
            this.eXTREMAToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.eXTREMAToolStripMenuItem.Text = "EXTREMA";
            this.eXTREMAToolStripMenuItem.Click += new System.EventHandler(this.mnuClick);
            // 
            // cbMostrar
            // 
            this.cbMostrar.AutoSize = true;
            this.cbMostrar.Location = new System.Drawing.Point(212, 0);
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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minas restantes:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMostrar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Buscaminas - Jorge Pascual";
            this.Load += new System.EventHandler(this.Buscaminas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tAMAÑOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x20ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dIFICULTADToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nORMALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXTREMAToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

