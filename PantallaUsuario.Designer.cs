namespace ProyectoGB
{
    partial class PantallaUsuario
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
            botonLibro = new Button();
            linkCerrarSesion = new LinkLabel();
            btEstado = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // botonLibro
            // 
            botonLibro.Location = new Point(165, 172);
            botonLibro.Margin = new Padding(5, 6, 5, 6);
            botonLibro.Name = "botonLibro";
            botonLibro.Size = new Size(250, 58);
            botonLibro.TabIndex = 10;
            botonLibro.Text = "Solicitar Libro";
            botonLibro.UseVisualStyleBackColor = true;
            botonLibro.Click += botonLibro_Click;
            // 
            // linkCerrarSesion
            // 
            linkCerrarSesion.AutoSize = true;
            linkCerrarSesion.Location = new Point(34, 390);
            linkCerrarSesion.Name = "linkCerrarSesion";
            linkCerrarSesion.Size = new Size(116, 25);
            linkCerrarSesion.TabIndex = 9;
            linkCerrarSesion.TabStop = true;
            linkCerrarSesion.Text = "Cerrar Sesión";
            linkCerrarSesion.LinkClicked += linkCerrarSesion_LinkClicked;
            // 
            // btEstado
            // 
            btEstado.Location = new Point(165, 282);
            btEstado.Margin = new Padding(5, 6, 5, 6);
            btEstado.Name = "btEstado";
            btEstado.Size = new Size(250, 58);
            btEstado.TabIndex = 8;
            btEstado.Text = "Estado de cuenta";
            btEstado.UseVisualStyleBackColor = true;
            btEstado.Click += btEstado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(165, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 41);
            label1.TabIndex = 11;
            label1.Text = "BIENVENIDO";
            // 
            // PantallaUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 450);
            Controls.Add(label1);
            Controls.Add(botonLibro);
            Controls.Add(linkCerrarSesion);
            Controls.Add(btEstado);
            Name = "PantallaUsuario";
            Text = "PantallaUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonLibro;
        private LinkLabel linkCerrarSesion;
        private Button btEstado;
        private Label label1;
    }
}