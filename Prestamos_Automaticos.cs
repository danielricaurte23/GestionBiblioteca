using Conexionusers;
using ProyectoDiseñoSoft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGB
{
    public partial class Prestamos_Automaticos : Form
    {
        private Conexion conexion = new Conexion();

        public Prestamos_Automaticos()
        {
            InitializeComponent();
            CargarTitulosLibros();
        }

        private void linkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Administrador administrador = new Administrador();
            administrador.Show();
            this.Hide();
        }

        private void CargarTitulosLibros()
        {
            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                string consulta = "SELECT Titulo FROM Libros";
                using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
                {
                    sqlConnection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        string tituloLibro = reader["Titulo"].ToString();
                        cbLibro.Items.Add(tituloLibro);
                    }
                }
            }
        }


        private (DateTime fechaInicio, string correoUsuario) ObtenerInfoSolicitud(string tituloLibro)
        {
            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                string consulta = "SELECT FechaInicio, CorreoUsuario FROM SolicitudesLibros WHERE Titulo = @Titulo";
                using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@Titulo", tituloLibro);
                    sqlConnection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        DateTime fechaInicio = Convert.ToDateTime(reader["FechaInicio"]);
                        string correoUsuario = reader["CorreoUsuario"].ToString();
                        return (fechaInicio, correoUsuario);
                    }
                    else
                    {
                        return (DateTime.MinValue, "Libro disponible");
                    }
                }
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cbLibro.SelectedItem != null)
            {
                string tituloLibro = cbLibro.SelectedItem.ToString();
                (DateTime fechaInicio, string correoUsuario) = ObtenerInfoSolicitud(tituloLibro);

                if (fechaInicio == DateTime.MinValue)
                {
                    lbUsuario.Text = "Libro disponible";
                    dateTimeFechaPrest.Text = string.Empty;
                }
                else
                {
                    (string nombreUsuario, string apellidoUsuario) = ObtenerNombreApellidoUsuario(correoUsuario);

                    lbUsuario.Text = $"{nombreUsuario} {apellidoUsuario}";
                    dateTimeFechaPrest.Text = fechaInicio.ToShortDateString();
                }
            }
        }
        private (string nombre, string apellido) ObtenerNombreApellidoUsuario(string correoUsuario)
        {
            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                string consulta = "SELECT Nombres, Apellidos FROM Usuarios WHERE Correo = @CorreoUsuario";
                using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@CorreoUsuario", correoUsuario);
                    sqlConnection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        string nombreUsuario = reader["Nombres"].ToString();
                        string apellidoUsuario = reader["Apellidos"].ToString();
                        return (nombreUsuario, apellidoUsuario);
                    }
                    else
                    {
                       
                        return ("", "");
                    }
                }
            }
        }
    }
}