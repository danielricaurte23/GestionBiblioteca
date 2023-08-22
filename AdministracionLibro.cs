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
using Conexionusers;

namespace ProyectoDiseñoSoft
{
    public partial class AdministracionLibro : Form
    {
        private Conexion conexion = new Conexion();
        public AdministracionLibro()
        {
            InitializeComponent();
            MostrarLibrosEnDataGridView();
        }

        private void linkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Administrador administradorForm = new Administrador();
            administradorForm.Show();
            this.Close();
        }

        private void botonCrearLibro_Click(object sender, EventArgs e)
        {
            string isbn = tbISBN.Text;
            string titulo = tbTitulo.Text;
            string autor = tbAutor.Text;
            string genero = tbGenero.Text;
            string descripcion = tbDescripcion.Text;
            DateTime publicacion = dtpPublicacion.Value;
            string editor = tbEditor.Text;
            int paginas = Convert.ToInt32(tbPagina.Text);
            bool disponibilidad = cbDisponibilidad.Checked;

            conexion.InsertarLibro(isbn, titulo, autor, genero, descripcion, publicacion, editor, paginas, disponibilidad);

            LimpiarCampos();
            MostrarLibrosEnDataGridView();

            MessageBox.Show("Libro guardado exitosamente.");
        }

        private void dgvLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void MostrarLibrosEnDataGridView()
        {
            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                string consulta = "SELECT ISBN, Titulo, Autor, Genero, Descripcion, Publicacion, Editor, Paginas, Disponibilidad FROM Libros";
                using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
                {
                    sqlConnection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvLibro.DataSource = dataTable;
                }
            }
        }

        private void LimpiarCampos()
        {
            tbISBN.Text = "";
            tbTitulo.Text = "";
            tbAutor.Text = "";
            tbGenero.Text = "";
            tbDescripcion.Text = "";
            dtpPublicacion.Value = DateTime.Now;
            tbEditor.Text = "";
            tbPagina.Text = "";
            cbDisponibilidad.Checked = false;
        }

        private void botonEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibro.SelectedRows.Count > 0)
            {
                DialogResult confirmResult = MessageBox.Show("¿Seguro que quiere eliminar?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    int rowIndex = dgvLibro.SelectedRows[0].Index;
                    string isbn = dgvLibro.Rows[rowIndex].Cells[0].Value.ToString();

                    // Eliminar el libro de la base de datos
                    EliminarLibro(isbn);

                    MostrarLibrosEnDataGridView(); // Actualiza la vista

                    MessageBox.Show("Libro eliminado exitosamente.");
                }
            }
        }
        private void EliminarLibro(string isbn)
        {
            Conexion conexion = new Conexion();

            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                string consulta = "DELETE FROM Libros WHERE ISBN = @ISBN";
                using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@ISBN", isbn);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

    }
}