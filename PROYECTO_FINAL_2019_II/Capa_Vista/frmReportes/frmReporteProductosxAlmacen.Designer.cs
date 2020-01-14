namespace Capa_Vista
{
    partial class frmReporteProductosxAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteProductosxAlmacen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCrearReporte = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboAlmacen = new System.Windows.Forms.ComboBox();
            this.btnBuscarAreas = new System.Windows.Forms.Button();
            this.crvProductoxAlmacen = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCrearReporte);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 84);
            this.panel1.TabIndex = 5;
            // 
            // btnCrearReporte
            // 
            this.btnCrearReporte.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCrearReporte.BackColor = System.Drawing.Color.Chartreuse;
            this.btnCrearReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearReporte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearReporte.Image")));
            this.btnCrearReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearReporte.Location = new System.Drawing.Point(513, 11);
            this.btnCrearReporte.Name = "btnCrearReporte";
            this.btnCrearReporte.Size = new System.Drawing.Size(147, 47);
            this.btnCrearReporte.TabIndex = 2;
            this.btnCrearReporte.Text = "Crear Reporte";
            this.btnCrearReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearReporte.UseVisualStyleBackColor = false;
            this.btnCrearReporte.Click += new System.EventHandler(this.BtnCrearReporte_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.cboAlmacen);
            this.groupBox1.Controls.Add(this.btnBuscarAreas);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 47);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECCIONE ALMACEN";
            // 
            // cboAlmacen
            // 
            this.cboAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlmacen.FormattingEnabled = true;
            this.cboAlmacen.Location = new System.Drawing.Point(6, 19);
            this.cboAlmacen.Name = "cboAlmacen";
            this.cboAlmacen.Size = new System.Drawing.Size(203, 21);
            this.cboAlmacen.TabIndex = 3;
            // 
            // btnBuscarAreas
            // 
            this.btnBuscarAreas.AutoSize = true;
            this.btnBuscarAreas.BackColor = System.Drawing.Color.Chartreuse;
            this.btnBuscarAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAreas.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarAreas.Image")));
            this.btnBuscarAreas.Location = new System.Drawing.Point(215, 3);
            this.btnBuscarAreas.Name = "btnBuscarAreas";
            this.btnBuscarAreas.Size = new System.Drawing.Size(40, 40);
            this.btnBuscarAreas.TabIndex = 3;
            this.btnBuscarAreas.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBuscarAreas.UseVisualStyleBackColor = false;
            // 
            // crvProductoxAlmacen
            // 
            this.crvProductoxAlmacen.ActiveViewIndex = -1;
            this.crvProductoxAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvProductoxAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProductoxAlmacen.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvProductoxAlmacen.Location = new System.Drawing.Point(0, 84);
            this.crvProductoxAlmacen.Name = "crvProductoxAlmacen";
            this.crvProductoxAlmacen.Size = new System.Drawing.Size(673, 302);
            this.crvProductoxAlmacen.TabIndex = 4;
            this.crvProductoxAlmacen.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvProductoxAlmacen.ToolPanelWidth = 100;
            // 
            // frmReporteProductosxAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(673, 386);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crvProductoxAlmacen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteProductosxAlmacen";
            this.Text = "frmReporteProductosxAlmacen";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCrearReporte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboAlmacen;
        private System.Windows.Forms.Button btnBuscarAreas;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProductoxAlmacen;
    }
}