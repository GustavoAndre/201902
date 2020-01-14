namespace Capa_Vista
{
    partial class frmConsultaEmpleado01
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
            this.dgBuscarEmpleado = new System.Windows.Forms.DataGrid();
            this.txtBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalEmpleados = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuscarEmpleado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgBuscarEmpleado
            // 
            this.dgBuscarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgBuscarEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgBuscarEmpleado.DataMember = "";
            this.dgBuscarEmpleado.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgBuscarEmpleado.Location = new System.Drawing.Point(12, 76);
            this.dgBuscarEmpleado.Name = "dgBuscarEmpleado";
            this.dgBuscarEmpleado.Size = new System.Drawing.Size(253, 286);
            this.dgBuscarEmpleado.TabIndex = 0;
            // 
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(6, 19);
            this.txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(181, 20);
            this.txtBuscarEmpleado.TabIndex = 1;
            this.txtBuscarEmpleado.TextChanged += new System.EventHandler(this.TxtBuscarEmpleado_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.txtTotalEmpleados);
            this.groupBox1.Location = new System.Drawing.Point(12, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TOTAL EMPLEADOS";
            // 
            // txtTotalEmpleados
            // 
            this.txtTotalEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalEmpleados.Location = new System.Drawing.Point(6, 31);
            this.txtTotalEmpleados.Name = "txtTotalEmpleados";
            this.txtTotalEmpleados.Size = new System.Drawing.Size(140, 20);
            this.txtTotalEmpleados.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBuscarEmpleado);
            this.groupBox2.Location = new System.Drawing.Point(18, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 47);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSCAR EMPLEADO";
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.Location = new System.Drawing.Point(271, 77);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(297, 277);
            this.lstEmpleados.TabIndex = 4;
            // 
            // frmConsultaEmpleado01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 455);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgBuscarEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaEmpleado01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaEmpleado01";
            ((System.ComponentModel.ISupportInitialize)(this.dgBuscarEmpleado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dgBuscarEmpleado;
        private System.Windows.Forms.TextBox txtBuscarEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotalEmpleados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstEmpleados;
    }
}