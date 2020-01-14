namespace Capa_Vista
{
    partial class frmImprimirPedido_Despacho
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
            this.crvImprimirPedidoDespacho = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvImprimirPedidoDespacho
            // 
            this.crvImprimirPedidoDespacho.ActiveViewIndex = -1;
            this.crvImprimirPedidoDespacho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvImprimirPedidoDespacho.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvImprimirPedidoDespacho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvImprimirPedidoDespacho.Location = new System.Drawing.Point(0, 0);
            this.crvImprimirPedidoDespacho.Name = "crvImprimirPedidoDespacho";
            this.crvImprimirPedidoDespacho.Size = new System.Drawing.Size(705, 618);
            this.crvImprimirPedidoDespacho.TabIndex = 0;
            this.crvImprimirPedidoDespacho.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmImprimirPedido_Despacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(705, 618);
            this.Controls.Add(this.crvImprimirPedidoDespacho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmImprimirPedido_Despacho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmImprimirPedido_Despacho";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvImprimirPedidoDespacho;
    }
}