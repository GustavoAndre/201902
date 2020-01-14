namespace Capa_Vista
{
    partial class frmCrudArea
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
            this.gb = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodAre = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chckActAre = new System.Windows.Forms.CheckBox();
            this.txtNomAre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.Controls.Add(this.txtNomAre);
            this.gb.Controls.Add(this.label2);
            this.gb.Controls.Add(this.chckActAre);
            this.gb.Controls.Add(this.txtCodAre);
            this.gb.Controls.Add(this.label1);
            this.gb.Location = new System.Drawing.Point(12, 12);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(265, 280);
            this.gb.TabIndex = 0;
            this.gb.TabStop = false;
            this.gb.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO: ";
            // 
            // txtCodAre
            // 
            this.txtCodAre.Enabled = false;
            this.txtCodAre.Location = new System.Drawing.Point(100, 42);
            this.txtCodAre.Name = "txtCodAre";
            this.txtCodAre.Size = new System.Drawing.Size(137, 20);
            this.txtCodAre.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(202, 335);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // chckActAre
            // 
            this.chckActAre.AutoSize = true;
            this.chckActAre.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chckActAre.Location = new System.Drawing.Point(172, 144);
            this.chckActAre.Name = "chckActAre";
            this.chckActAre.Size = new System.Drawing.Size(65, 17);
            this.chckActAre.TabIndex = 2;
            this.chckActAre.Text = "ACTIVO";
            this.chckActAre.UseVisualStyleBackColor = true;
            // 
            // txtNomAre
            // 
            this.txtNomAre.Location = new System.Drawing.Point(100, 79);
            this.txtNomAre.Name = "txtNomAre";
            this.txtNomAre.Size = new System.Drawing.Size(137, 20);
            this.txtNomAre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE: ";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(70, 335);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(126, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // frmCrudArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 370);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrudArea";
            this.Text = "frmCrudArea";
            this.TopMost = true;
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.TextBox txtNomAre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chckActAre;
        private System.Windows.Forms.TextBox txtCodAre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}