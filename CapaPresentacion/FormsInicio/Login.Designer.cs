
namespace CapaPresentacion {
    partial class Login {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel_Contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Titulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_iniciarSesion = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Contenedor
            // 
            this.panel_Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(216)))), ((int)(((byte)(218)))));
            this.panel_Contenedor.Controls.Add(this.label2);
            this.panel_Contenedor.Controls.Add(this.pictureBox1);
            this.panel_Contenedor.Controls.Add(this.panel_Titulo);
            this.panel_Contenedor.Controls.Add(this.btn_iniciarSesion);
            this.panel_Contenedor.Controls.Add(this.txtUsuario);
            this.panel_Contenedor.Controls.Add(this.txtPass);
            this.panel_Contenedor.Controls.Add(this.label3);
            this.panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Contenedor.Location = new System.Drawing.Point(0, 0);
            this.panel_Contenedor.Name = "panel_Contenedor";
            this.panel_Contenedor.Size = new System.Drawing.Size(469, 499);
            this.panel_Contenedor.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel_Titulo
            // 
            this.panel_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.panel_Titulo.Controls.Add(this.btnCerrar);
            this.panel_Titulo.Controls.Add(this.btn_minimizar);
            this.panel_Titulo.Controls.Add(this.label4);
            this.panel_Titulo.Controls.Add(this.label5);
            this.panel_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Titulo.Location = new System.Drawing.Point(0, 0);
            this.panel_Titulo.Name = "panel_Titulo";
            this.panel_Titulo.Size = new System.Drawing.Size(469, 40);
            this.panel_Titulo.TabIndex = 9;
            this.panel_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Titulo_MouseDown);
            this.panel_Titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Titulo_MouseMove);
            this.panel_Titulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Titulo_MouseUp);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(427, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(390, 9);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(35, 25);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_minimizar.TabIndex = 10;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(216)))), ((int)(((byte)(218)))));
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Iniciar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(205)))), ((int)(((byte)(196)))));
            this.label5.Location = new System.Drawing.Point(81, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sesión";
            // 
            // btn_iniciarSesion
            // 
            this.btn_iniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.btn_iniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_iniciarSesion.FlatAppearance.BorderSize = 0;
            this.btn_iniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(54)))), ((int)(((byte)(111)))));
            this.btn_iniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(54)))), ((int)(((byte)(111)))));
            this.btn_iniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciarSesion.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(216)))), ((int)(((byte)(218)))));
            this.btn_iniciarSesion.Location = new System.Drawing.Point(122, 368);
            this.btn_iniciarSesion.Name = "btn_iniciarSesion";
            this.btn_iniciarSesion.Size = new System.Drawing.Size(231, 46);
            this.btn_iniciarSesion.TabIndex = 8;
            this.btn_iniciarSesion.Text = "Iniciar Sesion";
            this.btn_iniciarSesion.UseVisualStyleBackColor = false;
            this.btn_iniciarSesion.Click += new System.EventHandler(this.btn_iniciarSesion_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(122, 242);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(231, 25);
            this.txtUsuario.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(122, 314);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(231, 25);
            this.txtPass.TabIndex = 7;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 499);
            this.Controls.Add(this.panel_Contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel_Contenedor.ResumeLayout(false);
            this.panel_Contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Titulo.ResumeLayout(false);
            this.panel_Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Contenedor;
        private System.Windows.Forms.Panel panel_Titulo;
        private System.Windows.Forms.Button btn_iniciarSesion;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}