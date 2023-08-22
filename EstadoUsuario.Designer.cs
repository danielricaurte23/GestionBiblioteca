namespace ProyectoGB
{
    partial class EstadoUsuario
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
            dgvEstado = new DataGridView();
            label1 = new Label();
            linkAtras = new LinkLabel();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEstado).BeginInit();
            SuspendLayout();
            // 
            // dgvEstado
            // 
            dgvEstado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstado.Location = new Point(12, 85);
            dgvEstado.Name = "dgvEstado";
            dgvEstado.RowHeadersWidth = 62;
            dgvEstado.RowTemplate.Height = 33;
            dgvEstado.Size = new Size(776, 318);
            dgvEstado.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(266, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(259, 41);
            label1.TabIndex = 65;
            label1.Text = "Estado de cuenta";
            // 
            // linkAtras
            // 
            linkAtras.AutoSize = true;
            linkAtras.Location = new Point(723, 467);
            linkAtras.Name = "linkAtras";
            linkAtras.Size = new Size(53, 25);
            linkAtras.TabIndex = 75;
            linkAtras.TabStop = true;
            linkAtras.Text = "Atras";
            linkAtras.LinkClicked += linkAtras_LinkClicked;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(337, 429);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(107, 38);
            btnEliminar.TabIndex = 77;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Estado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(btnEliminar);
            Controls.Add(linkAtras);
            Controls.Add(label1);
            Controls.Add(dgvEstado);
            Name = "Estado";
            Text = "Estado";
            ((System.ComponentModel.ISupportInitialize)dgvEstado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEstado;
        private Label label1;
        private LinkLabel linkAtras;
        private Button btnEliminar;
    }
}