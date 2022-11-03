
namespace CapaPresentacion.Compras
{
    partial class FormBuscarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarProveedor));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.gridProveedores = new System.Windows.Forms.DataGridView();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_Titulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedores)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panel2);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1001, 606);
            this.panelContenedor.TabIndex = 0;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(845, 99);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(87, 35);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(719, 99);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(107, 35);
            this.btnSeleccionar.TabIndex = 16;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // gridProveedores
            // 
            this.gridProveedores.AutoGenerateColumns = false;
            this.gridProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.clasificacionDataGridViewTextBoxColumn,
            this.nitDataGridViewTextBoxColumn,
            this.nrcDataGridViewTextBoxColumn});
            this.gridProveedores.DataSource = this.proveedorBindingSource;
            this.gridProveedores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridProveedores.Location = new System.Drawing.Point(74, 153);
            this.gridProveedores.MultiSelect = false;
            this.gridProveedores.Name = "gridProveedores";
            this.gridProveedores.ReadOnly = true;
            this.gridProveedores.RowHeadersWidth = 51;
            this.gridProveedores.RowTemplate.Height = 24;
            this.gridProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProveedores.Size = new System.Drawing.Size(858, 381);
            this.gridProveedores.TabIndex = 15;
            this.gridProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProveedores_CellClick);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(464, 99);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(87, 35);
            this.btnRefrescar.TabIndex = 14;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(74, 99);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 33);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(180, 110);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(261, 22);
            this.txtBuscar.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btn_cancelar);
            this.panel2.Controls.Add(this.panel_Titulo);
            this.panel2.Controls.Add(this.btnSeleccionar);
            this.panel2.Controls.Add(this.gridProveedores);
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Controls.Add(this.btnRefrescar);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 606);
            this.panel2.TabIndex = 18;
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
            this.panel_Titulo.Size = new System.Drawing.Size(1001, 40);
            this.panel_Titulo.TabIndex = 11;
            this.panel_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Titulo_MouseDown);
            this.panel_Titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Titulo_MouseMove);
            this.panel_Titulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Titulo_MouseUp);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(959, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
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
            this.label5.Location = new System.Drawing.Point(89, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Proveedor";
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataSource = typeof(CapaEntidades.Proveedor);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "_Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "_Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 161;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 161;
            // 
            // clasificacionDataGridViewTextBoxColumn
            // 
            this.clasificacionDataGridViewTextBoxColumn.DataPropertyName = "Clasificacion";
            this.clasificacionDataGridViewTextBoxColumn.HeaderText = "Clasificacion";
            this.clasificacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clasificacionDataGridViewTextBoxColumn.Name = "clasificacionDataGridViewTextBoxColumn";
            this.clasificacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.clasificacionDataGridViewTextBoxColumn.Width = 161;
            // 
            // nitDataGridViewTextBoxColumn
            // 
            this.nitDataGridViewTextBoxColumn.DataPropertyName = "Nit";
            this.nitDataGridViewTextBoxColumn.HeaderText = "Nit";
            this.nitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nitDataGridViewTextBoxColumn.Name = "nitDataGridViewTextBoxColumn";
            this.nitDataGridViewTextBoxColumn.ReadOnly = true;
            this.nitDataGridViewTextBoxColumn.Width = 161;
            // 
            // nrcDataGridViewTextBoxColumn
            // 
            this.nrcDataGridViewTextBoxColumn.DataPropertyName = "Nrc";
            this.nrcDataGridViewTextBoxColumn.HeaderText = "Nrc";
            this.nrcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrcDataGridViewTextBoxColumn.Name = "nrcDataGridViewTextBoxColumn";
            this.nrcDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrcDataGridViewTextBoxColumn.Width = 161;
            // 
            // FormBuscarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 606);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBuscarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormBuscarProveedor";
            this.Load += new System.EventHandler(this.FormBuscarProveedor_Load);
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedores)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_Titulo.ResumeLayout(false);
            this.panel_Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView gridProveedores;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_Titulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcDataGridViewTextBoxColumn;
    }
}