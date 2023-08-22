namespace ProyectoDiseñoSoft
{
    partial class CuentaAdministrador
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
            this.labelUsuarioAdmin = new System.Windows.Forms.Label();
            this.labelcontrasenaAdmin = new System.Windows.Forms.Label();
            this.tbUsuarioAdmin = new System.Windows.Forms.TextBox();
            this.tbContrasenaAdmin = new System.Windows.Forms.TextBox();
            this.botonLoginAdmin = new System.Windows.Forms.Button();
            this.linkAtras = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelUsuarioAdmin
            // 
            this.labelUsuarioAdmin.AutoSize = true;
            this.labelUsuarioAdmin.Location = new System.Drawing.Point(161, 63);
            this.labelUsuarioAdmin.Name = "labelUsuarioAdmin";
            this.labelUsuarioAdmin.Size = new System.Drawing.Size(70, 25);
            this.labelUsuarioAdmin.TabIndex = 5;
            this.labelUsuarioAdmin.Text = "Correo:";
            // 
            // labelcontrasenaAdmin
            // 
            this.labelcontrasenaAdmin.AutoSize = true;
            this.labelcontrasenaAdmin.Location = new System.Drawing.Point(152, 123);
            this.labelcontrasenaAdmin.Name = "labelcontrasenaAdmin";
            this.labelcontrasenaAdmin.Size = new System.Drawing.Size(105, 25);
            this.labelcontrasenaAdmin.TabIndex = 6;
            this.labelcontrasenaAdmin.Text = "Contraseña:";
            // 
            // tbUsuarioAdmin
            // 
            this.tbUsuarioAdmin.Location = new System.Drawing.Point(294, 63);
            this.tbUsuarioAdmin.Name = "tbUsuarioAdmin";
            this.tbUsuarioAdmin.Size = new System.Drawing.Size(302, 31);
            this.tbUsuarioAdmin.TabIndex = 7;
            // 
            // tbContrasenaAdmin
            // 
            this.tbContrasenaAdmin.Location = new System.Drawing.Point(294, 123);
            this.tbContrasenaAdmin.Name = "tbContrasenaAdmin";
            this.tbContrasenaAdmin.PasswordChar = '*';
            this.tbContrasenaAdmin.Size = new System.Drawing.Size(302, 31);
            this.tbContrasenaAdmin.TabIndex = 8;
            // 
            // botonLoginAdmin
            // 
            this.botonLoginAdmin.Location = new System.Drawing.Point(294, 229);
            this.botonLoginAdmin.Name = "botonLoginAdmin";
            this.botonLoginAdmin.Size = new System.Drawing.Size(153, 37);
            this.botonLoginAdmin.TabIndex = 9;
            this.botonLoginAdmin.Text = "Iniciar sesión";
            this.botonLoginAdmin.Click += new System.EventHandler(this.botonLoginAdmin_Click);
            // 
            // linkAtras
            // 
            this.linkAtras.AutoSize = true;
            this.linkAtras.Location = new System.Drawing.Point(48, 400);
            this.linkAtras.Name = "linkAtras";
            this.linkAtras.Size = new System.Drawing.Size(53, 25);
            this.linkAtras.TabIndex = 10;
            this.linkAtras.TabStop = true;
            this.linkAtras.Text = "Atras";
            this.linkAtras.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAtras_LinkClicked);
            // 
            // CuentaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkAtras);
            this.Controls.Add(this.labelUsuarioAdmin);
            this.Controls.Add(this.labelcontrasenaAdmin);
            this.Controls.Add(this.tbUsuarioAdmin);
            this.Controls.Add(this.tbContrasenaAdmin);
            this.Controls.Add(this.botonLoginAdmin);
            this.Name = "CuentaAdministrador";
            this.Text = "CuentaAdministrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelUsuarioAdmin;
        private Label labelcontrasenaAdmin;
        private TextBox tbUsuarioAdmin;
        private TextBox tbContrasenaAdmin;
        private Button botonLoginAdmin;
        private LinkLabel linkAtras;
    }
}