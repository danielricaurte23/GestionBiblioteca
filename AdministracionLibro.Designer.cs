namespace ProyectoDiseñoSoft
{
    partial class AdministracionLibro
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
            dtpPublicacion = new DateTimePicker();
            labelPublicacion = new Label();
            tbDescripcion = new TextBox();
            labelDisponibilidad = new Label();
            labelDescripcion = new Label();
            tbGenero = new TextBox();
            tbISBN = new TextBox();
            tbPagina = new TextBox();
            tbEditor = new TextBox();
            labelIsbn = new Label();
            labelPagina = new Label();
            labelEditor = new Label();
            linkAtras = new LinkLabel();
            botonEliminarLibro = new Button();
            botonCrearLibro = new Button();
            tbAutor = new TextBox();
            tbTitulo = new TextBox();
            labelGenero = new Label();
            labelAutor = new Label();
            labelTitulo = new Label();
            dgvLibro = new DataGridView();
            cbDisponibilidad = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvLibro).BeginInit();
            SuspendLayout();
            // 
            // dtpPublicacion
            // 
            dtpPublicacion.Location = new Point(444, 646);
            dtpPublicacion.Name = "dtpPublicacion";
            dtpPublicacion.Size = new Size(331, 31);
            dtpPublicacion.TabIndex = 75;
            // 
            // labelPublicacion
            // 
            labelPublicacion.AutoSize = true;
            labelPublicacion.Location = new Point(312, 647);
            labelPublicacion.Margin = new Padding(5, 0, 5, 0);
            labelPublicacion.Name = "labelPublicacion";
            labelPublicacion.Size = new Size(105, 25);
            labelPublicacion.TabIndex = 73;
            labelPublicacion.Text = "Publicación:";
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(151, 590);
            tbDescripcion.Margin = new Padding(5, 6, 5, 6);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(331, 31);
            tbDescripcion.TabIndex = 72;
            // 
            // labelDisponibilidad
            // 
            labelDisponibilidad.AutoSize = true;
            labelDisponibilidad.Location = new Point(525, 590);
            labelDisponibilidad.Margin = new Padding(5, 0, 5, 0);
            labelDisponibilidad.Name = "labelDisponibilidad";
            labelDisponibilidad.Size = new Size(131, 25);
            labelDisponibilidad.TabIndex = 71;
            labelDisponibilidad.Text = "Disponibilidad:";
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Location = new Point(32, 593);
            labelDescripcion.Margin = new Padding(5, 0, 5, 0);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(108, 25);
            labelDescripcion.TabIndex = 70;
            labelDescripcion.Text = "Descripción:";
            // 
            // tbGenero
            // 
            tbGenero.Location = new Point(151, 539);
            tbGenero.Margin = new Padding(5, 6, 5, 6);
            tbGenero.Name = "tbGenero";
            tbGenero.Size = new Size(331, 31);
            tbGenero.TabIndex = 69;
            // 
            // tbISBN
            // 
            tbISBN.Location = new Point(666, 533);
            tbISBN.Margin = new Padding(5, 6, 5, 6);
            tbISBN.Name = "tbISBN";
            tbISBN.Size = new Size(331, 31);
            tbISBN.TabIndex = 68;
            // 
            // tbPagina
            // 
            tbPagina.Location = new Point(666, 483);
            tbPagina.Margin = new Padding(5, 6, 5, 6);
            tbPagina.Name = "tbPagina";
            tbPagina.Size = new Size(331, 31);
            tbPagina.TabIndex = 67;
            // 
            // tbEditor
            // 
            tbEditor.Location = new Point(666, 429);
            tbEditor.Margin = new Padding(5, 6, 5, 6);
            tbEditor.Name = "tbEditor";
            tbEditor.Size = new Size(331, 31);
            tbEditor.TabIndex = 66;
            // 
            // labelIsbn
            // 
            labelIsbn.AutoSize = true;
            labelIsbn.Location = new Point(562, 539);
            labelIsbn.Margin = new Padding(5, 0, 5, 0);
            labelIsbn.Name = "labelIsbn";
            labelIsbn.Size = new Size(54, 25);
            labelIsbn.TabIndex = 65;
            labelIsbn.Text = "ISBN:";
            // 
            // labelPagina
            // 
            labelPagina.AutoSize = true;
            labelPagina.Location = new Point(553, 483);
            labelPagina.Margin = new Padding(5, 0, 5, 0);
            labelPagina.Name = "labelPagina";
            labelPagina.Size = new Size(76, 25);
            labelPagina.TabIndex = 64;
            labelPagina.Text = "Páginas:";
            // 
            // labelEditor
            // 
            labelEditor.AutoSize = true;
            labelEditor.Location = new Point(553, 434);
            labelEditor.Margin = new Padding(5, 0, 5, 0);
            labelEditor.Name = "labelEditor";
            labelEditor.Size = new Size(63, 25);
            labelEditor.TabIndex = 63;
            labelEditor.Text = "Editor:";
            // 
            // linkAtras
            // 
            linkAtras.AutoSize = true;
            linkAtras.Location = new Point(1154, 647);
            linkAtras.Name = "linkAtras";
            linkAtras.Size = new Size(53, 25);
            linkAtras.TabIndex = 62;
            linkAtras.TabStop = true;
            linkAtras.Text = "Atras";
            linkAtras.LinkClicked += linkAtras_LinkClicked;
            // 
            // botonEliminarLibro
            // 
            botonEliminarLibro.Location = new Point(1048, 162);
            botonEliminarLibro.Margin = new Padding(5, 6, 5, 6);
            botonEliminarLibro.Name = "botonEliminarLibro";
            botonEliminarLibro.Size = new Size(167, 44);
            botonEliminarLibro.TabIndex = 61;
            botonEliminarLibro.Text = "Eliminar Libro";
            botonEliminarLibro.UseVisualStyleBackColor = true;
            botonEliminarLibro.Click += botonEliminarLibro_Click;
            // 
            // botonCrearLibro
            // 
            botonCrearLibro.Location = new Point(1048, 508);
            botonCrearLibro.Margin = new Padding(5, 6, 5, 6);
            botonCrearLibro.Name = "botonCrearLibro";
            botonCrearLibro.Size = new Size(167, 44);
            botonCrearLibro.TabIndex = 59;
            botonCrearLibro.Text = "Crear Libro";
            botonCrearLibro.UseVisualStyleBackColor = true;
            botonCrearLibro.Click += botonCrearLibro_Click;
            // 
            // tbAutor
            // 
            tbAutor.Location = new Point(151, 483);
            tbAutor.Margin = new Padding(5, 6, 5, 6);
            tbAutor.Name = "tbAutor";
            tbAutor.Size = new Size(331, 31);
            tbAutor.TabIndex = 58;
            // 
            // tbTitulo
            // 
            tbTitulo.Location = new Point(151, 429);
            tbTitulo.Margin = new Padding(5, 6, 5, 6);
            tbTitulo.Name = "tbTitulo";
            tbTitulo.Size = new Size(331, 31);
            tbTitulo.TabIndex = 57;
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(47, 539);
            labelGenero.Margin = new Padding(5, 0, 5, 0);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(73, 25);
            labelGenero.TabIndex = 56;
            labelGenero.Text = "Género:";
            // 
            // labelAutor
            // 
            labelAutor.AutoSize = true;
            labelAutor.Location = new Point(47, 486);
            labelAutor.Margin = new Padding(5, 0, 5, 0);
            labelAutor.Name = "labelAutor";
            labelAutor.Size = new Size(61, 25);
            labelAutor.TabIndex = 55;
            labelAutor.Text = "Autor:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(47, 432);
            labelTitulo.Margin = new Padding(5, 0, 5, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(60, 25);
            labelTitulo.TabIndex = 54;
            labelTitulo.Text = "Título:";
            // 
            // dgvLibro
            // 
            dgvLibro.AllowUserToAddRows = false;
            dgvLibro.AllowUserToDeleteRows = false;
            dgvLibro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibro.Location = new Point(38, 15);
            dgvLibro.Margin = new Padding(5, 6, 5, 6);
            dgvLibro.Name = "dgvLibro";
            dgvLibro.RowHeadersWidth = 51;
            dgvLibro.Size = new Size(1000, 385);
            dgvLibro.TabIndex = 53;
            dgvLibro.CellContentClick += dgvLibro_CellContentClick;
            // 
            // cbDisponibilidad
            // 
            cbDisponibilidad.AutoSize = true;
            cbDisponibilidad.Location = new Point(666, 589);
            cbDisponibilidad.Name = "cbDisponibilidad";
            cbDisponibilidad.Size = new Size(50, 29);
            cbDisponibilidad.TabIndex = 77;
            cbDisponibilidad.Text = "si";
            cbDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // AdministracionLibro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 689);
            Controls.Add(cbDisponibilidad);
            Controls.Add(dtpPublicacion);
            Controls.Add(labelPublicacion);
            Controls.Add(tbDescripcion);
            Controls.Add(labelDisponibilidad);
            Controls.Add(labelDescripcion);
            Controls.Add(tbGenero);
            Controls.Add(tbISBN);
            Controls.Add(tbPagina);
            Controls.Add(tbEditor);
            Controls.Add(labelIsbn);
            Controls.Add(labelPagina);
            Controls.Add(labelEditor);
            Controls.Add(linkAtras);
            Controls.Add(botonEliminarLibro);
            Controls.Add(botonCrearLibro);
            Controls.Add(tbAutor);
            Controls.Add(tbTitulo);
            Controls.Add(labelGenero);
            Controls.Add(labelAutor);
            Controls.Add(labelTitulo);
            Controls.Add(dgvLibro);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AdministracionLibro";
            Text = "Administración de Usuarios";
            ((System.ComponentModel.ISupportInitialize)dgvLibro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpPublicacion;
        private Label labelPublicacion;
        private TextBox tbDescripcion;
        private Label labelDisponibilidad;
        private Label labelDescripcion;
        private TextBox tbGenero;
        private TextBox tbISBN;
        private TextBox tbPagina;
        private TextBox tbEditor;
        private Label labelIsbn;
        private Label labelPagina;
        private Label labelEditor;
        private LinkLabel linkAtras;
        private Button botonEliminarLibro;
        private Button botonCrearLibro;
        private TextBox tbAutor;
        private TextBox tbTitulo;
        private Label labelGenero;
        private Label labelAutor;
        private Label labelTitulo;
        private DataGridView dgvLibro;
        private CheckBox cbDisponibilidad;
    }
}