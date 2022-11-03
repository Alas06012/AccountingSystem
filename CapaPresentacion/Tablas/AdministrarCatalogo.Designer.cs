
namespace CapaPresentacion.Tablas
{
    partial class AdministrarCatalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarCatalogo));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agrupacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiposaldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentapadreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaCatalogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpadre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckNo = new System.Windows.Forms.RadioButton();
            this.CheckSi = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaCatalogoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id1DataGridViewTextBoxColumn,
            this.rubroDataGridViewTextBoxColumn,
            this.agrupacionDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.nivelDataGridViewTextBoxColumn,
            this.debeDataGridViewTextBoxColumn,
            this.haberDataGridViewTextBoxColumn,
            this.tiposaldoDataGridViewTextBoxColumn,
            this.cuentapadreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cuentaCatalogoBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(27, 36);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1190, 508);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id1DataGridViewTextBoxColumn
            // 
            this.id1DataGridViewTextBoxColumn.DataPropertyName = "Id1";
            this.id1DataGridViewTextBoxColumn.HeaderText = "Id1";
            this.id1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.id1DataGridViewTextBoxColumn.Name = "id1DataGridViewTextBoxColumn";
            this.id1DataGridViewTextBoxColumn.ReadOnly = true;
            this.id1DataGridViewTextBoxColumn.Visible = false;
            // 
            // rubroDataGridViewTextBoxColumn
            // 
            this.rubroDataGridViewTextBoxColumn.DataPropertyName = "Rubro";
            this.rubroDataGridViewTextBoxColumn.HeaderText = "Rubro";
            this.rubroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rubroDataGridViewTextBoxColumn.Name = "rubroDataGridViewTextBoxColumn";
            this.rubroDataGridViewTextBoxColumn.ReadOnly = true;
            this.rubroDataGridViewTextBoxColumn.Visible = false;
            // 
            // agrupacionDataGridViewTextBoxColumn
            // 
            this.agrupacionDataGridViewTextBoxColumn.DataPropertyName = "Agrupacion";
            this.agrupacionDataGridViewTextBoxColumn.HeaderText = "Agrupacion";
            this.agrupacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.agrupacionDataGridViewTextBoxColumn.Name = "agrupacionDataGridViewTextBoxColumn";
            this.agrupacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.agrupacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.FillWeight = 62.03209F;
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.FillWeight = 213.9037F;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nivelDataGridViewTextBoxColumn
            // 
            this.nivelDataGridViewTextBoxColumn.DataPropertyName = "Nivel";
            this.nivelDataGridViewTextBoxColumn.FillWeight = 62.03209F;
            this.nivelDataGridViewTextBoxColumn.HeaderText = "Nivel";
            this.nivelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nivelDataGridViewTextBoxColumn.Name = "nivelDataGridViewTextBoxColumn";
            this.nivelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // debeDataGridViewTextBoxColumn
            // 
            this.debeDataGridViewTextBoxColumn.DataPropertyName = "Debe";
            this.debeDataGridViewTextBoxColumn.HeaderText = "Debe";
            this.debeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.debeDataGridViewTextBoxColumn.Name = "debeDataGridViewTextBoxColumn";
            this.debeDataGridViewTextBoxColumn.ReadOnly = true;
            this.debeDataGridViewTextBoxColumn.Visible = false;
            // 
            // haberDataGridViewTextBoxColumn
            // 
            this.haberDataGridViewTextBoxColumn.DataPropertyName = "Haber";
            this.haberDataGridViewTextBoxColumn.HeaderText = "Haber";
            this.haberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.haberDataGridViewTextBoxColumn.Name = "haberDataGridViewTextBoxColumn";
            this.haberDataGridViewTextBoxColumn.ReadOnly = true;
            this.haberDataGridViewTextBoxColumn.Visible = false;
            // 
            // tiposaldoDataGridViewTextBoxColumn
            // 
            this.tiposaldoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_saldo";
            this.tiposaldoDataGridViewTextBoxColumn.FillWeight = 62.03209F;
            this.tiposaldoDataGridViewTextBoxColumn.HeaderText = "Tipo_saldo";
            this.tiposaldoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tiposaldoDataGridViewTextBoxColumn.Name = "tiposaldoDataGridViewTextBoxColumn";
            this.tiposaldoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cuentapadreDataGridViewTextBoxColumn
            // 
            this.cuentapadreDataGridViewTextBoxColumn.DataPropertyName = "Cuenta_padre";
            this.cuentapadreDataGridViewTextBoxColumn.HeaderText = "Cuenta_padre";
            this.cuentapadreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cuentapadreDataGridViewTextBoxColumn.Name = "cuentapadreDataGridViewTextBoxColumn";
            this.cuentapadreDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuentapadreDataGridViewTextBoxColumn.Visible = false;
            // 
            // cuentaCatalogoBindingSource
            // 
            this.cuentaCatalogoBindingSource.DataSource = typeof(CapaEntidades.CuentaCatalogo);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(60, 636);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(264, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 616);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nivel:";
            // 
            // txtpadre
            // 
            this.txtpadre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpadre.Enabled = false;
            this.txtpadre.Location = new System.Drawing.Point(583, 636);
            this.txtpadre.Name = "txtpadre";
            this.txtpadre.Size = new System.Drawing.Size(178, 22);
            this.txtpadre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 614);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Padre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CheckNo);
            this.groupBox1.Controls.Add(this.CheckSi);
            this.groupBox1.Location = new System.Drawing.Point(822, 690);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 155);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Retroactiva?";
            // 
            // CheckNo
            // 
            this.CheckNo.AutoSize = true;
            this.CheckNo.Location = new System.Drawing.Point(102, 71);
            this.CheckNo.Name = "CheckNo";
            this.CheckNo.Size = new System.Drawing.Size(50, 21);
            this.CheckNo.TabIndex = 1;
            this.CheckNo.TabStop = true;
            this.CheckNo.Text = "NO";
            this.CheckNo.UseVisualStyleBackColor = true;
            // 
            // CheckSi
            // 
            this.CheckSi.AutoSize = true;
            this.CheckSi.Location = new System.Drawing.Point(28, 71);
            this.CheckSi.Name = "CheckSi";
            this.CheckSi.Size = new System.Drawing.Size(41, 21);
            this.CheckSi.TabIndex = 0;
            this.CheckSi.TabStop = true;
            this.CheckSi.Text = "SI";
            this.CheckSi.UseVisualStyleBackColor = true;
            this.CheckSi.CheckedChanged += new System.EventHandler(this.CheckSi_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtnumero);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtbase);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(65, 683);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 162);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(512, 82);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(198, 22);
            this.txtCodigo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Código:";
            // 
            // txtnumero
            // 
            this.txtnumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnumero.Location = new System.Drawing.Point(259, 82);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(209, 22);
            this.txtnumero.TabIndex = 10;
            this.txtnumero.TextChanged += new System.EventHandler(this.txtnumero_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Número:";
            // 
            // txtbase
            // 
            this.txtbase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbase.Enabled = false;
            this.txtbase.Location = new System.Drawing.Point(19, 82);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(205, 22);
            this.txtbase.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Base:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(777, 636);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(196, 22);
            this.txtSaldo.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(774, 614);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Saldo:";
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Image = ((System.Drawing.Image)(resources.GetObject("lblError.Image")));
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Location = new System.Drawing.Point(353, 557);
            this.lblError.Name = "lblError";
            this.lblError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblError.Size = new System.Drawing.Size(339, 24);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "      No se puede elegir esta cuenta";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblError.Visible = false;
            // 
            // cmbNivel
            // 
            this.cmbNivel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNivel.Enabled = false;
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Location = new System.Drawing.Point(343, 636);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(224, 24);
            this.cmbNivel.TabIndex = 15;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Silver;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(1044, 575);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(139, 58);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = " Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Silver;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(1044, 656);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(139, 58);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = " Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Silver;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1044, 734);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(139, 58);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = " Regresar";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // AdministrarCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 867);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtpadre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdministrarCatalogo";
            this.Text = "AdministrarCatalogo";
            this.Load += new System.EventHandler(this.AdministrarCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaCatalogoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpadre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton CheckNo;
        private System.Windows.Forms.RadioButton CheckSi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agrupacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn haberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposaldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentapadreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cuentaCatalogoBindingSource;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
    }
}