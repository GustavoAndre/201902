namespace Capa_Vista
{
    partial class frmConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTOCKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dETALLEDECOMPRAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despachoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pROVEEDORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPLEADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fECHADEINGRESOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPadre = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.compraToolStripMenuItem,
            this.despachoToolStripMenuItem,
            this.pROVEEDORToolStripMenuItem,
            this.eMPLEADOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.sTOCKToolStripMenuItem});
            this.productosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(113, 25);
            this.productosToolStripMenuItem.Text = "PRODUCTOS";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.categoriaToolStripMenuItem.Text = "CATEGORIA";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.CategoriaToolStripMenuItem_Click);
            // 
            // sTOCKToolStripMenuItem
            // 
            this.sTOCKToolStripMenuItem.Name = "sTOCKToolStripMenuItem";
            this.sTOCKToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.sTOCKToolStripMenuItem.Text = "STOCK";
            this.sTOCKToolStripMenuItem.Click += new System.EventHandler(this.sTOCKToolStripMenuItem_Click);
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dETALLEDECOMPRAToolStripMenuItem,
            this.empleadoToolStripMenuItem1,
            this.fechaToolStripMenuItem});
            this.compraToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compraToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.compraToolStripMenuItem.Text = "COMPRAS";
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.CompraToolStripMenuItem_Click);
            // 
            // dETALLEDECOMPRAToolStripMenuItem
            // 
            this.dETALLEDECOMPRAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dETALLEDECOMPRAToolStripMenuItem.Image")));
            this.dETALLEDECOMPRAToolStripMenuItem.Name = "dETALLEDECOMPRAToolStripMenuItem";
            this.dETALLEDECOMPRAToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.dETALLEDECOMPRAToolStripMenuItem.Text = "Detalle de compra";
            this.dETALLEDECOMPRAToolStripMenuItem.Click += new System.EventHandler(this.DETALLEDECOMPRAToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem1
            // 
            this.empleadoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("empleadoToolStripMenuItem1.Image")));
            this.empleadoToolStripMenuItem1.Name = "empleadoToolStripMenuItem1";
            this.empleadoToolStripMenuItem1.Size = new System.Drawing.Size(206, 26);
            this.empleadoToolStripMenuItem1.Text = "Empleado";
            this.empleadoToolStripMenuItem1.Click += new System.EventHandler(this.EmpleadoToolStripMenuItem1_Click);
            // 
            // fechaToolStripMenuItem
            // 
            this.fechaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fechaToolStripMenuItem.Image")));
            this.fechaToolStripMenuItem.Name = "fechaToolStripMenuItem";
            this.fechaToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.fechaToolStripMenuItem.Text = "Fecha";
            // 
            // despachoToolStripMenuItem
            // 
            this.despachoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechaToolStripMenuItem1,
            this.empleadoToolStripMenuItem2});
            this.despachoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.despachoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.despachoToolStripMenuItem.Name = "despachoToolStripMenuItem";
            this.despachoToolStripMenuItem.Size = new System.Drawing.Size(110, 25);
            this.despachoToolStripMenuItem.Text = "DESPACHOS";
            // 
            // fechaToolStripMenuItem1
            // 
            this.fechaToolStripMenuItem1.Name = "fechaToolStripMenuItem1";
            this.fechaToolStripMenuItem1.Size = new System.Drawing.Size(149, 26);
            this.fechaToolStripMenuItem1.Text = "Fecha";
            // 
            // empleadoToolStripMenuItem2
            // 
            this.empleadoToolStripMenuItem2.Name = "empleadoToolStripMenuItem2";
            this.empleadoToolStripMenuItem2.Size = new System.Drawing.Size(149, 26);
            this.empleadoToolStripMenuItem2.Text = "Empleado";
            // 
            // pROVEEDORToolStripMenuItem
            // 
            this.pROVEEDORToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pROVEEDORToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pROVEEDORToolStripMenuItem.Name = "pROVEEDORToolStripMenuItem";
            this.pROVEEDORToolStripMenuItem.Size = new System.Drawing.Size(112, 25);
            this.pROVEEDORToolStripMenuItem.Text = "PROVEEDOR";
            // 
            // eMPLEADOToolStripMenuItem
            // 
            this.eMPLEADOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fECHADEINGRESOToolStripMenuItem,
            this.areaToolStripMenuItem});
            this.eMPLEADOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMPLEADOToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.eMPLEADOToolStripMenuItem.Name = "eMPLEADOToolStripMenuItem";
            this.eMPLEADOToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.eMPLEADOToolStripMenuItem.Text = "EMPLEADO";
            this.eMPLEADOToolStripMenuItem.Click += new System.EventHandler(this.EMPLEADOToolStripMenuItem_Click);
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.areaToolStripMenuItem.Text = "AREA";
            this.areaToolStripMenuItem.Click += new System.EventHandler(this.AreaToolStripMenuItem_Click);
            // 
            // fECHADEINGRESOToolStripMenuItem
            // 
            this.fECHADEINGRESOToolStripMenuItem.Name = "fECHADEINGRESOToolStripMenuItem";
            this.fECHADEINGRESOToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.fECHADEINGRESOToolStripMenuItem.Text = "FECHA DE INGRESO";
            // 
            // panelPadre
            // 
            this.panelPadre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPadre.Location = new System.Drawing.Point(0, 29);
            this.panelPadre.Name = "panelPadre";
            this.panelPadre.Size = new System.Drawing.Size(613, 272);
            this.panelPadre.TabIndex = 1;
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 301);
            this.Controls.Add(this.panelPadre);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmConsultas";
            this.Text = "frmConsultas";
            this.Load += new System.EventHandler(this.FrmConsultas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despachoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROVEEDORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPLEADOToolStripMenuItem;
        private System.Windows.Forms.Panel panelPadre;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTOCKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fechaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fECHADEINGRESOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dETALLEDECOMPRAToolStripMenuItem;
    }
}