namespace Capa_Vista
{
    partial class frmConsultaEmpleadoxArea
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
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.lblmsg = new System.Windows.Forms.Label();
            this.lvEmpleados = new System.Windows.Forms.ListView();
            this.trvAreas = new System.Windows.Forms.TreeView();
            this.panelDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetalle
            // 
            this.panelDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panelDetalle.Controls.Add(this.lblmsg);
            this.panelDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetalle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelDetalle.Location = new System.Drawing.Point(0, 0);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(596, 32);
            this.panelDetalle.TabIndex = 5;
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
            // lvEmpleados
            // 
            this.lvEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEmpleados.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvEmpleados.HideSelection = false;
            this.lvEmpleados.Location = new System.Drawing.Point(183, 38);
            this.lvEmpleados.Name = "lvEmpleados";
            this.lvEmpleados.Size = new System.Drawing.Size(401, 296);
            this.lvEmpleados.TabIndex = 4;
            this.lvEmpleados.UseCompatibleStateImageBehavior = false;
            this.lvEmpleados.View = System.Windows.Forms.View.Details;
            // 
            // trvAreas
            // 
            this.trvAreas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trvAreas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trvAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvAreas.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.trvAreas.Location = new System.Drawing.Point(9, 38);
            this.trvAreas.Name = "trvAreas";
            this.trvAreas.Size = new System.Drawing.Size(165, 296);
            this.trvAreas.TabIndex = 3;
            this.trvAreas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrvAreas_AfterSelect);
            // 
            // frmConsultaEmpleadoxArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(596, 346);
            this.Controls.Add(this.panelDetalle);
            this.Controls.Add(this.lvEmpleados);
            this.Controls.Add(this.trvAreas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaEmpleadoxArea";
            this.Text = "frmConsultaEmpleadoxArea";
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.ListView lvEmpleados;
        private System.Windows.Forms.TreeView trvAreas;
    }
}