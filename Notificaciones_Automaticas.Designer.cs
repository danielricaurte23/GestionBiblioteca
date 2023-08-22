namespace ProyectoGB
{
    partial class Notificaciones_Automaticas
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
            dgvNotificacion = new DataGridView();
            tbMensaje = new TextBox();
            btnEliminar = new Button();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            linkAtras = new LinkLabel();
            comboBoxDestinatarios = new ComboBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvNotificacion).BeginInit();
            SuspendLayout();
            // 
            // dgvNotificacion
            // 
            dgvNotificacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotificacion.Location = new Point(21, 360);
            dgvNotificacion.Name = "dgvNotificacion";
            dgvNotificacion.RowHeadersWidth = 62;
            dgvNotificacion.RowTemplate.Height = 25;
            dgvNotificacion.Size = new Size(767, 128);
            dgvNotificacion.TabIndex = 17;
            // 
            // tbMensaje
            // 
            tbMensaje.Location = new Point(168, 87);
            tbMensaje.Name = "tbMensaje";
            tbMensaje.Size = new Size(556, 31);
            tbMensaje.TabIndex = 15;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(622, 270);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(122, 42);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(45, 270);
            button2.Name = "button2";
            button2.Size = new Size(122, 40);
            button2.TabIndex = 13;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 144);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 11;
            label3.Text = "Destinatario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 89);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 10;
            label2.Text = "Mensaje";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(292, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(241, 46);
            label1.TabIndex = 9;
            label1.Text = "Notificaciones ";
            // 
            // linkAtras
            // 
            linkAtras.AutoSize = true;
            linkAtras.Location = new Point(735, 515);
            linkAtras.Name = "linkAtras";
            linkAtras.Size = new Size(53, 25);
            linkAtras.TabIndex = 64;
            linkAtras.TabStop = true;
            linkAtras.Text = "Atras";
            linkAtras.LinkClicked += linkAtras_LinkClicked;
            // 
            // comboBoxDestinatarios
            // 
            comboBoxDestinatarios.FormattingEnabled = true;
            comboBoxDestinatarios.Location = new Point(168, 141);
            comboBoxDestinatarios.Name = "comboBoxDestinatarios";
            comboBoxDestinatarios.Size = new Size(556, 33);
            comboBoxDestinatarios.TabIndex = 65;
            comboBoxDestinatarios.SelectedIndexChanged += comboBoxDestinatarios_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 205);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 66;
            label4.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(168, 205);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(365, 31);
            dateTimePicker1.TabIndex = 67;
            // 
            // Notificaciones_Automaticas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 549);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(comboBoxDestinatarios);
            Controls.Add(linkAtras);
            Controls.Add(dgvNotificacion);
            Controls.Add(tbMensaje);
            Controls.Add(btnEliminar);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Notificaciones_Automaticas";
            Text = "Notificaciones";
            ((System.ComponentModel.ISupportInitialize)dgvNotificacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNotificacion;
        private TextBox tbMensaje;
        private Button btnEliminar;
        private Button button2;
        private Label label3;
        private Label label2;
        private Label label1;
        private LinkLabel linkAtras;
        private ComboBox comboBoxDestinatarios;
        private Label label4;
        private DateTimePicker dateTimePicker1;
    }
}