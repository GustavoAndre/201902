namespace Capa_Vista
{
    partial class frmCrudCargo
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
            this.chckActCar = new System.Windows.Forms.CheckBox();
            this.gb = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodCar = new System.Windows.Forms.TextBox();
            this.txtNomsCar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesCar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(74, 421);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 29);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // chckActCar
            // 
            this.chckActCar.AutoSize = true;
            this.chckActCar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chckActCar.Location = new System.Drawing.Point(203, 232);
            this.chckActCar.Name = "chckActCar";
            this.chckActCar.Size = new System.Drawing.Size(65, 17);
            this.chckActCar.TabIndex = 1;
            this.chckActCar.Text = "ACTIVO";
            this.chckActCar.UseVisualStyleBackColor = true;
            // 
            // gb
            // 
            this.gb.Controls.Add(this.txtDesCar);
            this.gb.Controls.Add(this.label3);
            this.gb.Controls.Add(this.txtNomsCar);
            this.gb.Controls.Add(this.label2);
            this.gb.Controls.Add(this.txtCodCar);
            this.gb.Controls.Add(this.label1);
            this.gb.Controls.Add(this.chckActCar);
            this.gb.Location = new System.Drawing.Point(12, 12);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(288, 353);
            this.gb.TabIndex = 2;
            this.gb.TabStop = false;
            this.gb.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CODIGO";
            // 
            // txtCodCar
            // 
            this.txtCodCar.Enabled = false;
            this.txtCodCar.Location = new System.Drawing.Point(125, 41);
            this.txtCodCar.Name = "txtCodCar";
            this.txtCodCar.Size = new System.Drawing.Size(143, 20);
            this.txtCodCar.TabIndex = 3;
            // 
            // txtNomsCar
            // 
            this.txtNomsCar.Location = new System.Drawing.Point(125, 67);
            this.txtNomsCar.Name = "txtNomsCar";
            this.txtNomsCar.Size = new System.Drawing.Size(143, 20);
            this.txtNomsCar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOMBRE";
            // 
            // txtDesCar
            // 
            this.txtDesCar.Location = new System.Drawing.Point(125, 93);
            this.txtDesCar.Multiline = true;
            this.txtDesCar.Name = "txtDesCar";
            this.txtDesCar.Size = new System.Drawing.Size(143, 123);
            this.txtDesCar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DESCRIPCION";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(215, 421);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 29);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // frmCrudCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 462);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrudCargo";
            this.Text = "frmCrudCargo";
            this.TopMost = true;
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox chckActCar;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.TextBox txtDesCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomsCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
    }
}