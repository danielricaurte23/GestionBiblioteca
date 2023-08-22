namespace ProyectoDiseñoSoft
{
    partial class InicioSesion
    {
        private System.ComponentModel.IContainer components = null;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelUsuario = new Label();
            labelcontrasena = new Label();
            tbUsuario = new TextBox();
            tbContrasena = new TextBox();
            botonLogin = new Button();
            linkCrear = new LinkLabel();
            linkAdministrador = new LinkLabel();
            SuspendLayout();
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(61, 33);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(70, 25);
            labelUsuario.TabIndex = 0;
            labelUsuario.Text = "Correo:";
            // 
            // labelcontrasena
            // 
            labelcontrasena.AutoSize = true;
            labelcontrasena.Location = new Point(50, 87);
            labelcontrasena.Name = "labelcontrasena";
            labelcontrasena.Size = new Size(105, 25);
            labelcontrasena.TabIndex = 1;
            labelcontrasena.Text = "Contraseña:";
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(238, 30);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(238, 31);
            tbUsuario.TabIndex = 2;
            // 
            // tbContrasena
            // 
            tbContrasena.Location = new Point(238, 87);
            tbContrasena.Name = "tbContrasena";
            tbContrasena.PasswordChar = '*';
            tbContrasena.Size = new Size(238, 31);
            tbContrasena.TabIndex = 3;
            // 
            // botonLogin
            // 
            botonLogin.Location = new Point(220, 183);
            botonLogin.Name = "botonLogin";
            botonLogin.Size = new Size(153, 37);
            botonLogin.TabIndex = 4;
            botonLogin.Text = "Iniciar sesión";
            botonLogin.Click += botonLogin_Click;
            // 
            // linkCrear
            // 
            linkCrear.AutoSize = true;
            linkCrear.Location = new Point(27, 280);
            linkCrear.Name = "linkCrear";
            linkCrear.Size = new Size(110, 25);
            linkCrear.TabIndex = 5;
            linkCrear.TabStop = true;
            linkCrear.Text = "Crear cuenta";
            // 
            // linkAdministrador
            // 
            linkAdministrador.AutoSize = true;
            linkAdministrador.Location = new Point(376, 280);
            linkAdministrador.Name = "linkAdministrador";
            linkAdministrador.Size = new Size(242, 25);
            linkAdministrador.TabIndex = 6;
            linkAdministrador.TabStop = true;
            linkAdministrador.Text = "Acceder como administrador";
            // 
            // InicioSesion
            // 
            ClientSize = new Size(630, 332);
            Controls.Add(labelUsuario);
            Controls.Add(labelcontrasena);
            Controls.Add(tbUsuario);
            Controls.Add(tbContrasena);
            Controls.Add(botonLogin);
            Controls.Add(linkCrear);
            Controls.Add(linkAdministrador);
            Name = "InicioSesion";
            Text = "Inicio de Sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelUsuario;
        private Label labelcontrasena;
        private TextBox tbUsuario;
        private TextBox tbContrasena;
        private Button botonLogin;
        private LinkLabel linkCrear;
        private LinkLabel linkAdministrador;
    }

    #endregion
}
