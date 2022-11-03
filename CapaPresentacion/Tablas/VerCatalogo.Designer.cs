
namespace CapaPresentacion.Tablas
{
    partial class VerCatalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerCatalogo));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agrupacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiposaldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentapadreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaCatalogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLibroMayor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaCatalogoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.codigoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.nivelDataGridViewTextBoxColumn,
            this.agrupacionDataGridViewTextBoxColumn,
            this.debeDataGridViewTextBoxColumn,
            this.haberDataGridViewTextBoxColumn,
            this.tiposaldoDataGridViewTextBoxColumn,
            this.cuentapadreDataGridViewTextBoxColumn,
            this.rubroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cuentaCatalogoBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(53, 162);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 556);
            this.dataGridView1.TabIndex = 1;
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
            // agrupacionDataGridViewTextBoxColumn
            // 
            this.agrupacionDataGridViewTextBoxColumn.DataPropertyName = "Agrupacion";
            this.agrupacionDataGridViewTextBoxColumn.HeaderText = "Agrupacion";
            this.agrupacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.agrupacionDataGridViewTextBoxColumn.Name = "agrupacionDataGridViewTextBoxColumn";
            this.agrupacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.agrupacionDataGridViewTextBoxColumn.Visible = false;
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
            // rubroDataGridViewTextBoxColumn
            // 
            this.rubroDataGridViewTextBoxColumn.DataPropertyName = "Rubro";
            this.rubroDataGridViewTextBoxColumn.HeaderText = "Rubro";
            this.rubroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rubroDataGridViewTextBoxColumn.Name = "rubroDataGridViewTextBoxColumn";
            this.rubroDataGridViewTextBoxColumn.ReadOnly = true;
            this.rubroDataGridViewTextBoxColumn.Visible = false;
            // 
            // cuentaCatalogoBindingSource
            // 
            this.cuentaCatalogoBindingSource.DataSource = typeof(CapaEntidades.CuentaCatalogo);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 100);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(348, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.label9.Location = new System.Drawing.Point(222, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 36);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cuentas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(216)))), ((int)(((byte)(218)))));
            this.label8.Location = new System.Drawing.Point(57, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "Catalogo de ";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(703, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 58);
            this.button3.TabIndex = 21;
            this.button3.Text = " Regresar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLibroMayor
            // 
            this.btnLibroMayor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLibroMayor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btnLibroMayor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibroMayor.Enabled = false;
            this.btnLibroMayor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.btnLibroMayor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.btnLibroMayor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibroMayor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibroMayor.ForeColor = System.Drawing.Color.Silver;
            this.btnLibroMayor.Image = ((System.Drawing.Image)(resources.GetObject("btnLibroMayor.Image")));
            this.btnLibroMayor.Location = new System.Drawing.Point(857, 98);
            this.btnLibroMayor.Name = "btnLibroMayor";
            this.btnLibroMayor.Size = new System.Drawing.Size(202, 58);
            this.btnLibroMayor.TabIndex = 22;
            this.btnLibroMayor.Text = " Ver Libro Mayor";
            this.btnLibroMayor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLibroMayor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibroMayor.UseVisualStyleBackColor = false;
            this.btnLibroMayor.Click += new System.EventHandler(this.btnLibroMayor_Click);
            // 
            // VerCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 730);
            this.Controls.Add(this.btnLibroMayor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VerCatalogo";
            this.Text = "VerCatalogo";
            this.Load += new System.EventHandler(this.VerCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaCatalogoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cuentaCatalogoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agrupacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn haberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposaldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentapadreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLibroMayor;
    }
}