namespace Capa_Vista
{
    partial class frmOperaDespachos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperaDespachos));
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodDespacho = new System.Windows.Forms.TextBox();
            this.txtFechaDespacho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboIdEmp = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTipoExistencia = new System.Windows.Forms.TextBox();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.Monto = new System.Windows.Forms.Label();
            this.mudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cboTipoOperacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnElimnarDespacho = new System.Windows.Forms.Button();
            this.btnNuevoDespacho = new System.Windows.Forms.Button();
            this.btnRegistrarDespacho = new System.Windows.Forms.Button();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.txtTotalIGV = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnGenerarDocumento = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUnidadesPedido = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.btnImprimirDespacho = new System.Windows.Forms.Button();
            this.dgDespachos = new System.Windows.Forms.DataGrid();
            this.dgDetalleDespachos = new System.Windows.Forms.DataGrid();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtMontoNeto = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mudCantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDespachos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleDespachos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de despacho";
            // 
            // txtcodDespacho
            // 
            this.txtcodDespacho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtcodDespacho.Location = new System.Drawing.Point(15, 41);
            this.txtcodDespacho.Name = "txtcodDespacho";
            this.txtcodDespacho.Size = new System.Drawing.Size(131, 20);
            this.txtcodDespacho.TabIndex = 1;
            // 
            // txtFechaDespacho
            // 
            this.txtFechaDespacho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFechaDespacho.Enabled = false;
            this.txtFechaDespacho.Location = new System.Drawing.Point(154, 42);
            this.txtFechaDespacho.Name = "txtFechaDespacho";
            this.txtFechaDespacho.Size = new System.Drawing.Size(99, 20);
            this.txtFechaDespacho.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de despacho";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Empleado";
            // 
            // cboIdEmp
            // 
            this.cboIdEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdEmp.FormattingEnabled = true;
            this.cboIdEmp.Location = new System.Drawing.Point(293, 40);
            this.cboIdEmp.Name = "cboIdEmp";
            this.cboIdEmp.Size = new System.Drawing.Size(152, 21);
            this.cboIdEmp.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtMontoNeto);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txtIGV);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtStockMin);
            this.groupBox1.Controls.Add(this.txtNombreProducto);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtUnidadMedida);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTipoExistencia);
            this.groupBox1.Controls.Add(this.txtPrecioTotal);
            this.groupBox1.Controls.Add(this.Monto);
            this.groupBox1.Controls.Add(this.mudCantidad);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCodigoProducto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 83);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(292, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Stock minimo";
            // 
            // txtStockMin
            // 
            this.txtStockMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStockMin.Enabled = false;
            this.txtStockMin.Location = new System.Drawing.Point(293, 57);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(67, 20);
            this.txtStockMin.TabIndex = 22;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProducto.Location = new System.Drawing.Point(93, 57);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(144, 20);
            this.txtNombreProducto.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(293, 24);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(67, 20);
            this.txtStock.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(290, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Stock Actual";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(612, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Unidad de medida";
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUnidadMedida.Location = new System.Drawing.Point(615, 19);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.ReadOnly = true;
            this.txtUnidadMedida.Size = new System.Drawing.Size(100, 20);
            this.txtUnidadMedida.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(506, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tipo  de Existencia";
            // 
            // txtTipoExistencia
            // 
            this.txtTipoExistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTipoExistencia.Location = new System.Drawing.Point(509, 20);
            this.txtTipoExistencia.Name = "txtTipoExistencia";
            this.txtTipoExistencia.ReadOnly = true;
            this.txtTipoExistencia.Size = new System.Drawing.Size(100, 20);
            this.txtTipoExistencia.TabIndex = 14;
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPrecioTotal.Enabled = false;
            this.txtPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioTotal.Location = new System.Drawing.Point(509, 57);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.Size = new System.Drawing.Size(84, 20);
            this.txtPrecioTotal.TabIndex = 13;
            // 
            // Monto
            // 
            this.Monto.AutoSize = true;
            this.Monto.Location = new System.Drawing.Point(506, 40);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(60, 13);
            this.Monto.TabIndex = 12;
            this.Monto.Text = "Precio total";
            // 
            // mudCantidad
            // 
            this.mudCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mudCantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mudCantidad.Location = new System.Drawing.Point(401, 24);
            this.mudCantidad.Name = "mudCantidad";
            this.mudCantidad.ReadOnly = true;
            this.mudCantidad.Size = new System.Drawing.Size(55, 20);
            this.mudCantidad.TabIndex = 11;
            this.mudCantidad.ValueChanged += new System.EventHandler(this.MudCantidad_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(398, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPrecio.Location = new System.Drawing.Point(401, 57);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Precio";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCodigoProducto.Location = new System.Drawing.Point(93, 19);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(144, 20);
            this.txtCodigoProducto.TabIndex = 3;
            this.txtCodigoProducto.TextChanged += new System.EventHandler(this.TxtCodigoProducto_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Codigo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Producto";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.cboTipoOperacion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboTipoDocumento);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboIdEmp);
            this.groupBox2.Controls.Add(this.txtcodDespacho);
            this.groupBox2.Controls.Add(this.txtFechaDespacho);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(958, 84);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DESPACHO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(259, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // cboTipoOperacion
            // 
            this.cboTipoOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoOperacion.FormattingEnabled = true;
            this.cboTipoOperacion.Location = new System.Drawing.Point(609, 42);
            this.cboTipoOperacion.Name = "cboTipoOperacion";
            this.cboTipoOperacion.Size = new System.Drawing.Size(152, 21);
            this.cboTipoOperacion.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tipo de Operacion";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(451, 41);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(152, 21);
            this.cboTipoDocumento.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo de documento";
            // 
            // btnElimnarDespacho
            // 
            this.btnElimnarDespacho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElimnarDespacho.BackColor = System.Drawing.Color.Red;
            this.btnElimnarDespacho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimnarDespacho.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimnarDespacho.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnElimnarDespacho.Image = ((System.Drawing.Image)(resources.GetObject("btnElimnarDespacho.Image")));
            this.btnElimnarDespacho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElimnarDespacho.Location = new System.Drawing.Point(1013, 221);
            this.btnElimnarDespacho.Name = "btnElimnarDespacho";
            this.btnElimnarDespacho.Size = new System.Drawing.Size(112, 47);
            this.btnElimnarDespacho.TabIndex = 23;
            this.btnElimnarDespacho.Text = "Eliminar despacho";
            this.btnElimnarDespacho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnElimnarDespacho, "Primero seleccione un registro en DESPACHO");
            this.btnElimnarDespacho.UseVisualStyleBackColor = false;
            // 
            // btnNuevoDespacho
            // 
            this.btnNuevoDespacho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoDespacho.BackColor = System.Drawing.Color.Chartreuse;
            this.btnNuevoDespacho.FlatAppearance.BorderSize = 0;
            this.btnNuevoDespacho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoDespacho.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDespacho.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoDespacho.Image")));
            this.btnNuevoDespacho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoDespacho.Location = new System.Drawing.Point(1013, 118);
            this.btnNuevoDespacho.Name = "btnNuevoDespacho";
            this.btnNuevoDespacho.Size = new System.Drawing.Size(112, 47);
            this.btnNuevoDespacho.TabIndex = 22;
            this.btnNuevoDespacho.Text = "Nuevo despacho";
            this.btnNuevoDespacho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoDespacho.UseVisualStyleBackColor = false;
            this.btnNuevoDespacho.Click += new System.EventHandler(this.BtnNuevoDespacho_Click);
            // 
            // btnRegistrarDespacho
            // 
            this.btnRegistrarDespacho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarDespacho.BackColor = System.Drawing.Color.Chartreuse;
            this.btnRegistrarDespacho.FlatAppearance.BorderSize = 0;
            this.btnRegistrarDespacho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarDespacho.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarDespacho.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarDespacho.Image")));
            this.btnRegistrarDespacho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarDespacho.Location = new System.Drawing.Point(1013, 65);
            this.btnRegistrarDespacho.Name = "btnRegistrarDespacho";
            this.btnRegistrarDespacho.Size = new System.Drawing.Size(112, 47);
            this.btnRegistrarDespacho.TabIndex = 21;
            this.btnRegistrarDespacho.Text = "Registrar despacho";
            this.btnRegistrarDespacho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarDespacho.UseVisualStyleBackColor = false;
            this.btnRegistrarDespacho.Click += new System.EventHandler(this.BtnRegistrarDespacho_Click);
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.AccessibleDescription = "";
            this.btnEliminarDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarDetalle.BackColor = System.Drawing.Color.Red;
            this.btnEliminarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDetalle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDetalle.ForeColor = System.Drawing.Color.White;
            this.btnEliminarDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarDetalle.Image")));
            this.btnEliminarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarDetalle.Location = new System.Drawing.Point(1013, 168);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(112, 47);
            this.btnEliminarDetalle.TabIndex = 20;
            this.btnEliminarDetalle.Text = "Eliminar detalle";
            this.btnEliminarDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarDetalle.UseVisualStyleBackColor = false;
            this.btnEliminarDetalle.Click += new System.EventHandler(this.BtnEliminarDetalle_Click);
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarDetalle.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAgregarDetalle.FlatAppearance.BorderSize = 0;
            this.btnAgregarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDetalle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarDetalle.Image")));
            this.btnAgregarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDetalle.Location = new System.Drawing.Point(1013, 12);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(112, 47);
            this.btnAgregarDetalle.TabIndex = 19;
            this.btnAgregarDetalle.Text = "Agregar detalle";
            this.btnAgregarDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarDetalle.UseVisualStyleBackColor = false;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.BtnAgregarDetalle_Click);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(445, 558);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 21);
            this.label17.TabIndex = 33;
            this.label17.Text = "I.G.V    18%";
            // 
            // txtTotalIGV
            // 
            this.txtTotalIGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalIGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalIGV.Enabled = false;
            this.txtTotalIGV.Location = new System.Drawing.Point(654, 559);
            this.txtTotalIGV.Name = "txtTotalIGV";
            this.txtTotalIGV.Size = new System.Drawing.Size(100, 20);
            this.txtTotalIGV.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(651, 540);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Total I.G.V";
            // 
            // btnGenerarDocumento
            // 
            this.btnGenerarDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerarDocumento.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGenerarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarDocumento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarDocumento.ForeColor = System.Drawing.Color.White;
            this.btnGenerarDocumento.Location = new System.Drawing.Point(114, 541);
            this.btnGenerarDocumento.Name = "btnGenerarDocumento";
            this.btnGenerarDocumento.Size = new System.Drawing.Size(96, 47);
            this.btnGenerarDocumento.TabIndex = 30;
            this.btnGenerarDocumento.Text = "Generar documento";
            this.btnGenerarDocumento.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(12, 541);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 47);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(867, 540);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Unidades en pedido";
            // 
            // txtUnidadesPedido
            // 
            this.txtUnidadesPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnidadesPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUnidadesPedido.Enabled = false;
            this.txtUnidadesPedido.Location = new System.Drawing.Point(870, 559);
            this.txtUnidadesPedido.Name = "txtUnidadesPedido";
            this.txtUnidadesPedido.Size = new System.Drawing.Size(100, 20);
            this.txtUnidadesPedido.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(543, 540);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Monto total";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMontoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMontoTotal.Enabled = false;
            this.txtMontoTotal.Location = new System.Drawing.Point(546, 559);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtMontoTotal.TabIndex = 25;
            // 
            // btnImprimirDespacho
            // 
            this.btnImprimirDespacho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirDespacho.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnImprimirDespacho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirDespacho.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirDespacho.ForeColor = System.Drawing.Color.White;
            this.btnImprimirDespacho.Location = new System.Drawing.Point(1013, 532);
            this.btnImprimirDespacho.Name = "btnImprimirDespacho";
            this.btnImprimirDespacho.Size = new System.Drawing.Size(112, 47);
            this.btnImprimirDespacho.TabIndex = 24;
            this.btnImprimirDespacho.Text = "Imprimir despacho";
            this.btnImprimirDespacho.UseVisualStyleBackColor = false;
            this.btnImprimirDespacho.Click += new System.EventHandler(this.BtnImprimirDespacho_Click);
            // 
            // dgDespachos
            // 
            this.dgDespachos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDespachos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgDespachos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgDespachos.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgDespachos.CaptionForeColor = System.Drawing.Color.White;
            this.dgDespachos.CaptionText = "DESPACHOS";
            this.dgDespachos.DataMember = "";
            this.dgDespachos.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgDespachos.Location = new System.Drawing.Point(12, 101);
            this.dgDespachos.Name = "dgDespachos";
            this.dgDespachos.PreferredColumnWidth = 120;
            this.dgDespachos.RowHeaderWidth = 50;
            this.dgDespachos.Size = new System.Drawing.Size(958, 157);
            this.dgDespachos.TabIndex = 34;
            // 
            // dgDetalleDespachos
            // 
            this.dgDetalleDespachos.AlternatingBackColor = System.Drawing.SystemColors.Control;
            this.dgDetalleDespachos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDetalleDespachos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgDetalleDespachos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgDetalleDespachos.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgDetalleDespachos.CaptionForeColor = System.Drawing.Color.White;
            this.dgDetalleDespachos.CaptionText = "DETALLE DE DESPACHO";
            this.dgDetalleDespachos.DataMember = "";
            this.dgDetalleDespachos.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgDetalleDespachos.Location = new System.Drawing.Point(12, 352);
            this.dgDetalleDespachos.Name = "dgDetalleDespachos";
            this.dgDetalleDespachos.PreferredColumnWidth = 120;
            this.dgDetalleDespachos.RowHeaderWidth = 50;
            this.dgDetalleDespachos.Size = new System.Drawing.Size(958, 185);
            this.dgDetalleDespachos.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(759, 540);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Monto neto";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(762, 559);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 36;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(608, 59);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(24, 16);
            this.label26.TabIndex = 43;
            this.label26.Text = "S/.";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(706, 58);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(24, 16);
            this.label24.TabIndex = 42;
            this.label24.Text = "S/.";
            // 
            // txtMontoNeto
            // 
            this.txtMontoNeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMontoNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoNeto.Location = new System.Drawing.Point(703, 57);
            this.txtMontoNeto.Name = "txtMontoNeto";
            this.txtMontoNeto.ReadOnly = true;
            this.txtMontoNeto.Size = new System.Drawing.Size(102, 20);
            this.txtMontoNeto.TabIndex = 41;
            this.txtMontoNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(700, 40);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 40;
            this.label25.Text = "Monto Neto";
            // 
            // txtIGV
            // 
            this.txtIGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIGV.Enabled = false;
            this.txtIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGV.Location = new System.Drawing.Point(608, 57);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(89, 20);
            this.txtIGV.TabIndex = 39;
            this.txtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(605, 40);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 13);
            this.label23.TabIndex = 38;
            this.label23.Text = "I.G.V";
            // 
            // frmOperaDespachos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1137, 591);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgDetalleDespachos);
            this.Controls.Add(this.dgDespachos);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtTotalIGV);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnGenerarDocumento);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtUnidadesPedido);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.btnImprimirDespacho);
            this.Controls.Add(this.btnElimnarDespacho);
            this.Controls.Add(this.btnNuevoDespacho);
            this.Controls.Add(this.btnRegistrarDespacho);
            this.Controls.Add(this.btnEliminarDetalle);
            this.Controls.Add(this.btnAgregarDetalle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOperaDespachos";
            this.Text = "frmOperaDespachos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mudCantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDespachos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleDespachos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtcodDespacho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboIdEmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFechaDespacho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnElimnarDespacho;
        private System.Windows.Forms.Button btnNuevoDespacho;
        private System.Windows.Forms.Button btnRegistrarDespacho;
        private System.Windows.Forms.Button btnEliminarDetalle;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTipoExistencia;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.Label Monto;
        private System.Windows.Forms.NumericUpDown mudCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTotalIGV;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnGenerarDocumento;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUnidadesPedido;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Button btnImprimirDespacho;
        private System.Windows.Forms.ComboBox cboTipoOperacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGrid dgDespachos;
        private System.Windows.Forms.DataGrid dgDetalleDespachos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtStockMin;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtMontoNeto;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.Label label23;
    }
}