namespace Capa_Vista
{
    partial class frmReporteProductoGeneral
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
            this.crvProductoGeneral = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvProductoGeneral
            // 
            this.crvProductoGeneral.ActiveViewIndex = -1;
            this.crvProductoGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProductoGeneral.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvProductoGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvProductoGeneral.Location = new System.Drawing.Point(0, 0);
            this.crvProductoGeneral.Name = "crvProductoGeneral";
            this.crvProductoGeneral.Size = new System.Drawing.Size(566, 419);
            this.crvProductoGeneral.TabIndex = 0;
            this.crvProductoGeneral.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReporteProductoGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(566, 419);
            this.Controls.Add(this.crvProductoGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteProductoGeneral";
            this.Text = "frmReporteProductoGeneral";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProductoGeneral;
    }
}