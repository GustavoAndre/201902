namespace Capa_Vista
{
    partial class frmCrudEmpleado
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodEmp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApePatEmp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApeMatEmp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomEmp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObsEmp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorEmp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCelEmp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelEmp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFecIngEmp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chckActivo = new System.Windows.Forms.CheckBox();
            this.cboCodCargo = new System.Windows.Forms.ComboBox();
            this.cboCodDis = new System.Windows.Forms.ComboBox();
            this.dtpFecNacEmp = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(440, 341);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(521, 341);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo ";
            // 
            // txtCodEmp
            // 
            this.txtCodEmp.Location = new System.Drawing.Point(152, 12);
            this.txtCodEmp.Name = "txtCodEmp";
            this.txtCodEmp.Size = new System.Drawing.Size(121, 20);
            this.txtCodEmp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cargo:";
            // 
            // txtApePatEmp
            // 
            this.txtApePatEmp.Location = new System.Drawing.Point(152, 64);
            this.txtApePatEmp.Name = "txtApePatEmp";
            this.txtApePatEmp.Size = new System.Drawing.Size(121, 20);
            this.txtApePatEmp.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido Paterno";
            // 
            // txtApeMatEmp
            // 
            this.txtApeMatEmp.Location = new System.Drawing.Point(152, 90);
            this.txtApeMatEmp.Name = "txtApeMatEmp";
            this.txtApeMatEmp.Size = new System.Drawing.Size(121, 20);
            this.txtApeMatEmp.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido Materno";
            // 
            // txtNomEmp
            // 
            this.txtNomEmp.Location = new System.Drawing.Point(152, 116);
            this.txtNomEmp.Name = "txtNomEmp";
            this.txtNomEmp.Size = new System.Drawing.Size(121, 20);
            this.txtNomEmp.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha de Ingreso";
            // 
            // txtObsEmp
            // 
            this.txtObsEmp.Location = new System.Drawing.Point(466, 142);
            this.txtObsEmp.Name = "txtObsEmp";
            this.txtObsEmp.Size = new System.Drawing.Size(121, 20);
            this.txtObsEmp.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Observaciones";
            // 
            // txtCorEmp
            // 
            this.txtCorEmp.Location = new System.Drawing.Point(466, 116);
            this.txtCorEmp.Name = "txtCorEmp";
            this.txtCorEmp.Size = new System.Drawing.Size(121, 20);
            this.txtCorEmp.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Correo";
            // 
            // txtCelEmp
            // 
            this.txtCelEmp.Location = new System.Drawing.Point(466, 90);
            this.txtCelEmp.MaxLength = 9;
            this.txtCelEmp.Name = "txtCelEmp";
            this.txtCelEmp.Size = new System.Drawing.Size(121, 20);
            this.txtCelEmp.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nombre";
            // 
            // txtTelEmp
            // 
            this.txtTelEmp.Location = new System.Drawing.Point(466, 64);
            this.txtTelEmp.MaxLength = 8;
            this.txtTelEmp.Name = "txtTelEmp";
            this.txtTelEmp.Size = new System.Drawing.Size(121, 20);
            this.txtTelEmp.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(370, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Celular";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(370, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Telefono";
            // 
            // txtFecIngEmp
            // 
            this.txtFecIngEmp.Location = new System.Drawing.Point(466, 12);
            this.txtFecIngEmp.Name = "txtFecIngEmp";
            this.txtFecIngEmp.Size = new System.Drawing.Size(121, 20);
            this.txtFecIngEmp.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(370, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Distrito";
            // 
            // chckActivo
            // 
            this.chckActivo.AutoSize = true;
            this.chckActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chckActivo.Location = new System.Drawing.Point(531, 177);
            this.chckActivo.Name = "chckActivo";
            this.chckActivo.Size = new System.Drawing.Size(56, 17);
            this.chckActivo.TabIndex = 26;
            this.chckActivo.Text = "Activo";
            this.chckActivo.UseVisualStyleBackColor = true;
            // 
            // cboCodCargo
            // 
            this.cboCodCargo.FormattingEnabled = true;
            this.cboCodCargo.Location = new System.Drawing.Point(152, 37);
            this.cboCodCargo.Name = "cboCodCargo";
            this.cboCodCargo.Size = new System.Drawing.Size(121, 21);
            this.cboCodCargo.TabIndex = 27;
            // 
            // cboCodDis
            // 
            this.cboCodDis.FormattingEnabled = true;
            this.cboCodDis.Location = new System.Drawing.Point(466, 37);
            this.cboCodDis.Name = "cboCodDis";
            this.cboCodDis.Size = new System.Drawing.Size(121, 21);
            this.cboCodDis.TabIndex = 28;
            // 
            // dtpFecNacEmp
            // 
            this.dtpFecNacEmp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecNacEmp.Location = new System.Drawing.Point(152, 143);
            this.dtpFecNacEmp.Name = "dtpFecNacEmp";
            this.dtpFecNacEmp.Size = new System.Drawing.Size(121, 20);
            this.dtpFecNacEmp.TabIndex = 29;
            // 
            // frmCrudEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 376);
            this.Controls.Add(this.dtpFecNacEmp);
            this.Controls.Add(this.cboCodDis);
            this.Controls.Add(this.cboCodCargo);
            this.Controls.Add(this.chckActivo);
            this.Controls.Add(this.txtObsEmp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCorEmp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCelEmp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTelEmp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFecIngEmp);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNomEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApeMatEmp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApePatEmp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodEmp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrudEmpleado";
            this.Text = "frmCrudEmpleado";
            this.Load += new System.EventHandler(this.FrmCrudEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApePatEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApeMatEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomEmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObsEmp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCorEmp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCelEmp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelEmp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFecIngEmp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chckActivo;
        private System.Windows.Forms.ComboBox cboCodCargo;
        private System.Windows.Forms.ComboBox cboCodDis;
        private System.Windows.Forms.DateTimePicker dtpFecNacEmp;
    }
}