namespace Capa_Vista.frmOperaciones
{
    partial class frmOperaPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperaPedidos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTipoOperacion = new System.Windows.Forms.ComboBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtrucProv = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboIdProveedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboIdEmp = new System.Windows.Forms.ComboBox();
            this.txtFecPed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodPed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTipoExistencia = new System.Windows.Forms.TextBox();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtStockMaximo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.Monto = new System.Windows.Forms.Label();
            this.mudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgDetalle = new System.Windows.Forms.DataGrid();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.btnRegistrarPedido = new System.Windows.Forms.Button();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.btnImprimirPedido = new System.Windows.Forms.Button();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnidadesPedido = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerarDocumento = new System.Windows.Forms.Button();
            this.dgpedidos = new System.Windows.Forms.DataGrid();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotalIGV = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtMontoNeto = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgpedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.cboTipoOperacion);
            this.groupBox1.Controls.Add(this.cboTipoDocumento);
            this.groupBox1.Controls.Add(this.txtrucProv);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboIdProveedor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboIdEmp);
            this.groupBox1.Controls.Add(this.txtFecPed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodPed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1220, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL PEDIDO";
            // 
            // cboTipoOperacion
            // 
            this.cboTipoOperacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboTipoOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoOperacion.FormattingEnabled = true;
            this.cboTipoOperacion.Location = new System.Drawing.Point(819, 41);
            this.cboTipoOperacion.Name = "cboTipoOperacion";
            this.cboTipoOperacion.Size = new System.Drawing.Size(224, 21);
            this.cboTipoOperacion.TabIndex = 13;
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(640, 41);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(173, 21);
            this.cboTipoDocumento.TabIndex = 12;
            // 
            // txtrucProv
            // 
            this.txtrucProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtrucProv.Enabled = false;
            this.txtrucProv.Location = new System.Drawing.Point(551, 42);
            this.txtrucProv.Name = "txtrucProv";
            this.txtrucProv.Size = new System.Drawing.Size(83, 20);
            this.txtrucProv.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(548, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "RUC";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(816, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Tipo de  operacion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(637, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tipo de  documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Proveedor";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // cboIdProveedor
            // 
            this.cboIdProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboIdProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdProveedor.FormattingEnabled = true;
            this.cboIdProveedor.Location = new System.Drawing.Point(411, 41);
            this.cboIdProveedor.Name = "cboIdProveedor";
            this.cboIdProveedor.Size = new System.Drawing.Size(134, 21);
            this.cboIdProveedor.TabIndex = 6;
            this.cboIdProveedor.SelectedIndexChanged += new System.EventHandler(this.CboIdProveedor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Empleado";
            // 
            // cboIdEmp
            // 
            this.cboIdEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboIdEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdEmp.FormattingEnabled = true;
            this.cboIdEmp.Location = new System.Drawing.Point(255, 41);
            this.cboIdEmp.Name = "cboIdEmp";
            this.cboIdEmp.Size = new System.Drawing.Size(146, 21);
            this.cboIdEmp.TabIndex = 4;
            // 
            // txtFecPed
            // 
            this.txtFecPed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFecPed.Location = new System.Drawing.Point(123, 42);
            this.txtFecPed.Name = "txtFecPed";
            this.txtFecPed.ReadOnly = true;
            this.txtFecPed.Size = new System.Drawing.Size(126, 20);
            this.txtFecPed.TabIndex = 3;
            this.txtFecPed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de pedido";
            // 
            // txtCodPed
            // 
            this.txtCodPed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCodPed.Location = new System.Drawing.Point(9, 42);
            this.txtCodPed.Name = "txtCodPed";
            this.txtCodPed.Size = new System.Drawing.Size(108, 20);
            this.txtCodPed.TabIndex = 1;
            this.txtCodPed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Pedido";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.txtMontoNeto);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.txtIGV);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.txtTipoExistencia);
            this.groupBox3.Controls.Add(this.txtUnidadMedida);
            this.groupBox3.Controls.Add(this.txtNombreProducto);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtStockMaximo);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.txtCodigoProducto);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtPrecioTotal);
            this.groupBox3.Controls.Add(this.Monto);
            this.groupBox3.Controls.Add(this.mudCantidad);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtStockActual);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1220, 83);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DETALLE DEL PEDIDO";
            // 
            // txtTipoExistencia
            // 
            this.txtTipoExistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTipoExistencia.Location = new System.Drawing.Point(1082, 42);
            this.txtTipoExistencia.Name = "txtTipoExistencia";
            this.txtTipoExistencia.Size = new System.Drawing.Size(131, 20);
            this.txtTipoExistencia.TabIndex = 31;
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUnidadMedida.Location = new System.Drawing.Point(962, 42);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(114, 20);
            this.txtUnidadMedida.TabIndex = 30;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProducto.Location = new System.Drawing.Point(178, 42);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(144, 20);
            this.txtNombreProducto.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Producto";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(642, 44);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 16);
            this.label21.TabIndex = 27;
            this.label21.Text = "S/.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(547, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 16);
            this.label20.TabIndex = 26;
            this.label20.Text = "S/.";
            // 
            // txtStockMaximo
            // 
            this.txtStockMaximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStockMaximo.Enabled = false;
            this.txtStockMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockMaximo.Location = new System.Drawing.Point(331, 41);
            this.txtStockMaximo.Name = "txtStockMaximo";
            this.txtStockMaximo.Size = new System.Drawing.Size(70, 20);
            this.txtStockMaximo.TabIndex = 25;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(328, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "Stock maximo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCodigoProducto.Location = new System.Drawing.Point(79, 41);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(93, 20);
            this.txtCodigoProducto.TabIndex = 22;
            this.txtCodigoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigoProducto.TextChanged += new System.EventHandler(this.TxtCodigoProducto_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(76, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Codigo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1078, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Tipo de Existencia";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(959, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Unidad de medida";
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPrecioTotal.Enabled = false;
            this.txtPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioTotal.Location = new System.Drawing.Point(640, 43);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.Size = new System.Drawing.Size(113, 20);
            this.txtPrecioTotal.TabIndex = 9;
            this.txtPrecioTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Monto
            // 
            this.Monto.AutoSize = true;
            this.Monto.Location = new System.Drawing.Point(637, 26);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(60, 13);
            this.Monto.TabIndex = 8;
            this.Monto.Text = "Precio total";
            // 
            // mudCantidad
            // 
            this.mudCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mudCantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mudCantidad.Location = new System.Drawing.Point(483, 43);
            this.mudCantidad.Name = "mudCantidad";
            this.mudCantidad.Size = new System.Drawing.Size(55, 20);
            this.mudCantidad.TabIndex = 7;
            this.mudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mudCantidad.ValueChanged += new System.EventHandler(this.MudCantidad_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(480, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(544, 43);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(90, 20);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(541, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Precio";
            // 
            // txtStockActual
            // 
            this.txtStockActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStockActual.Enabled = false;
            this.txtStockActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockActual.Location = new System.Drawing.Point(407, 42);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.Size = new System.Drawing.Size(70, 20);
            this.txtStockActual.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Stock actual";
            // 
            // dgDetalle
            // 
            this.dgDetalle.AllowSorting = false;
            this.dgDetalle.AlternatingBackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDetalle.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgDetalle.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgDetalle.CaptionForeColor = System.Drawing.Color.White;
            this.dgDetalle.CaptionText = "DETALLE DE PEDIDO";
            this.dgDetalle.DataMember = "";
            this.dgDetalle.FlatMode = true;
            this.dgDetalle.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgDetalle.Location = new System.Drawing.Point(10, 352);
            this.dgDetalle.Name = "dgDetalle";
            this.dgDetalle.PreferredColumnWidth = 120;
            this.dgDetalle.ReadOnly = true;
            this.dgDetalle.RowHeaderWidth = 50;
            this.dgDetalle.Size = new System.Drawing.Size(1222, 185);
            this.dgDetalle.TabIndex = 3;
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarDetalle.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAgregarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDetalle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarDetalle.Image")));
            this.btnAgregarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDetalle.Location = new System.Drawing.Point(1251, 65);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(112, 47);
            this.btnAgregarDetalle.TabIndex = 4;
            this.btnAgregarDetalle.Text = "Agregar detalle";
            this.btnAgregarDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarDetalle.UseVisualStyleBackColor = false;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.BtnAgregarDetalle_Click);
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
            this.btnEliminarDetalle.Location = new System.Drawing.Point(1251, 168);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(112, 47);
            this.btnEliminarDetalle.TabIndex = 5;
            this.btnEliminarDetalle.Text = "Eliminar detalle";
            this.btnEliminarDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnEliminarDetalle, "Primero seleccione un registro en DETALLE  DE PEDIDO");
            this.btnEliminarDetalle.UseVisualStyleBackColor = false;
            this.btnEliminarDetalle.Click += new System.EventHandler(this.BtnEliminarDetalle_Click);
            // 
            // btnRegistrarPedido
            // 
            this.btnRegistrarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarPedido.BackColor = System.Drawing.Color.Chartreuse;
            this.btnRegistrarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarPedido.Image")));
            this.btnRegistrarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarPedido.Location = new System.Drawing.Point(1251, 118);
            this.btnRegistrarPedido.Name = "btnRegistrarPedido";
            this.btnRegistrarPedido.Size = new System.Drawing.Size(112, 47);
            this.btnRegistrarPedido.TabIndex = 6;
            this.btnRegistrarPedido.Text = "Registrar pedido";
            this.btnRegistrarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarPedido.UseVisualStyleBackColor = false;
            this.btnRegistrarPedido.Click += new System.EventHandler(this.BtnRegistrarPedido_Click);
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoPedido.BackColor = System.Drawing.Color.Chartreuse;
            this.btnNuevoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoPedido.Image")));
            this.btnNuevoPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoPedido.Location = new System.Drawing.Point(1251, 12);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(112, 47);
            this.btnNuevoPedido.TabIndex = 7;
            this.btnNuevoPedido.Text = "Nuevo pedido";
            this.btnNuevoPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoPedido.UseVisualStyleBackColor = false;
            this.btnNuevoPedido.Click += new System.EventHandler(this.BtnNuevoPedido_Click);
            // 
            // btnImprimirPedido
            // 
            this.btnImprimirPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirPedido.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnImprimirPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirPedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirPedido.ForeColor = System.Drawing.Color.White;
            this.btnImprimirPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirPedido.Image")));
            this.btnImprimirPedido.Location = new System.Drawing.Point(1251, 541);
            this.btnImprimirPedido.Name = "btnImprimirPedido";
            this.btnImprimirPedido.Size = new System.Drawing.Size(112, 47);
            this.btnImprimirPedido.TabIndex = 8;
            this.btnImprimirPedido.Text = "Imprimir pedido";
            this.btnImprimirPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimirPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirPedido.UseVisualStyleBackColor = false;
            this.btnImprimirPedido.Click += new System.EventHandler(this.BtnImprimirPedido_Click);
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMontoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMontoTotal.Enabled = false;
            this.txtMontoTotal.Location = new System.Drawing.Point(810, 568);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtMontoTotal.TabIndex = 9;
            this.txtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1019, 552);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total monto neto";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1129, 549);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Unidades en pedido";
            // 
            // txtUnidadesPedido
            // 
            this.txtUnidadesPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnidadesPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUnidadesPedido.Enabled = false;
            this.txtUnidadesPedido.Location = new System.Drawing.Point(1132, 568);
            this.txtUnidadesPedido.Name = "txtUnidadesPedido";
            this.txtUnidadesPedido.Size = new System.Drawing.Size(100, 20);
            this.txtUnidadesPedido.TabIndex = 11;
            this.txtUnidadesPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(12, 543);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 47);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnGenerarDocumento
            // 
            this.btnGenerarDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerarDocumento.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGenerarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarDocumento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarDocumento.ForeColor = System.Drawing.Color.White;
            this.btnGenerarDocumento.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarDocumento.Image")));
            this.btnGenerarDocumento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarDocumento.Location = new System.Drawing.Point(146, 543);
            this.btnGenerarDocumento.Name = "btnGenerarDocumento";
            this.btnGenerarDocumento.Size = new System.Drawing.Size(136, 47);
            this.btnGenerarDocumento.TabIndex = 14;
            this.btnGenerarDocumento.Text = "Generar documento";
            this.btnGenerarDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarDocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarDocumento.UseVisualStyleBackColor = false;
            // 
            // dgpedidos
            // 
            this.dgpedidos.AllowSorting = false;
            this.dgpedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgpedidos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgpedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgpedidos.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgpedidos.CaptionForeColor = System.Drawing.Color.White;
            this.dgpedidos.CaptionText = "PEDIDOS";
            this.dgpedidos.DataMember = "";
            this.dgpedidos.FlatMode = true;
            this.dgpedidos.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgpedidos.Location = new System.Drawing.Point(12, 101);
            this.dgpedidos.Name = "dgpedidos";
            this.dgpedidos.PreferredColumnWidth = 120;
            this.dgpedidos.ReadOnly = true;
            this.dgpedidos.RowHeaderWidth = 50;
            this.dgpedidos.Size = new System.Drawing.Size(1220, 156);
            this.dgpedidos.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(913, 552);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Total I.G.V";
            // 
            // txtTotalIGV
            // 
            this.txtTotalIGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalIGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalIGV.Enabled = false;
            this.txtTotalIGV.Location = new System.Drawing.Point(916, 568);
            this.txtTotalIGV.Name = "txtTotalIGV";
            this.txtTotalIGV.Size = new System.Drawing.Size(100, 20);
            this.txtTotalIGV.TabIndex = 17;
            this.txtTotalIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(673, 566);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 19);
            this.label17.TabIndex = 19;
            this.label17.Text = "I.G.V    18%";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.Info;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1251, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 47);
            this.button1.TabIndex = 20;
            this.button1.Text = "Eliminar pedido";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(1022, 568);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(807, 549);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 13);
            this.label22.TabIndex = 22;
            this.label22.Text = "Monto Total";
            // 
            // txtIGV
            // 
            this.txtIGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIGV.Enabled = false;
            this.txtIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGV.Location = new System.Drawing.Point(759, 44);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(89, 20);
            this.txtIGV.TabIndex = 33;
            this.txtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(756, 27);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 13);
            this.label23.TabIndex = 32;
            this.label23.Text = "I.G.V";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(857, 45);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(24, 16);
            this.label24.TabIndex = 36;
            this.label24.Text = "S/.";
            // 
            // txtMontoNeto
            // 
            this.txtMontoNeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMontoNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoNeto.Location = new System.Drawing.Point(854, 44);
            this.txtMontoNeto.Name = "txtMontoNeto";
            this.txtMontoNeto.ReadOnly = true;
            this.txtMontoNeto.Size = new System.Drawing.Size(102, 20);
            this.txtMontoNeto.TabIndex = 35;
            this.txtMontoNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(851, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 34;
            this.label25.Text = "Monto Neto";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(759, 46);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(24, 16);
            this.label26.TabIndex = 37;
            this.label26.Text = "S/.";
            // 
            // frmOperaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(1375, 602);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtTotalIGV);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dgpedidos);
            this.Controls.Add(this.btnGenerarDocumento);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUnidadesPedido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.btnImprimirPedido);
            this.Controls.Add(this.btnNuevoPedido);
            this.Controls.Add(this.btnRegistrarPedido);
            this.Controls.Add(this.btnEliminarDetalle);
            this.Controls.Add(this.btnAgregarDetalle);
            this.Controls.Add(this.dgDetalle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOperaPedidos";
            this.Text = "frmOperaPedidos";
            this.Load += new System.EventHandler(this.FrmOperaPedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgpedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboIdProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboIdEmp;
        private System.Windows.Forms.TextBox txtFecPed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodPed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGrid dgDetalle;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.Button btnEliminarDetalle;
        private System.Windows.Forms.Button btnRegistrarPedido;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Button btnImprimirPedido;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnidadesPedido;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerarDocumento;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.Label Monto;
        private System.Windows.Forms.NumericUpDown mudCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGrid dgpedidos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboTipoOperacion;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.TextBox txtrucProv;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTotalIGV;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStockMaximo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTipoExistencia;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtMontoNeto;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.Label label23;
    }
}