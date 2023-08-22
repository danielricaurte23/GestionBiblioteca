namespace ProyectoGB
{
    partial class Solicitud_Libro
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
            lbPrecio = new Label();
            linkAtras = new LinkLabel();
            btnAgregar = new Button();
            dtFechaInicio = new DateTimePicker();
            lstPrestamos = new Label();
            dtpFechaPrestamo = new Label();
            txtNombreLibro = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            cbLibro = new ComboBox();
            SuspendLayout();
            // 
            // lbPrecio
            // 
            lbPrecio.AutoSize = true;
            lbPrecio.Location = new Point(294, 274);
            lbPrecio.Name = "lbPrecio";
            lbPrecio.Size = new Size(46, 25);
            lbPrecio.TabIndex = 74;
            lbPrecio.Text = "0.00";
            // 
            // linkAtras
            // 
            linkAtras.AutoSize = true;
            linkAtras.Location = new Point(713, 397);
            linkAtras.Name = "linkAtras";
            linkAtras.Size = new Size(53, 25);
            linkAtras.TabIndex = 73;
            linkAtras.TabStop = true;
            linkAtras.Text = "Atras";
            linkAtras.LinkClicked += linkAtras_LinkClicked;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(344, 363);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(107, 38);
            btnAgregar.TabIndex = 71;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dtFechaInicio
            // 
            dtFechaInicio.Enabled = false;
            dtFechaInicio.Location = new Point(294, 151);
            dtFechaInicio.Margin = new Padding(4, 5, 4, 5);
            dtFechaInicio.Name = "dtFechaInicio";
            dtFechaInicio.Size = new Size(430, 31);
            dtFechaInicio.TabIndex = 69;
            // 
            // lstPrestamos
            // 
            lstPrestamos.AutoSize = true;
            lstPrestamos.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lstPrestamos.Location = new Point(118, 273);
            lstPrestamos.Margin = new Padding(4, 0, 4, 0);
            lstPrestamos.Name = "lstPrestamos";
            lstPrestamos.Size = new Size(79, 26);
            lstPrestamos.TabIndex = 67;
            lstPrestamos.Text = "Precio";
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.AutoSize = true;
            dtpFechaPrestamo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpFechaPrestamo.Location = new Point(88, 155);
            dtpFechaPrestamo.Margin = new Padding(4, 0, 4, 0);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(167, 26);
            dtpFechaPrestamo.TabIndex = 66;
            dtpFechaPrestamo.Text = "Fecha de inicio";
            // 
            // txtNombreLibro
            // 
            txtNombreLibro.AutoSize = true;
            txtNombreLibro.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombreLibro.Location = new Point(70, 105);
            txtNombreLibro.Margin = new Padding(4, 0, 4, 0);
            txtNombreLibro.Name = "txtNombreLibro";
            txtNombreLibro.Size = new Size(197, 26);
            txtNombreLibro.TabIndex = 65;
            txtNombreLibro.Text = "Nombre del Libro";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(294, 205);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(430, 31);
            dateTimePicker1.TabIndex = 76;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(103, 210);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 26);
            label1.TabIndex = 75;
            label1.Text = "Fecha de fin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(290, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(288, 41);
            label2.TabIndex = 77;
            label2.Text = "Solicitud de Libros";
            // 
            // cbLibro
            // 
            cbLibro.FormattingEnabled = true;
            cbLibro.Location = new Point(294, 103);
            cbLibro.Name = "cbLibro";
            cbLibro.Size = new Size(430, 33);
            cbLibro.TabIndex = 78;
            // 
            // Solicitud_Libro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbLibro);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(lbPrecio);
            Controls.Add(linkAtras);
            Controls.Add(btnAgregar);
            Controls.Add(dtFechaInicio);
            Controls.Add(lstPrestamos);
            Controls.Add(dtpFechaPrestamo);
            Controls.Add(txtNombreLibro);
            Name = "Solicitud_Libro";
            Text = "Solicitud";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPrecio;
        private LinkLabel linkAtras;
        private Button btnAgregar;
        private DateTimePicker dtFechaInicio;
        private Label lstPrestamos;
        private Label dtpFechaPrestamo;
        private Label txtNombreLibro;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private ComboBox cbLibro;
    }
}