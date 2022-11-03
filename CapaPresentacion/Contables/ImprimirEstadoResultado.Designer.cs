
namespace CapaPresentacion.Contables
{
    partial class ImprimirEstadoResultado
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CuentaCatalogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EstadoResultadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CuentaCatalogoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadoResultadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "gastos";
            reportDataSource1.Value = this.CuentaCatalogoBindingSource;
            reportDataSource2.Name = "resultados";
            reportDataSource2.Value = this.EstadoResultadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.EstadoResultado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1019, 642);
            this.reportViewer1.TabIndex = 0;
            // 
            // CuentaCatalogoBindingSource
            // 
            this.CuentaCatalogoBindingSource.DataSource = typeof(CapaEntidades.CuentaCatalogo);
            // 
            // EstadoResultadosBindingSource
            // 
            this.EstadoResultadosBindingSource.DataSource = typeof(Reportes.EstadoResultados);
            // 
            // ImprimirEstadoResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 642);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ImprimirEstadoResultado";
            this.Text = "ImprimirEstadoResultado";
            this.Load += new System.EventHandler(this.ImprimirEstadoResultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CuentaCatalogoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadoResultadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CuentaCatalogoBindingSource;
        private System.Windows.Forms.BindingSource EstadoResultadosBindingSource;
    }
}