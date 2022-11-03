
namespace CapaPresentacion.Contables
{
    partial class EstadosFinancieros
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
            this.btnEstadoResultado = new System.Windows.Forms.Button();
            this.lblUtilidadNeta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstadoResultado
            // 
            this.btnEstadoResultado.Location = new System.Drawing.Point(259, 50);
            this.btnEstadoResultado.Name = "btnEstadoResultado";
            this.btnEstadoResultado.Size = new System.Drawing.Size(160, 101);
            this.btnEstadoResultado.TabIndex = 0;
            this.btnEstadoResultado.Text = "Ver Estado de Resultados";
            this.btnEstadoResultado.UseVisualStyleBackColor = true;
            this.btnEstadoResultado.Click += new System.EventHandler(this.btnEstadoResultado_Click);
            // 
            // lblUtilidadNeta
            // 
            this.lblUtilidadNeta.AutoSize = true;
            this.lblUtilidadNeta.Location = new System.Drawing.Point(53, 82);
            this.lblUtilidadNeta.Name = "lblUtilidadNeta";
            this.lblUtilidadNeta.Size = new System.Drawing.Size(46, 17);
            this.lblUtilidadNeta.TabIndex = 1;
            this.lblUtilidadNeta.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 101);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ver Balance General";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EstadosFinancieros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 664);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUtilidadNeta);
            this.Controls.Add(this.btnEstadoResultado);
            this.Name = "EstadosFinancieros";
            this.Text = "EstadosFinancieros";
            this.Load += new System.EventHandler(this.EstadosFinancieros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstadoResultado;
        private System.Windows.Forms.Label lblUtilidadNeta;
        private System.Windows.Forms.Button button1;
    }
}