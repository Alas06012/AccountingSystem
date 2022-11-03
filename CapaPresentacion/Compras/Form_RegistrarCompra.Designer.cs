
namespace CapaPresentacion.Compras
{
    partial class Form_RegistrarCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RegistrarCompra));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdiasCredito = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_BuscarProveedor = new System.Windows.Forms.PictureBox();
            this.txtFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.gridDetalleProducto = new System.Windows.Forms.DataGridView();
            this.ProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_BuscarProducto = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RadioBtn_no = new System.Windows.Forms.RadioButton();
            this.RadioBtn_Si = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Radiobtn_factura = new System.Windows.Forms.RadioButton();
            this.RadioBtn_creditoFiscal = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gridTotales = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiasCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_BuscarProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleProducto)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_BuscarProducto)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTotales)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdiasCredito);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_BuscarProveedor);
            this.groupBox1.Controls.Add(this.txtFechaFactura);
            this.groupBox1.Controls.Add(this.lblClasificacion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNumFactura);
            this.groupBox1.Controls.Add(this.txtNombreProveedor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(366, 352);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedor / Compra";
            // 
            // txtdiasCredito
            // 
            this.txtdiasCredito.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiasCredito.Location = new System.Drawing.Point(118, 300);
            this.txtdiasCredito.Name = "txtdiasCredito";
            this.txtdiasCredito.Size = new System.Drawing.Size(107, 25);
            this.txtdiasCredito.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 281);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Días de Crédito:";
            // 
            // btn_BuscarProveedor
            // 
            this.btn_BuscarProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_BuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BuscarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscarProveedor.Image")));
            this.btn_BuscarProveedor.Location = new System.Drawing.Point(282, 44);
            this.btn_BuscarProveedor.Name = "btn_BuscarProveedor";
            this.btn_BuscarProveedor.Size = new System.Drawing.Size(36, 41);
            this.btn_BuscarProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_BuscarProveedor.TabIndex = 33;
            this.btn_BuscarProveedor.TabStop = false;
            this.btn_BuscarProveedor.Click += new System.EventHandler(this.btn_BuscarProveedor_Click);
            // 
            // txtFechaFactura
            // 
            this.txtFechaFactura.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtFechaFactura.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaFactura.Location = new System.Drawing.Point(82, 160);
            this.txtFechaFactura.Name = "txtFechaFactura";
            this.txtFechaFactura.Size = new System.Drawing.Size(195, 25);
            this.txtFechaFactura.TabIndex = 31;
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasificacion.Location = new System.Drawing.Point(183, 87);
            this.lblClasificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(91, 20);
            this.lblClasificacion.TabIndex = 7;
            this.lblClasificacion.Text = "Clasificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Clasificación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha de Factura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Número de Factura:";
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFactura.Location = new System.Drawing.Point(82, 237);
            this.txtNumFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(195, 25);
            this.txtNumFactura.TabIndex = 6;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Enabled = false;
            this.txtNombreProveedor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProveedor.Location = new System.Drawing.Point(82, 55);
            this.txtNombreProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(193, 25);
            this.txtNombreProveedor.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Proveedor:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(791, 569);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 46);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Location = new System.Drawing.Point(791, 656);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(94, 46);
            this.btnQuitar.TabIndex = 22;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // gridDetalleProducto
            // 
            this.gridDetalleProducto.AllowUserToAddRows = false;
            this.gridDetalleProducto.AllowUserToDeleteRows = false;
            this.gridDetalleProducto.AllowUserToResizeRows = false;
            this.gridDetalleProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDetalleProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalleProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoID,
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.Precio,
            this.Subtotal});
            this.gridDetalleProducto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridDetalleProducto.Location = new System.Drawing.Point(447, 157);
            this.gridDetalleProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridDetalleProducto.MultiSelect = false;
            this.gridDetalleProducto.Name = "gridDetalleProducto";
            this.gridDetalleProducto.RowHeadersWidth = 51;
            this.gridDetalleProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetalleProducto.Size = new System.Drawing.Size(881, 324);
            this.gridDetalleProducto.TabIndex = 18;
            this.gridDetalleProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDetalleProducto_CellClick);
            // 
            // ProductoID
            // 
            this.ProductoID.HeaderText = "ProductoID";
            this.ProductoID.MinimumWidth = 6;
            this.ProductoID.Name = "ProductoID";
            this.ProductoID.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_BuscarProducto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtNombreProducto);
            this.groupBox2.Controls.Add(this.txtCant);
            this.groupBox2.Controls.Add(this.txtCodigoProducto);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(38, 489);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(364, 283);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto:";
            // 
            // btn_BuscarProducto
            // 
            this.btn_BuscarProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_BuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscarProducto.Image")));
            this.btn_BuscarProducto.Location = new System.Drawing.Point(280, 46);
            this.btn_BuscarProducto.Name = "btn_BuscarProducto";
            this.btn_BuscarProducto.Size = new System.Drawing.Size(36, 41);
            this.btn_BuscarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_BuscarProducto.TabIndex = 34;
            this.btn_BuscarProducto.TabStop = false;
            this.btn_BuscarProducto.Click += new System.EventHandler(this.btn_BuscarProducto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(98, 235);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(158, 25);
            this.txtPrecio.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(113, 94);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nombre de Producto:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(141, 156);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Cantidad:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Enabled = false;
            this.txtNombreProducto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(80, 116);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(195, 25);
            this.txtNombreProducto.TabIndex = 4;
            // 
            // txtCant
            // 
            this.txtCant.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCant.Location = new System.Drawing.Point(98, 178);
            this.txtCant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(158, 25);
            this.txtCant.TabIndex = 6;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Enabled = false;
            this.txtCodigoProducto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.Location = new System.Drawing.Point(80, 53);
            this.txtCodigoProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(193, 25);
            this.txtCodigoProducto.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(116, 31);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Código del Producto:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(1098, 101);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(94, 46);
            this.btn_guardar.TabIndex = 22;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(1217, 101);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(94, 46);
            this.btn_cerrar.TabIndex = 23;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RadioBtn_no);
            this.groupBox3.Controls.Add(this.RadioBtn_Si);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(449, 507);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(306, 119);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agente de Retención/Percepción";
            // 
            // RadioBtn_no
            // 
            this.RadioBtn_no.AutoSize = true;
            this.RadioBtn_no.Checked = true;
            this.RadioBtn_no.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBtn_no.Location = new System.Drawing.Point(161, 53);
            this.RadioBtn_no.Name = "RadioBtn_no";
            this.RadioBtn_no.Size = new System.Drawing.Size(51, 27);
            this.RadioBtn_no.TabIndex = 1;
            this.RadioBtn_no.TabStop = true;
            this.RadioBtn_no.Text = "No";
            this.RadioBtn_no.UseVisualStyleBackColor = true;
            this.RadioBtn_no.CheckedChanged += new System.EventHandler(this.RadioBtn_Si_CheckedChanged);
            // 
            // RadioBtn_Si
            // 
            this.RadioBtn_Si.AutoSize = true;
            this.RadioBtn_Si.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBtn_Si.Location = new System.Drawing.Point(46, 53);
            this.RadioBtn_Si.Name = "RadioBtn_Si";
            this.RadioBtn_Si.Size = new System.Drawing.Size(44, 27);
            this.RadioBtn_Si.TabIndex = 0;
            this.RadioBtn_Si.Text = "Si";
            this.RadioBtn_Si.UseVisualStyleBackColor = true;
            this.RadioBtn_Si.CheckedChanged += new System.EventHandler(this.RadioBtn_Si_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Radiobtn_factura);
            this.groupBox4.Controls.Add(this.RadioBtn_creditoFiscal);
            this.groupBox4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(449, 654);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(306, 119);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo de Documento ";
            // 
            // Radiobtn_factura
            // 
            this.Radiobtn_factura.AutoSize = true;
            this.Radiobtn_factura.Checked = true;
            this.Radiobtn_factura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Radiobtn_factura.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radiobtn_factura.Location = new System.Drawing.Point(185, 54);
            this.Radiobtn_factura.Name = "Radiobtn_factura";
            this.Radiobtn_factura.Size = new System.Drawing.Size(89, 27);
            this.Radiobtn_factura.TabIndex = 1;
            this.Radiobtn_factura.TabStop = true;
            this.Radiobtn_factura.Text = "Factura";
            this.Radiobtn_factura.UseVisualStyleBackColor = true;
            this.Radiobtn_factura.CheckedChanged += new System.EventHandler(this.RadioBtn_Si_CheckedChanged);
            // 
            // RadioBtn_creditoFiscal
            // 
            this.RadioBtn_creditoFiscal.AutoSize = true;
            this.RadioBtn_creditoFiscal.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBtn_creditoFiscal.Location = new System.Drawing.Point(28, 54);
            this.RadioBtn_creditoFiscal.Name = "RadioBtn_creditoFiscal";
            this.RadioBtn_creditoFiscal.Size = new System.Drawing.Size(136, 27);
            this.RadioBtn_creditoFiscal.TabIndex = 0;
            this.RadioBtn_creditoFiscal.Text = "Credito Fiscal";
            this.RadioBtn_creditoFiscal.UseVisualStyleBackColor = true;
            this.RadioBtn_creditoFiscal.CheckedChanged += new System.EventHandler(this.RadioBtn_Si_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-1, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 100);
            this.panel1.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(277, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(205)))), ((int)(((byte)(196)))));
            this.label9.Location = new System.Drawing.Point(167, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 36);
            this.label9.TabIndex = 15;
            this.label9.Text = "Compra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(216)))), ((int)(((byte)(218)))));
            this.label7.Location = new System.Drawing.Point(70, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 36);
            this.label7.TabIndex = 14;
            this.label7.Text = "Registrar";
            // 
            // gridTotales
            // 
            this.gridTotales.AllowUserToAddRows = false;
            this.gridTotales.AllowUserToDeleteRows = false;
            this.gridTotales.AllowUserToResizeColumns = false;
            this.gridTotales.AllowUserToResizeRows = false;
            this.gridTotales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTotales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.gridTotales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridTotales.Location = new System.Drawing.Point(913, 489);
            this.gridTotales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridTotales.MultiSelect = false;
            this.gridTotales.Name = "gridTotales";
            this.gridTotales.ReadOnly = true;
            this.gridTotales.RowHeadersWidth = 51;
            this.gridTotales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTotales.Size = new System.Drawing.Size(415, 283);
            this.gridTotales.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Form_RegistrarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 949);
            this.Controls.Add(this.gridTotales);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridDetalleProducto);
            this.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_RegistrarCompra";
            this.Text = "Form_RegistrarCompra";
            this.Load += new System.EventHandler(this.Form_RegistrarCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiasCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_BuscarProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleProducto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_BuscarProducto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTotales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridView gridDetalleProducto;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker txtFechaFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.PictureBox btn_BuscarProveedor;
        private System.Windows.Forms.PictureBox btn_BuscarProducto;
        private System.Windows.Forms.NumericUpDown txtdiasCredito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RadioBtn_no;
        private System.Windows.Forms.RadioButton RadioBtn_Si;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton Radiobtn_factura;
        private System.Windows.Forms.RadioButton RadioBtn_creditoFiscal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}