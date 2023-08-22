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
    public partial class EstadoUsuario : Form
    {
        private Conexion conexion = new Conexion();
        public string CorreoUsuario { get; set; }

        public EstadoUsuario(string correoUsuario)
        {
            InitializeComponent();
            CorreoUsuario = correoUsuario;
            CargarEstadoCuenta();
        }


        private void linkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PantallaUsuario usuario = new PantallaUsuario();
             usuario.Show();
             this.Close();
        }

        private void CargarEstadoCuenta()
        {
            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                string consulta = "SELECT Titulo, FechaInicio, FechaFin, Precio FROM SolicitudesLibros";
                using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
                {
                    sqlConnection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvEstado.DataSource = dataTable;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEstado.SelectedRows.Count > 0)
            {
                DialogResult confirmResult = MessageBox.Show("¿Está seguro que desea quitarlo de su lista?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    int rowIndex = dgvEstado.SelectedRows[0].Index;
                    string tituloLibro = dgvEstado.Rows[rowIndex].Cells["Titulo"].Value.ToString();

                    EliminarRegistro(tituloLibro);

                    dgvEstado.Rows.RemoveAt(rowIndex);

                    MessageBox.Show("Registro eliminado exitosamente.");
                }
            }
        }

        private void EliminarRegistro(string tituloLibro)
        {
            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                string consulta = "DELETE FROM SolicitudesLibros WHERE Titulo = @Titulo";
                using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@Titulo", tituloLibro);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
