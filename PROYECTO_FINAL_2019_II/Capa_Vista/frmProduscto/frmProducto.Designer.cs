namespace Capa_Vista
{
    partial class frmProducto
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
            this.dgvMostrarProductos = new System.Windows.Forms.DataGridView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelPadre = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProductos)).BeginInit();
            this.panelPadre.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMostrarProductos
            // 
            this.dgvMostrarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarProductos.Location = new System.Drawing.Point(3, 39);
            this.dgvMostrarProductos.Name = "dgvMostrarProductos";
            this.dgvMostrarProductos.Size = new System.Drawing.Size(834, 524);
            this.dgvMostrarProductos.TabIndex = 0;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(878, 80);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(123, 43);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(878, 129);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 43);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(878, 227);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "ELIMINAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(878, 568);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 43);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelPadre
            // 
            this.panelPadre.Controls.Add(this.dgvMostrarProductos);
            this.panelPadre.Location = new System.Drawing.Point(12, 47);
            this.panelPadre.Name = "panelPadre";
            this.panelPadre.Size = new System.Drawing.Size(840, 563);
            this.panelPadre.TabIndex = 6;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1013, 623);
            this.Controls.Add(this.panelPadre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnagregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProductos)).EndInit();
            this.panelPadre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarProductos;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelPadre;
    }
}