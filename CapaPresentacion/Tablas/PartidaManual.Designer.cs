
namespace CapaPresentacion.Tablas
{
    partial class PartidaManual
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartidaManual));
            this.panelIzquierda = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblHaber = new System.Windows.Forms.Label();
            this.lblDebe = new System.Windows.Forms.Label();
            this.checkImprimir = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripccion = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.gridPartida = new System.Windows.Forms.DataGridView();
            this.idCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelDerecha = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarCuenta = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.gridCuentas = new System.Windows.Forms.DataGridView();
            this.id1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agrupacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiposaldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentapadreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaCatalogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panelIzquierda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPartida)).BeginInit();
            this.panelDerecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaCatalogoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIzquierda
            // 
            this.panelIzquierda.Controls.Add(this.button1);
            this.panelIzquierda.Controls.Add(this.btnGuardar);
            this.panelIzquierda.Controls.Add(this.btnSalir);
            this.panelIzquierda.Controls.Add(this.lblHaber);
            this.panelIzquierda.Controls.Add(this.lblDebe);
            this.panelIzquierda.Controls.Add(this.checkImprimir);
            this.panelIzquierda.Controls.Add(this.label3);
            this.panelIzquierda.Controls.Add(this.label2);
            this.panelIzquierda.Controls.Add(this.txtDescripccion);
            this.panelIzquierda.Controls.Add(this.txtFecha);
            this.panelIzquierda.Controls.Add(this.gridPartida);
            this.panelIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierda.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierda.Name = "panelIzquierda";
            this.panelIzquierda.Size = new System.Drawing.Size(905, 743);
            this.panelIzquierda.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Silver;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(25, 622);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 58);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = " Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Silver;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(321, 622);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(141, 58);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = " Regresar";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblHaber
            // 
            this.lblHaber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHaber.AutoSize = true;
            this.lblHaber.Location = new System.Drawing.Point(679, 560);
            this.lblHaber.Name = "lblHaber";
            this.lblHaber.Size = new System.Drawing.Size(44, 17);
            this.lblHaber.TabIndex = 9;
            this.lblHaber.Text = "$0.00";
            // 
            // lblDebe
            // 
            this.lblDebe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDebe.AutoSize = true;
            this.lblDebe.Location = new System.Drawing.Point(548, 560);
            this.lblDebe.Name = "lblDebe";
            this.lblDebe.Size = new System.Drawing.Size(44, 17);
            this.lblDebe.TabIndex = 8;
            this.lblDebe.Text = "$0.00";
            // 
            // checkImprimir
            // 
            this.checkImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkImprimir.AutoSize = true;
            this.checkImprimir.Checked = true;
            this.checkImprimir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkImprimir.Location = new System.Drawing.Point(25, 574);
            this.checkImprimir.Name = "checkImprimir";
            this.checkImprimir.Size = new System.Drawing.Size(164, 21);
            this.checkImprimir.TabIndex = 7;
            this.checkImprimir.Text = "¿Imprimir al guardar?";
            this.checkImprimir.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcción:";
            // 
            // txtDescripccion
            // 
            this.txtDescripccion.Location = new System.Drawing.Point(120, 74);
            this.txtDescripccion.Multiline = true;
            this.txtDescripccion.Name = "txtDescripccion";
            this.txtDescripccion.Size = new System.Drawing.Size(379, 80);
            this.txtDescripccion.TabIndex = 2;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(121, 35);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(275, 22);
            this.txtFecha.TabIndex = 1;
            // 
            // gridPartida
            // 
            this.gridPartida.AllowUserToAddRows = false;
            this.gridPartida.AllowUserToDeleteRows = false;
            this.gridPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPartida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPartida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPartida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCuenta,
            this.Codigo,
            this.Nombre,
            this.Debe,
            this.Haber,
            this.X});
            this.gridPartida.Location = new System.Drawing.Point(21, 171);
            this.gridPartida.MultiSelect = false;
            this.gridPartida.Name = "gridPartida";
            this.gridPartida.RowHeadersVisible = false;
            this.gridPartida.RowHeadersWidth = 51;
            this.gridPartida.RowTemplate.Height = 24;
            this.gridPartida.Size = new System.Drawing.Size(854, 386);
            this.gridPartida.TabIndex = 0;
            this.gridPartida.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPartida_CellDoubleClick);
            this.gridPartida.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPartida_CellEndEdit);
            // 
            // idCuenta
            // 
            this.idCuenta.HeaderText = "idCuenta";
            this.idCuenta.MinimumWidth = 6;
            this.idCuenta.Name = "idCuenta";
            this.idCuenta.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.FillWeight = 75F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 300F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Debe
            // 
            this.Debe.HeaderText = "Debe";
            this.Debe.MinimumWidth = 6;
            this.Debe.Name = "Debe";
            // 
            // Haber
            // 
            this.Haber.HeaderText = "Haber";
            this.Haber.MinimumWidth = 6;
            this.Haber.Name = "Haber";
            // 
            // X
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.X.DefaultCellStyle = dataGridViewCellStyle3;
            this.X.FillWeight = 60F;
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Text = "X";
            this.X.UseColumnTextForButtonValue = true;
            // 
            // panelDerecha
            // 
            this.panelDerecha.Controls.Add(this.label1);
            this.panelDerecha.Controls.Add(this.txtBuscarCuenta);
            this.panelDerecha.Controls.Add(this.lblError);
            this.panelDerecha.Controls.Add(this.gridCuentas);
            this.panelDerecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDerecha.Location = new System.Drawing.Point(905, 0);
            this.panelDerecha.Name = "panelDerecha";
            this.panelDerecha.Size = new System.Drawing.Size(612, 743);
            this.panelDerecha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "     Buscar";
            // 
            // txtBuscarCuenta
            // 
            this.txtBuscarCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarCuenta.Location = new System.Drawing.Point(167, 35);
            this.txtBuscarCuenta.Name = "txtBuscarCuenta";
            this.txtBuscarCuenta.Size = new System.Drawing.Size(373, 22);
            this.txtBuscarCuenta.TabIndex = 3;
            this.txtBuscarCuenta.TextChanged += new System.EventHandler(this.txtBuscarCuenta_TextChanged);
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Image = ((System.Drawing.Image)(resources.GetObject("lblError.Image")));
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Location = new System.Drawing.Point(143, 649);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(357, 52);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "     Una cuenta solo puede aparecer \r\n      maximo dos veces por partida";
            this.lblError.Visible = false;
            // 
            // gridCuentas
            // 
            this.gridCuentas.AllowUserToAddRows = false;
            this.gridCuentas.AllowUserToDeleteRows = false;
            this.gridCuentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCuentas.AutoGenerateColumns = false;
            this.gridCuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id1DataGridViewTextBoxColumn,
            this.rubroDataGridViewTextBoxColumn,
            this.agrupacionDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.debeDataGridViewTextBoxColumn,
            this.haberDataGridViewTextBoxColumn,
            this.tiposaldoDataGridViewTextBoxColumn,
            this.cuentapadreDataGridViewTextBoxColumn,
            this.nivelDataGridViewTextBoxColumn});
            this.gridCuentas.DataSource = this.cuentaCatalogoBindingSource;
            this.gridCuentas.Location = new System.Drawing.Point(30, 74);
            this.gridCuentas.MultiSelect = false;
            this.gridCuentas.Name = "gridCuentas";
            this.gridCuentas.RowHeadersVisible = false;
            this.gridCuentas.RowHeadersWidth = 51;
            this.gridCuentas.RowTemplate.Height = 24;
            this.gridCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCuentas.Size = new System.Drawing.Size(547, 572);
            this.gridCuentas.TabIndex = 1;
            this.gridCuentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCuentas_CellDoubleClick);
            // 
            // id1DataGridViewTextBoxColumn
            // 
            this.id1DataGridViewTextBoxColumn.DataPropertyName = "Id1";
            this.id1DataGridViewTextBoxColumn.HeaderText = "Id1";
            this.id1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.id1DataGridViewTextBoxColumn.Name = "id1DataGridViewTextBoxColumn";
            this.id1DataGridViewTextBoxColumn.Visible = false;
            // 
            // rubroDataGridViewTextBoxColumn
            // 
            this.rubroDataGridViewTextBoxColumn.DataPropertyName = "Rubro";
            this.rubroDataGridViewTextBoxColumn.HeaderText = "Rubro";
            this.rubroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rubroDataGridViewTextBoxColumn.Name = "rubroDataGridViewTextBoxColumn";
            this.rubroDataGridViewTextBoxColumn.Visible = false;
            // 
            // agrupacionDataGridViewTextBoxColumn
            // 
            this.agrupacionDataGridViewTextBoxColumn.DataPropertyName = "Agrupacion";
            this.agrupacionDataGridViewTextBoxColumn.HeaderText = "Agrupacion";
            this.agrupacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.agrupacionDataGridViewTextBoxColumn.Name = "agrupacionDataGridViewTextBoxColumn";
            this.agrupacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.FillWeight = 50F;
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.FillWeight = 200F;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // debeDataGridViewTextBoxColumn
            // 
            this.debeDataGridViewTextBoxColumn.DataPropertyName = "Debe";
            this.debeDataGridViewTextBoxColumn.HeaderText = "Debe";
            this.debeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.debeDataGridViewTextBoxColumn.Name = "debeDataGridViewTextBoxColumn";
            this.debeDataGridViewTextBoxColumn.Visible = false;
            // 
            // haberDataGridViewTextBoxColumn
            // 
            this.haberDataGridViewTextBoxColumn.DataPropertyName = "Haber";
            this.haberDataGridViewTextBoxColumn.HeaderText = "Haber";
            this.haberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.haberDataGridViewTextBoxColumn.Name = "haberDataGridViewTextBoxColumn";
            this.haberDataGridViewTextBoxColumn.Visible = false;
            // 
            // tiposaldoDataGridViewTextBoxColumn
            // 
            this.tiposaldoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_saldo";
            this.tiposaldoDataGridViewTextBoxColumn.HeaderText = "Tipo_saldo";
            this.tiposaldoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tiposaldoDataGridViewTextBoxColumn.Name = "tiposaldoDataGridViewTextBoxColumn";
            this.tiposaldoDataGridViewTextBoxColumn.Visible = false;
            // 
            // cuentapadreDataGridViewTextBoxColumn
            // 
            this.cuentapadreDataGridViewTextBoxColumn.DataPropertyName = "Cuenta_padre";
            this.cuentapadreDataGridViewTextBoxColumn.HeaderText = "Cuenta_padre";
            this.cuentapadreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cuentapadreDataGridViewTextBoxColumn.Name = "cuentapadreDataGridViewTextBoxColumn";
            this.cuentapadreDataGridViewTextBoxColumn.Visible = false;
            // 
            // nivelDataGridViewTextBoxColumn
            // 
            this.nivelDataGridViewTextBoxColumn.DataPropertyName = "Nivel";
            this.nivelDataGridViewTextBoxColumn.HeaderText = "Nivel";
            this.nivelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nivelDataGridViewTextBoxColumn.Name = "nivelDataGridViewTextBoxColumn";
            this.nivelDataGridViewTextBoxColumn.Visible = false;
            // 
            // cuentaCatalogoBindingSource
            // 
            this.cuentaCatalogoBindingSource.DataSource = typeof(CapaEntidades.CuentaCatalogo);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(173, 622);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 58);
            this.button1.TabIndex = 23;
            this.button1.Text = " Limpiar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PartidaManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 743);
            this.Controls.Add(this.panelDerecha);
            this.Controls.Add(this.panelIzquierda);
            this.Name = "PartidaManual";
            this.Text = "PartidaManual";
            this.Load += new System.EventHandler(this.PartidaManual_Load);
            this.panelIzquierda.ResumeLayout(false);
            this.panelIzquierda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPartida)).EndInit();
            this.panelDerecha.ResumeLayout(false);
            this.panelDerecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaCatalogoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierda;
        private System.Windows.Forms.DataGridView gridPartida;
        private System.Windows.Forms.Panel panelDerecha;
        private System.Windows.Forms.TextBox txtBuscarCuenta;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView gridCuentas;
        private System.Windows.Forms.BindingSource cuentaCatalogoBindingSource;
        private System.Windows.Forms.Label lblHaber;
        private System.Windows.Forms.Label lblDebe;
        private System.Windows.Forms.CheckBox checkImprimir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripccion;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Haber;
        private System.Windows.Forms.DataGridViewButtonColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agrupacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn haberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposaldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentapadreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button button1;
    }
}