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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrudEmpleado));
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
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.Chartreuse;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(144, 520);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 47);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Aceptar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(262, 520);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 47);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo ";
            // 
            // txtCodEmp
            // 
            this.txtCodEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCodEmp.Enabled = false;
            this.txtCodEmp.Location = new System.Drawing.Point(190, 38);
            this.txtCodEmp.Name = "txtCodEmp";
            this.txtCodEmp.Size = new System.Drawing.Size(155, 20);
            this.txtCodEmp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cargo:";
            // 
            // txtApePatEmp
            // 
            this.txtApePatEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtApePatEmp.Location = new System.Drawing.Point(190, 64);
            this.txtApePatEmp.Name = "txtApePatEmp";
            this.txtApePatEmp.Size = new System.Drawing.Size(155, 20);
            this.txtApePatEmp.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido Paterno";
            // 
            // txtApeMatEmp
            // 
            this.txtApeMatEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtApeMatEmp.Location = new System.Drawing.Point(190, 90);
            this.txtApeMatEmp.Name = "txtApeMatEmp";
            this.txtApeMatEmp.Size = new System.Drawing.Size(155, 20);
            this.txtApeMatEmp.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido Materno";
            // 
            // txtNomEmp
            // 
            this.txtNomEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNomEmp.Location = new System.Drawing.Point(190, 116);
            this.txtNomEmp.Name = "txtNomEmp";
            this.txtNomEmp.Size = new System.Drawing.Size(155, 20);
            this.txtNomEmp.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha de Ingreso";
            // 
            // txtObsEmp
            // 
            this.txtObsEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtObsEmp.Location = new System.Drawing.Point(190, 300);
            this.txtObsEmp.Multiline = true;
            this.txtObsEmp.Name = "txtObsEmp";
            this.txtObsEmp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObsEmp.Size = new System.Drawing.Size(155, 62);
            this.txtObsEmp.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Observaciones";
            // 
            // txtCorEmp
            // 
            this.txtCorEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCorEmp.Location = new System.Drawing.Point(190, 274);
            this.txtCorEmp.Name = "txtCorEmp";
            this.txtCorEmp.Size = new System.Drawing.Size(155, 20);
            this.txtCorEmp.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Correo";
            // 
            // txtCelEmp
            // 
            this.txtCelEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCelEmp.Location = new System.Drawing.Point(190, 248);
            this.txtCelEmp.MaxLength = 9;
            this.txtCelEmp.Name = "txtCelEmp";
            this.txtCelEmp.Size = new System.Drawing.Size(155, 20);
            this.txtCelEmp.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nombre";
            // 
            // txtTelEmp
            // 
            this.txtTelEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTelEmp.Location = new System.Drawing.Point(190, 222);
            this.txtTelEmp.MaxLength = 8;
            this.txtTelEmp.Name = "txtTelEmp";
            this.txtTelEmp.Size = new System.Drawing.Size(155, 20);
            this.txtTelEmp.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Celular";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Telefono";
            // 
            // txtFecIngEmp
            // 
            this.txtFecIngEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFecIngEmp.Location = new System.Drawing.Point(190, 169);
            this.txtFecIngEmp.Name = "txtFecIngEmp";
            this.txtFecIngEmp.Size = new System.Drawing.Size(155, 20);
            this.txtFecIngEmp.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Distrito";
            // 
            // chckActivo
            // 
            this.chckActivo.AutoSize = true;
            this.chckActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chckActivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckActivo.Location = new System.Drawing.Point(276, 449);
            this.chckActivo.Name = "chckActivo";
            this.chckActivo.Size = new System.Drawing.Size(69, 21);
            this.chckActivo.TabIndex = 26;
            this.chckActivo.Text = "Activo";
            this.chckActivo.UseVisualStyleBackColor = true;
            // 
            // cboCodCargo
            // 
            this.cboCodCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboCodCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodCargo.FormattingEnabled = true;
            this.cboCodCargo.Location = new System.Drawing.Point(190, 395);
            this.cboCodCargo.Name = "cboCodCargo";
            this.cboCodCargo.Size = new System.Drawing.Size(155, 21);
            this.cboCodCargo.TabIndex = 27;
            // 
            // cboCodDis
            // 
            this.cboCodDis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboCodDis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodDis.FormattingEnabled = true;
            this.cboCodDis.Location = new System.Drawing.Point(190, 368);
            this.cboCodDis.Name = "cboCodDis";
            this.cboCodDis.Size = new System.Drawing.Size(155, 21);
            this.cboCodDis.TabIndex = 28;
            // 
            // dtpFecNacEmp
            // 
            this.dtpFecNacEmp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecNacEmp.Location = new System.Drawing.Point(190, 143);
            this.dtpFecNacEmp.Name = "dtpFecNacEmp";
            this.dtpFecNacEmp.Size = new System.Drawing.Size(155, 20);
            this.dtpFecNacEmp.TabIndex = 29;
            // 
            // cboArea
            // 
            this.cboArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(190, 422);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(155, 21);
            this.cboArea.TabIndex = 30;
            // 
            // cboSexo
            // 
            this.cboSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(190, 195);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(155, 21);
            this.cboSexo.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "Sexo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 424);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 17);
            this.label14.TabIndex = 33;
            this.label14.Text = "Area:";
            // 
            // gb
            // 
            this.gb.BackColor = System.Drawing.SystemColors.HotTrack;
            this.gb.Controls.Add(this.txtCodEmp);
            this.gb.Controls.Add(this.label14);
            this.gb.Controls.Add(this.label1);
            this.gb.Controls.Add(this.label13);
            this.gb.Controls.Add(this.label2);
            this.gb.Controls.Add(this.cboSexo);
            this.gb.Controls.Add(this.label3);
            this.gb.Controls.Add(this.cboArea);
            this.gb.Controls.Add(this.txtApePatEmp);
            this.gb.Controls.Add(this.dtpFecNacEmp);
            this.gb.Controls.Add(this.label4);
            this.gb.Controls.Add(this.cboCodDis);
            this.gb.Controls.Add(this.txtApeMatEmp);
            this.gb.Controls.Add(this.cboCodCargo);
            this.gb.Controls.Add(this.label5);
            this.gb.Controls.Add(this.chckActivo);
            this.gb.Controls.Add(this.txtNomEmp);
            this.gb.Controls.Add(this.txtObsEmp);
            this.gb.Controls.Add(this.label6);
            this.gb.Controls.Add(this.label7);
            this.gb.Controls.Add(this.label12);
            this.gb.Controls.Add(this.txtCorEmp);
            this.gb.Controls.Add(this.txtFecIngEmp);
            this.gb.Controls.Add(this.label8);
            this.gb.Controls.Add(this.label11);
            this.gb.Controls.Add(this.txtCelEmp);
            this.gb.Controls.Add(this.label10);
            this.gb.Controls.Add(this.label9);
            this.gb.Controls.Add(this.txtTelEmp);
            this.gb.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gb.Location = new System.Drawing.Point(12, 12);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(362, 499);
            this.gb.TabIndex = 34;
            this.gb.TabStop = false;
            this.gb.Text = "gb";
            // 
            // frmCrudEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 579);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCrudEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPLEADO";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmCrudEmpleado_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gb;
    }
}