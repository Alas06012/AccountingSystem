
namespace CapaPresentacion.Ventas
{
    partial class FormSerie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSerie));
            this.gridSerie = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iniciadesdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminaenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbtipo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txthasta = new System.Windows.Forms.NumericUpDown();
            this.txtdesde = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.panel_Titulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridSerie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serieBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txthasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdesde)).BeginInit();
            this.panel_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSerie
            // 
            this.gridSerie.AllowUserToAddRows = false;
            this.gridSerie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSerie.AutoGenerateColumns = false;
            this.gridSerie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSerie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.iniciadesdeDataGridViewTextBoxColumn,
            this.terminaenDataGridViewTextBoxColumn,
            this.serieDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.gridSerie.DataSource = this.serieBindingSource;
            this.gridSerie.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridSerie.Location = new System.Drawing.Point(49, 272);
            this.gridSerie.MultiSelect = false;
            this.gridSerie.Name = "gridSerie";
            this.gridSerie.ReadOnly = true;
            this.gridSerie.RowHeadersWidth = 51;
            this.gridSerie.RowTemplate.Height = 24;
            this.gridSerie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSerie.Size = new System.Drawing.Size(858, 428);
            this.gridSerie.TabIndex = 31;
            this.gridSerie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSerie_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iniciadesdeDataGridViewTextBoxColumn
            // 
            this.iniciadesdeDataGridViewTextBoxColumn.DataPropertyName = "Inicia_desde";
            this.iniciadesdeDataGridViewTextBoxColumn.HeaderText = "Inicia_desde";
            this.iniciadesdeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iniciadesdeDataGridViewTextBoxColumn.Name = "iniciadesdeDataGridViewTextBoxColumn";
            this.iniciadesdeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // terminaenDataGridViewTextBoxColumn
            // 
            this.terminaenDataGridViewTextBoxColumn.DataPropertyName = "Termina_en";
            this.terminaenDataGridViewTextBoxColumn.HeaderText = "Termina_en";
            this.terminaenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.terminaenDataGridViewTextBoxColumn.Name = "terminaenDataGridViewTextBoxColumn";
            this.terminaenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "_Serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "_Serie";
            this.serieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            this.serieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serieBindingSource
            // 
            this.serieBindingSource.DataSource = typeof(CapaEntidades.Serie);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cmbtipo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_cerrar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSeleccionar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txthasta);
            this.groupBox1.Controls.Add(this.txtdesde);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtserie);
            this.groupBox1.Location = new System.Drawing.Point(49, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 209);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Serie";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(711, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 35);
            this.button2.TabIndex = 40;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbtipo
            // 
            this.cmbtipo.FormattingEnabled = true;
            this.cmbtipo.Items.AddRange(new object[] {
            "ccf",
            "fcf",
            "fex",
            "nc",
            "nr",
            "nd"});
            this.cmbtipo.Location = new System.Drawing.Point(149, 148);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.Size = new System.Drawing.Size(232, 24);
            this.cmbtipo.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(102, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 17);
            this.label12.TabIndex = 38;
            this.label12.Text = "Tipo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(711, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 37;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(711, 158);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(120, 35);
            this.btn_cerrar.TabIndex = 29;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(462, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Nota de Débito";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(711, 35);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(120, 35);
            this.btnSeleccionar.TabIndex = 28;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(461, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Nota de Revisión";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(461, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Nota de Crédito";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(461, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Factura de Exportación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(461, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Factura de Consumidor Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(461, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Crédito Fiscal";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(400, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 146);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "CCF\r\nFCF\r\nFEX\r\nNC\r\nNR\r\nND\r\n";
            // 
            // txthasta
            // 
            this.txthasta.Location = new System.Drawing.Point(149, 112);
            this.txthasta.Name = "txthasta";
            this.txthasta.Size = new System.Drawing.Size(120, 22);
            this.txthasta.TabIndex = 29;
            // 
            // txtdesde
            // 
            this.txtdesde.Location = new System.Drawing.Point(149, 76);
            this.txtdesde.Name = "txtdesde";
            this.txtdesde.Size = new System.Drawing.Size(120, 22);
            this.txtdesde.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Termina en:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Inicia en:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Numero de Serie:";
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(148, 32);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(233, 22);
            this.txtserie.TabIndex = 24;
            // 
            // panel_Titulo
            // 
            this.panel_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.panel_Titulo.Controls.Add(this.btnCerrar);
            this.panel_Titulo.Controls.Add(this.label10);
            this.panel_Titulo.Controls.Add(this.label11);
            this.panel_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Titulo.Location = new System.Drawing.Point(0, 0);
            this.panel_Titulo.Name = "panel_Titulo";
            this.panel_Titulo.Size = new System.Drawing.Size(965, 40);
            this.panel_Titulo.TabIndex = 33;
            this.panel_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Titulo_MouseDown);
            this.panel_Titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Titulo_MouseMove);
            this.panel_Titulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Titulo_MouseUp);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(923, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(216)))), ((int)(((byte)(218)))));
            this.label10.Location = new System.Drawing.Point(10, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 26);
            this.label10.TabIndex = 11;
            this.label10.Text = "Número";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(205)))), ((int)(((byte)(196)))));
            this.label11.Location = new System.Drawing.Point(100, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 26);
            this.label11.TabIndex = 10;
            this.label11.Text = "Serie";
            // 
            // FormSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(965, 752);
            this.Controls.Add(this.panel_Titulo);
            this.Controls.Add(this.gridSerie);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSerie";
            this.Text = "FormSerie";
            this.Load += new System.EventHandler(this.FormSerie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSerie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serieBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txthasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdesde)).EndInit();
            this.panel_Titulo.ResumeLayout(false);
            this.panel_Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown txthasta;
        private System.Windows.Forms.NumericUpDown txtdesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.Panel panel_Titulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iniciadesdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminaenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource serieBindingSource;
        private System.Windows.Forms.ComboBox cmbtipo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
    }
}