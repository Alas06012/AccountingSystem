
namespace CapaPresentacion.Tablas
{
    partial class FormularioKardex
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioKardex));
            this.ReportekardexDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteKardexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txthasta = new System.Windows.Forms.DateTimePicker();
            this.txtdesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btn_maximizar = new System.Windows.Forms.PictureBox();
            this.l = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_restaurar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReportekardexDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteKardexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportekardexDetalleBindingSource
            // 
            this.ReportekardexDetalleBindingSource.DataSource = typeof(Reportes.ReportekardexDetalle);
            // 
            // ReporteKardexBindingSource
            // 
            this.ReporteKardexBindingSource.DataSource = typeof(Reportes.ReporteKardex);
            // 
            // ProductoBindingSource
            // 
            this.ProductoBindingSource.DataSource = typeof(CapaEntidades.Producto);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.reportViewer1);
            this.panelContenedor.Controls.Add(this.panel2);
            this.panelContenedor.Controls.Add(this.panelTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1140, 714);
            this.panelContenedor.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "KardexDetalles";
            reportDataSource1.Value = this.ReportekardexDetalleBindingSource;
            reportDataSource2.Name = "KardexFechas";
            reportDataSource2.Value = this.ReporteKardexBindingSource;
            reportDataSource3.Name = "Producto";
            reportDataSource3.Value = this.ProductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Kardex.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(280, 40);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(860, 674);
            this.reportViewer1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.txthasta);
            this.panel2.Controls.Add(this.txtdesde);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 674);
            this.panel2.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(54)))), ((int)(((byte)(111)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(54)))), ((int)(((byte)(111)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(216)))), ((int)(((byte)(218)))));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(0, 318);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(281, 85);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "  Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txthasta
            // 
            this.txthasta.Location = new System.Drawing.Point(34, 244);
            this.txthasta.Name = "txthasta";
            this.txthasta.Size = new System.Drawing.Size(223, 22);
            this.txthasta.TabIndex = 4;
            // 
            // txtdesde
            // 
            this.txtdesde.Location = new System.Drawing.Point(34, 142);
            this.txtdesde.Name = "txtdesde";
            this.txtdesde.Size = new System.Drawing.Size(223, 22);
            this.txtdesde.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(216)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(30, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(216)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(30, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(216)))), ((int)(((byte)(218)))));
            this.label4.Location = new System.Drawing.Point(81, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 42);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kardex";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.panelTitulo.Controls.Add(this.btn_maximizar);
            this.panelTitulo.Controls.Add(this.l);
            this.panelTitulo.Controls.Add(this.label2);
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Controls.Add(this.btn_minimizar);
            this.panelTitulo.Controls.Add(this.btn_restaurar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1140, 40);
            this.panelTitulo.TabIndex = 3;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            this.panelTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseMove);
            this.panelTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseUp);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximizar.Image")));
            this.btn_maximizar.Location = new System.Drawing.Point(1057, 7);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(35, 25);
            this.btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_maximizar.TabIndex = 0;
            this.btn_maximizar.TabStop = false;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(216)))), ((int)(((byte)(218)))));
            this.l.Location = new System.Drawing.Point(11, 6);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(79, 26);
            this.l.TabIndex = 7;
            this.l.Text = "Kardex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(205)))), ((int)(((byte)(196)))));
            this.label2.Location = new System.Drawing.Point(96, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Control Inventario";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1098, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(1016, 7);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(35, 25);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_minimizar.TabIndex = 0;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restaurar.Image = ((System.Drawing.Image)(resources.GetObject("btn_restaurar.Image")));
            this.btn_restaurar.Location = new System.Drawing.Point(1063, 8);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(25, 25);
            this.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_restaurar.TabIndex = 0;
            this.btn_restaurar.TabStop = false;
            this.btn_restaurar.Visible = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(54)))), ((int)(((byte)(111)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(54)))), ((int)(((byte)(111)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(216)))), ((int)(((byte)(218)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 85);
            this.button1.TabIndex = 6;
            this.button1.Text = "  Regresar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormularioKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 714);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioKardex";
            this.Text = "FormularioKardex";
            this.Load += new System.EventHandler(this.FormularioKardex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportekardexDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteKardexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox btn_maximizar;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btn_restaurar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportekardexDetalleBindingSource;
        private System.Windows.Forms.BindingSource ReporteKardexBindingSource;
        private System.Windows.Forms.BindingSource ProductoBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker txthasta;
        private System.Windows.Forms.DateTimePicker txtdesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}