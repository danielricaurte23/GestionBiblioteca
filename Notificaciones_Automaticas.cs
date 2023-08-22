using ProyectoDiseñoSoft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexionusers;
using System.Data.SqlClient;

namespace ProyectoGB
{
    public partial class Notificaciones_Automaticas : Form
    {
        private Conexion conexion = new Conexion();
        public Notificaciones_Automaticas()
        {
            InitializeComponent();
            CargarDestinatarios();
            ConfigurarDataGridView();
            CargarMensajes();
        }

        private void ConfigurarDataGridView()
        {
            dgvNotificacion.AutoGenerateColumns = false; 

            dgvNotificacion.Columns.Add("ID", "ID");
            dgvNotificacion.Columns.Add("Destinatario", "Destinatario");
            dgvNotificacion.Columns.Add("Mensaje", "Mensaje");
            dgvNotificacion.Columns.Add("Fecha", "Fecha");
        }

        private void linkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Administrador administradorForm = new Administrador();
            administradorForm.Show();
            this.Close();
        }


        private void comboBoxDestinatarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDestinatarios();
        }

        private void CargarDestinatarios()
        {
            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                string consulta = "SELECT Nombres, Apellidos FROM Usuarios";
                using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
                {
                    sqlConnection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        string nombre = reader["Nombres"].ToString();
                        string apellido = reader["Apellidos"].ToString();
                        string nombreCompleto = $"{apellido}, {nombre}";
                        comboBoxDestinatarios.Items.Add(nombreCompleto);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxDestinatarios.SelectedItem == null || string.IsNullOrWhiteSpace(tbMensaje.Text))
            {
                MessageBox.Show("Por favor, seleccione un destinatario y escriba un mensaje.");
                return;
            }

            string destinatario = comboBoxDestinatarios.SelectedItem.ToString(); 
            string mensaje = tbMensaje.Text; 
            DateTime fecha = DateTime.Now; 

            int id = AgregarDestinatarioMensaje(destinatario, mensaje, fecha); 

            // Mostrar el registro en el DataGridView
            dgvNotificacion.Rows.Add(id, destinatario, mensaje, fecha);

            // Limpiar campos después de agregar
            comboBoxDestinatarios.SelectedIndex = -1;
            tbMensaje.Text = "";
        }
        private int AgregarDestinatarioMensaje(string destinatario, string mensaje, DateTime fecha)
        {
            int id;
            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                string consulta = "INSERT INTO DestinatarioMensaje (Destinatario, Mensaje, Fecha) " +
                                  "VALUES (@Destinatario, @Mensaje, @Fecha); SELECT SCOPE_IDENTITY()";
                using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@Destinatario", destinatario);
                    sqlCommand.Parameters.AddWithValue("@Mensaje", mensaje);
                    sqlCommand.Parameters.AddWithValue("@Fecha", fecha);

                    sqlConnection.Open();
                    id = Convert.ToInt32(sqlCommand.ExecuteScalar());
                }
            }
            return id;
        }
        private void CargarMensajes()
        {
            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                string consulta = "SELECT ID, Destinatario, Mensaje, Fecha FROM DestinatarioMensaje";
                using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
                {
                    sqlConnection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID"]);
                        string destinatario = reader["Destinatario"].ToString();
                        string mensaje = reader["Mensaje"].ToString();
                        DateTime fecha = Convert.ToDateTime(reader["Fecha"]);

                        dgvNotificacion.Rows.Add(id, destinatario, mensaje, fecha);
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvNotificacion.SelectedRows.Count > 0)
            {
                int rowIndex = dgvNotificacion.SelectedRows[0].Index;
                int mensajeID = Convert.ToInt32(dgvNotificacion.Rows[rowIndex].Cells[0].Value);

                EliminarDestinatarioMensaje(mensajeID);

                dgvNotificacion.Rows.RemoveAt(rowIndex);
            }
        }

        private void EliminarDestinatarioMensaje(int mensajeID)
        {
            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                string consulta = "DELETE FROM DestinatarioMensaje WHERE ID = @MensajeID";
                using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@MensajeID", mensajeID);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}