using Conexionusers;
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
    public partial class Solicitud_Libro : Form
    {
        private Conexion conexion = new Conexion();
        public string CorreoUsuario { get; set; }
        public Solicitud_Libro()
        {
            InitializeComponent();
            CargarLibros();
        }

        private void CargarLibros()
        {
            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                string consulta = "SELECT Titulo FROM Libros WHERE Titulo NOT IN (SELECT Titulo FROM SolicitudesLibros)";
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CalcularPrecioReserva();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            {
                string tituloLibro = cbLibro.SelectedItem.ToString();
                DateTime fechaInicio = dtFechaInicio.Value;
                DateTime fechaFin = dateTimePicker1.Value;
                int diferenciaDias = (int)(fechaFin - fechaInicio).TotalDays;

                if (diferenciaDias >= 0)
                {
                    decimal precio = 3 + (diferenciaDias - 1); // $3 por el primer día, $1 por día adicional


                    InsertarSolicitud(tituloLibro, fechaInicio, fechaFin, precio, CorreoUsuario);

                    MessageBox.Show("Solicitud agregada correctamente.");
                }
                else
                {
                    MessageBox.Show("Fechas inválidas.");
                }
            }
        }


        private void CalcularPrecioReserva()
        {
            DateTime fechaInicio = dtFechaInicio.Value;
            DateTime fechaFin = dateTimePicker1.Value;

            int diferenciaDias = (int)(fechaFin - fechaInicio).TotalDays;

            if (diferenciaDias >= 0)
            {
                int precio = 6 + (diferenciaDias - 1); // $5 por el primer día, $1 por día adicional
                string precioFormateado = precio.ToString("0.00");
                lbPrecio.Text = $"Precio: ${precioFormateado}";
            }
            else
            {
                lbPrecio.Text = "Fechas inválidas";
            }
        }

        private void InsertarSolicitud(string tituloLibro, DateTime fechaInicio, DateTime fechaFin, decimal precio, string correoUsuario)
        {
            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                string consulta = "INSERT INTO SolicitudesLibros (Titulo, FechaInicio, FechaFin, Precio, CorreoUsuario) " +
                                  "VALUES (@Titulo, @FechaInicio, @FechaFin, @Precio, @CorreoUsuario)";
                using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@Titulo", tituloLibro);
                    sqlCommand.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    sqlCommand.Parameters.AddWithValue("@FechaFin", fechaFin);
                    sqlCommand.Parameters.AddWithValue("@Precio", precio);
                    sqlCommand.Parameters.AddWithValue("@CorreoUsuario", correoUsuario);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        private void linkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PantallaUsuario pantallaprin = new PantallaUsuario();
            pantallaprin.Show();
            this.Close();
        }
    }
}
