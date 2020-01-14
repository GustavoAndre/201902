namespace Capa_Vista
{
    partial class frmCrudAlmacen
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
            this.txtUbicacionAlmacen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcionAlmacen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreAlmacen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdAlmacen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gb.Controls.Add(this.txtUbicacionAlmacen);
            this.gb.Controls.Add(this.label4);
            this.gb.Controls.Add(this.txtDescripcionAlmacen);
            this.gb.Controls.Add(this.label3);
            this.gb.Controls.Add(this.txtNombreAlmacen);
            this.gb.Controls.Add(this.label2);
            this.gb.Controls.Add(this.txtIdAlmacen);
            this.gb.Controls.Add(this.label1);
            this.gb.Controls.Add(this.chkActivo);
            this.gb.Location = new System.Drawing.Point(12, 12);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(311, 305);
            this.gb.TabIndex = 0;
            this.gb.TabStop = false;
            this.gb.Text = "groupBox1";
            // 
            // txtUbicacionAlmacen
            // 
            this.txtUbicacionAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUbicacionAlmacen.Location = new System.Drawing.Point(144, 151);
            this.txtUbicacionAlmacen.Multiline = true;
            this.txtUbicacionAlmacen.Name = "txtUbicacionAlmacen";
            this.txtUbicacionAlmacen.Size = new System.Drawing.Size(146, 62);
            this.txtUbicacionAlmacen.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "UBICACION";
            // 
            // txtDescripcionAlmacen
            // 
            this.txtDescripcionAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDescripcionAlmacen.Location = new System.Drawing.Point(144, 83);
            this.txtDescripcionAlmacen.Multiline = true;
            this.txtDescripcionAlmacen.Name = "txtDescripcionAlmacen";
            this.txtDescripcionAlmacen.Size = new System.Drawing.Size(146, 62);
            this.txtDescripcionAlmacen.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DESCRIPCION";
            // 
            // txtNombreAlmacen
            // 
            this.txtNombreAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNombreAlmacen.Location = new System.Drawing.Point(144, 57);
            this.txtNombreAlmacen.Name = "txtNombreAlmacen";
            this.txtNombreAlmacen.Size = new System.Drawing.Size(146, 20);
            this.txtNombreAlmacen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE";
            // 
            // txtIdAlmacen
            // 
            this.txtIdAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIdAlmacen.Location = new System.Drawing.Point(144, 31);
            this.txtIdAlmacen.Name = "txtIdAlmacen";
            this.txtIdAlmacen.Size = new System.Drawing.Size(146, 20);
            this.txtIdAlmacen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkActivo.Location = new System.Drawing.Point(234, 257);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 0;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(211, 342);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 47);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(93, 342);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 47);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // frmCrudAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 401);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gb);
            this.Name = "frmCrudAlmacen";
            this.Text = "ALMACEN";
            this.TopMost = true;
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.TextBox txtUbicacionAlmacen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcionAlmacen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreAlmacen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdAlmacen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}