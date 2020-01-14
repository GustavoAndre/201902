namespace Capa_Vista
{
    partial class frmOperacion
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
            this.panelPadre = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cOMPRAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESPACHOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPadre
            // 
            this.panelPadre.BackColor = System.Drawing.Color.Gainsboro;
            this.panelPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPadre.Location = new System.Drawing.Point(0, 29);
            this.panelPadre.Name = "panelPadre";
            this.panelPadre.Size = new System.Drawing.Size(627, 263);
            this.panelPadre.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMPRAToolStripMenuItem,
            this.dESPACHOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cOMPRAToolStripMenuItem
            // 
            this.cOMPRAToolStripMenuItem.Name = "cOMPRAToolStripMenuItem";
            this.cOMPRAToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.cOMPRAToolStripMenuItem.Text = "COMPRA";
            this.cOMPRAToolStripMenuItem.Click += new System.EventHandler(this.cOMPRAToolStripMenuItem_Click);
            // 
            // dESPACHOToolStripMenuItem
            // 
            this.dESPACHOToolStripMenuItem.Name = "dESPACHOToolStripMenuItem";
            this.dESPACHOToolStripMenuItem.Size = new System.Drawing.Size(101, 25);
            this.dESPACHOToolStripMenuItem.Text = "DESPACHO";
            // 
            // frmOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 292);
            this.Controls.Add(this.panelPadre);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOperacion";
            this.Text = "frmOperaciones";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPadre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cOMPRAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dESPACHOToolStripMenuItem;
    }
}