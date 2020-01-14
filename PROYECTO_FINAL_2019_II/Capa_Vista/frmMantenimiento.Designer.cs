namespace Capa_Vista
{
    partial class frmMantenimiento
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATEGORIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPLEADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dISTRITOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROVEEDORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cARGOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPadre = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.IndianRed;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRODUCTOSToolStripMenuItem,
            this.cATEGORIAToolStripMenuItem,
            this.cLIENTESToolStripMenuItem,
            this.eMPLEADOSToolStripMenuItem,
            this.dISTRITOToolStripMenuItem,
            this.pROVEEDORToolStripMenuItem,
            this.cARGOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1119, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pRODUCTOSToolStripMenuItem
            // 
            this.pRODUCTOSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pRODUCTOSToolStripMenuItem.Name = "pRODUCTOSToolStripMenuItem";
            this.pRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(108, 25);
            this.pRODUCTOSToolStripMenuItem.Text = "PRODUCTO";
            this.pRODUCTOSToolStripMenuItem.Click += new System.EventHandler(this.pRODUCTOSToolStripMenuItem_Click_1);
            // 
            // cATEGORIAToolStripMenuItem
            // 
            this.cATEGORIAToolStripMenuItem.Name = "cATEGORIAToolStripMenuItem";
            this.cATEGORIAToolStripMenuItem.Size = new System.Drawing.Size(109, 25);
            this.cATEGORIAToolStripMenuItem.Text = "CATEGORIA";
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTE";
            this.cLIENTESToolStripMenuItem.Click += new System.EventHandler(this.cLIENTESToolStripMenuItem_Click);
            // 
            // eMPLEADOSToolStripMenuItem
            // 
            this.eMPLEADOSToolStripMenuItem.Name = "eMPLEADOSToolStripMenuItem";
            this.eMPLEADOSToolStripMenuItem.Size = new System.Drawing.Size(108, 25);
            this.eMPLEADOSToolStripMenuItem.Text = "EMPLEADO";
            // 
            // dISTRITOToolStripMenuItem
            // 
            this.dISTRITOToolStripMenuItem.Name = "dISTRITOToolStripMenuItem";
            this.dISTRITOToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.dISTRITOToolStripMenuItem.Text = "DISTRITO";
            // 
            // pROVEEDORToolStripMenuItem
            // 
            this.pROVEEDORToolStripMenuItem.Name = "pROVEEDORToolStripMenuItem";
            this.pROVEEDORToolStripMenuItem.Size = new System.Drawing.Size(117, 25);
            this.pROVEEDORToolStripMenuItem.Text = "PROVEEDOR";
            // 
            // cARGOToolStripMenuItem
            // 
            this.cARGOToolStripMenuItem.Name = "cARGOToolStripMenuItem";
            this.cARGOToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.cARGOToolStripMenuItem.Text = "CARGO";
            // 
            // panelPadre
            // 
            this.panelPadre.Location = new System.Drawing.Point(0, 55);
            this.panelPadre.Name = "panelPadre";
            this.panelPadre.Size = new System.Drawing.Size(1119, 553);
            this.panelPadre.TabIndex = 1;
            // 
            // frmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 662);
            this.Controls.Add(this.panelPadre);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frmMantenimiento";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATEGORIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPLEADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dISTRITOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROVEEDORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cARGOToolStripMenuItem;
        private System.Windows.Forms.Panel panelPadre;
    }
}