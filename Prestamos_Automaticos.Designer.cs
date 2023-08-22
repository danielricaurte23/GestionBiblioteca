namespace ProyectoGB
{
    partial class Prestamos_Automaticos
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
            dateTimeFechaPrest = new DateTimePicker();
            dtpFechaPrestamo = new Label();
            txtNombreLibro = new Label();
            label1 = new Label();
            linkAtras = new LinkLabel();
            btnAceptar = new Button();
            lstPrestamos = new Label();
            lbUsuario = new Label();
            cbLibro = new ComboBox();
            SuspendLayout();
            // 
            // dateTimeFechaPrest
            // 
            dateTimeFechaPrest.Enabled = false;
            dateTimeFechaPrest.Location = new Point(257, 211);
            dateTimeFechaPrest.Margin = new Padding(4, 5, 4, 5);
            dateTimeFechaPrest.Name = "dateTimeFechaPrest";
            dateTimeFechaPrest.Size = new Size(430, 31);
            dateTimeFechaPrest.TabIndex = 16;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.AutoSize = true;
            dtpFechaPrestamo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpFechaPrestamo.Location = new Point(33, 211);
            dtpFechaPrestamo.Margin = new Padding(4, 0, 4, 0);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(214, 26);
            dtpFechaPrestamo.TabIndex = 12;
            dtpFechaPrestamo.Text = "Fecha del Préstamo";
            // 
            // txtNombreLibro
            // 
            txtNombreLibro.AutoSize = true;
            txtNombreLibro.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombreLibro.Location = new Point(50, 123);
            txtNombreLibro.Margin = new Padding(4, 0, 4, 0);
            txtNombreLibro.Name = "txtNombreLibro";
            txtNombreLibro.Size = new Size(197, 26);
            txtNombreLibro.TabIndex = 11;
            txtNombreLibro.Text = "Nombre del Libro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(278, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 41);
            label1.TabIndex = 10;
            label1.Text = "Prestamos ";
            // 
            // linkAtras
            // 
            linkAtras.AutoSize = true;
            linkAtras.Location = new Point(711, 491);
            linkAtras.Name = "linkAtras";
            linkAtras.Size = new Size(53, 25);
            linkAtras.TabIndex = 63;
            linkAtras.TabStop = true;
            linkAtras.Text = "Atras";
            linkAtras.LinkClicked += linkAtras_LinkClicked;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(316, 402);
            btnAceptar.Margin = new Padding(4, 5, 4, 5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(136, 38);
            btnAceptar.TabIndex = 19;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lstPrestamos
            // 
            lstPrestamos.AutoSize = true;
            lstPrestamos.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lstPrestamos.Location = new Point(97, 306);
            lstPrestamos.Margin = new Padding(4, 0, 4, 0);
            lstPrestamos.Name = "lstPrestamos";
            lstPrestamos.Size = new Size(93, 26);
            lstPrestamos.TabIndex = 13;
            lstPrestamos.Text = "Usuario";
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Location = new Point(257, 306);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(19, 25);
            lbUsuario.TabIndex = 64;
            lbUsuario.Text = "-";
            // 
            // cbLibro
            // 
            cbLibro.FormattingEnabled = true;
            cbLibro.Location = new Point(257, 116);
            cbLibro.Name = "cbLibro";
            cbLibro.Size = new Size(430, 33);
            cbLibro.TabIndex = 79;
            // 
            // Prestamos_Automaticos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 525);
            Controls.Add(cbLibro);
            Controls.Add(lbUsuario);
            Controls.Add(linkAtras);
            Controls.Add(btnAceptar);
            Controls.Add(dateTimeFechaPrest);
            Controls.Add(lstPrestamos);
            Controls.Add(dtpFechaPrestamo);
            Controls.Add(txtNombreLibro);
            Controls.Add(label1);
            Name = "Prestamos_Automaticos";
            Text = "Prestamos_Automaticos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAgregar;
        private Button btnEditar;
        private DateTimePicker dateTimeFechaPrest;
        private Label dtpFechaPrestamo;
        private Label txtNombreLibro;
        private Label label1;
        private LinkLabel linkAtras;
        private Button btnAceptar;
        private Label lstPrestamos;
        private Label lbUsuario;
        private ComboBox cbLibro;
    }
}