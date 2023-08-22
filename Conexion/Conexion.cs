using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Conexionusers
{
    public class Conexion
    {
        private string cadenaConexion = "Data Source=DESKTOP-N289EAT;Initial Catalog=BibliotecaUsers;Integrated Security=True";

        public SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            return conexion;
        }

        public void InsertarUsuario(string correo, string nombres, string apellidos, string contrasena, string direccion, string telefono)
        {
            using (SqlConnection conexion = ObtenerConexion()) 
            {
                string consulta = "INSERT INTO Usuarios (Correo, Nombres, Apellidos, Contrasena, Direccion, Telefono) " +
                                  "VALUES (@Correo, @Nombres, @Apellidos, @Contrasena, @Direccion, @Telefono)";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Correo", correo);
                    comando.Parameters.AddWithValue("@Nombres", nombres);
                    comando.Parameters.AddWithValue("@Apellidos", apellidos);
                    comando.Parameters.AddWithValue("@Contrasena", contrasena);
                    comando.Parameters.AddWithValue("@Direccion", direccion);
                    comando.Parameters.AddWithValue("@Telefono", telefono);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
        public void InsertarLibro(string isbn, string titulo, string autor, string genero, string descripcion, DateTime publicacion, string editor, int paginas, bool disponibilidad)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                string consulta = "INSERT INTO Libros (ISBN, Titulo, Autor, Genero, Descripcion, Publicacion, Editor, Paginas, Disponibilidad) " +
                                  "VALUES (@ISBN, @Titulo, @Autor, @Genero, @Descripcion, @Publicacion, @Editor, @Paginas, @Disponibilidad)";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@ISBN", isbn);
                    comando.Parameters.AddWithValue("@Titulo", titulo);
                    comando.Parameters.AddWithValue("@Autor", autor);
                    comando.Parameters.AddWithValue("@Genero", genero);
                    comando.Parameters.AddWithValue("@Descripcion", descripcion);
                    comando.Parameters.AddWithValue("@Publicacion", publicacion);
                    comando.Parameters.AddWithValue("@Editor", editor);
                    comando.Parameters.AddWithValue("@Paginas", paginas);
                    comando.Parameters.AddWithValue("@Disponibilidad", disponibilidad);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
