
namespace CapaPresentacion.Ventas
{
    partial class Form_BuscarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BuscarCliente));
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.gridProducto = new System.Windows.Forms.DataGridView();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel_Titulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.panel_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(833, 67);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(87, 35);
            this.btn_cerrar.TabIndex = 23;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(707, 67);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(107, 35);
            this.btnSeleccionar.TabIndex = 22;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // gridProducto
            // 
            this.gridProducto.AutoGenerateColumns = false;
            this.gridProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.clasificacionDataGridViewTextBoxColumn,
            this.nitDataGridViewTextBoxColumn,
            this.nrcDataGridViewTextBoxColumn,
            this.Direccion});
            this.gridProducto.DataSource = this.clienteBindingSource;
            this.gridProducto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridProducto.Location = new System.Drawing.Point(62, 121);
            this.gridProducto.MultiSelect = false;
            this.gridProducto.Name = "gridProducto";
            this.gridProducto.ReadOnly = true;
            this.gridProducto.RowHeadersWidth = 51;
            this.gridProducto.RowTemplate.Height = 24;
            this.gridProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducto.Size = new System.Drawing.Size(858, 381);
            this.gridProducto.TabIndex = 21;
            this.gridProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducto_CellClick);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(CapaEntidades.Cliente);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(452, 67);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(87, 35);
            this.btnRefrescar.TabIndex = 20;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(62, 67);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 33);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(168, 78);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(261, 22);
            this.txtBuscar.TabIndex = 18;
            // 
            // panel_Titulo
            // 
            this.panel_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.panel_Titulo.Controls.Add(this.btnCerrar);
            this.panel_Titulo.Controls.Add(this.label4);
            this.panel_Titulo.Controls.Add(this.label5);
            this.panel_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Titulo.Location = new System.Drawing.Point(0, 0);
            this.panel_Titulo.Name = "panel_Titulo";
            this.panel_Titulo.Size = new System.Drawing.Size(983, 40);
            this.panel_Titulo.TabIndex = 24;
            this.panel_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Titulo_MouseDown);
            this.panel_Titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Titulo_MouseMove);
            this.panel_Titulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Titulo_MouseUp);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(941, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(216)))), ((int)(((byte)(218)))));
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Buscar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(205)))), ((int)(((byte)(196)))));
            this.label5.Location = new System.Drawing.Point(88, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cliente";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "_Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "_Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clasificacionDataGridViewTextBoxColumn
            // 
            this.clasificacionDataGridViewTextBoxColumn.DataPropertyName = "Clasificacion";
            this.clasificacionDataGridViewTextBoxColumn.HeaderText = "Clasificacion";
            this.clasificacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clasificacionDataGridViewTextBoxColumn.Name = "clasificacionDataGridViewTextBoxColumn";
            this.clasificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nitDataGridViewTextBoxColumn
            // 
            this.nitDataGridViewTextBoxColumn.DataPropertyName = "Nit";
            this.nitDataGridViewTextBoxColumn.HeaderText = "Nit";
            this.nitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nitDataGridViewTextBoxColumn.Name = "nitDataGridViewTextBoxColumn";
            this.nitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrcDataGridViewTextBoxColumn
            // 
            this.nrcDataGridViewTextBoxColumn.DataPropertyName = "Nrc";
            this.nrcDataGridViewTextBoxColumn.HeaderText = "Nrc";
            this.nrcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrcDataGridViewTextBoxColumn.Name = "nrcDataGridViewTextBoxColumn";
            this.nrcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Form_BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 559);
            this.Controls.Add(this.panel_Titulo);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.gridProducto);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_BuscarCliente";
            this.Text = "Form_BuscarCliente";
            this.Load += new System.EventHandler(this.Form_BuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.panel_Titulo.ResumeLayout(false);
            this.panel_Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView gridProducto;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panel_Titulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
    }
}