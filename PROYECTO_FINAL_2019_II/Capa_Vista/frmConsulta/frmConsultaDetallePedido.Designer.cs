namespace Capa_Vista
{
    partial class frmConsultaDetallePedido
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
            this.dgConsultaDetallePedido = new System.Windows.Forms.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaDetallePedido)).BeginInit();
            this.SuspendLayout();
            // 
            // dgConsultaDetallePedido
            // 
            this.dgConsultaDetallePedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgConsultaDetallePedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgConsultaDetallePedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgConsultaDetallePedido.CaptionBackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgConsultaDetallePedido.CaptionText = "DATAGRID";
            this.dgConsultaDetallePedido.DataMember = "";
            this.dgConsultaDetallePedido.HeaderBackColor = System.Drawing.Color.SteelBlue;
            this.dgConsultaDetallePedido.HeaderFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgConsultaDetallePedido.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgConsultaDetallePedido.LinkColor = System.Drawing.Color.DarkOrange;
            this.dgConsultaDetallePedido.Location = new System.Drawing.Point(12, 12);
            this.dgConsultaDetallePedido.Name = "dgConsultaDetallePedido";
            this.dgConsultaDetallePedido.ReadOnly = true;
            this.dgConsultaDetallePedido.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgConsultaDetallePedido.Size = new System.Drawing.Size(812, 458);
            this.dgConsultaDetallePedido.TabIndex = 0;
            // 
            // frmConsultaDetallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 482);
            this.Controls.Add(this.dgConsultaDetallePedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaDetallePedido";
            this.Text = "frmConsultaDetallePedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaDetallePedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dgConsultaDetallePedido;
    }
}