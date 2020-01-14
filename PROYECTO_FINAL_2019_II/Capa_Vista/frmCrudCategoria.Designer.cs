namespace Capa_Vista
{
    partial class frmCrudCategoria
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
            this.chckactivo = new System.Windows.Forms.CheckBox();
            this.txtDesCat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomCat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodCat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gb = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // chckactivo
            // 
            this.chckactivo.AutoSize = true;
            this.chckactivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chckactivo.Location = new System.Drawing.Point(262, 149);
            this.chckactivo.Name = "chckactivo";
            this.chckactivo.Size = new System.Drawing.Size(56, 17);
            this.chckactivo.TabIndex = 18;
            this.chckactivo.Text = "Activo";
            this.chckactivo.UseVisualStyleBackColor = true;
            // 
            // txtDesCat
            // 
            this.txtDesCat.Location = new System.Drawing.Point(102, 97);
            this.txtDesCat.Multiline = true;
            this.txtDesCat.Name = "txtDesCat";
            this.txtDesCat.Size = new System.Drawing.Size(216, 46);
            this.txtDesCat.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descripcion";
            // 
            // txtNomCat
            // 
            this.txtNomCat.Location = new System.Drawing.Point(102, 64);
            this.txtNomCat.Name = "txtNomCat";
            this.txtNomCat.Size = new System.Drawing.Size(216, 20);
            this.txtNomCat.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre:";
            // 
            // txtCodCat
            // 
            this.txtCodCat.Enabled = false;
            this.txtCodCat.Location = new System.Drawing.Point(102, 31);
            this.txtCodCat.Name = "txtCodCat";
            this.txtCodCat.Size = new System.Drawing.Size(216, 20);
            this.txtCodCat.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codigo: ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(285, 300);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // gb
            // 
            this.gb.Controls.Add(this.txtCodCat);
            this.gb.Controls.Add(this.label1);
            this.gb.Controls.Add(this.chckactivo);
            this.gb.Controls.Add(this.label2);
            this.gb.Controls.Add(this.txtDesCat);
            this.gb.Controls.Add(this.txtNomCat);
            this.gb.Controls.Add(this.label3);
            this.gb.Location = new System.Drawing.Point(12, 12);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(348, 244);
            this.gb.TabIndex = 20;
            this.gb.TabStop = false;
            this.gb.Text = "groupBox1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(127, 300);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 23);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // frmCrudCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 335);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrudCategoria";
            this.Text = "frmCrudCategoria";
            this.TopMost = true;
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chckactivo;
        private System.Windows.Forms.TextBox txtDesCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Button btnGuardar;
    }
}