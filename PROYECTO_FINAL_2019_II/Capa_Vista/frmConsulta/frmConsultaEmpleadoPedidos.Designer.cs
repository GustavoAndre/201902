namespace Capa_Vista
{
    partial class frmConsultaEmpleadoPedidos
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
            this.trvPedidos = new System.Windows.Forms.TreeView();
            this.lvPedidos = new System.Windows.Forms.ListView();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.lblmsg = new System.Windows.Forms.Label();
            this.panelDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvPedidos
            // 
            this.trvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trvPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvPedidos.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.trvPedidos.Location = new System.Drawing.Point(9, 38);
            this.trvPedidos.Name = "trvPedidos";
            this.trvPedidos.Size = new System.Drawing.Size(165, 292);
            this.trvPedidos.TabIndex = 0;
            this.trvPedidos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrvPedidos_AfterSelect);
            // 
            // lvPedidos
            // 
            this.lvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPedidos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPedidos.HideSelection = false;
            this.lvPedidos.Location = new System.Drawing.Point(183, 38);
            this.lvPedidos.Name = "lvPedidos";
            this.lvPedidos.Size = new System.Drawing.Size(418, 292);
            this.lvPedidos.TabIndex = 1;
            this.lvPedidos.UseCompatibleStateImageBehavior = false;
            this.lvPedidos.View = System.Windows.Forms.View.Details;
            // 
            // panelDetalle
            // 
            this.panelDetalle.Controls.Add(this.lblmsg);
            this.panelDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetalle.Location = new System.Drawing.Point(0, 0);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(613, 32);
            this.panelDetalle.TabIndex = 2;
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.Location = new System.Drawing.Point(3, 6);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(72, 20);
            this.lblmsg.TabIndex = 0;
            this.lblmsg.Text = "Mensaje";
            // 
            // frmConsultaEmpleadoPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(613, 342);
            this.Controls.Add(this.panelDetalle);
            this.Controls.Add(this.lvPedidos);
            this.Controls.Add(this.trvPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaEmpleadoPedidos";
            this.Text = "frmConsultaEmpleado";
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvPedidos;
        private System.Windows.Forms.ListView lvPedidos;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Label lblmsg;
    }
}