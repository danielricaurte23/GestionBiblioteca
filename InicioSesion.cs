using Conexionusers;
using ProyectoGB;
using System.Data.SqlClient;

namespace ProyectoDiseñoSoft
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            linkCrear.LinkClicked += linkCrearCuenta_LinkClicked;
            linkAdministrador.LinkClicked += linkAdministrador_LinkClicked;
        }

        private void linkCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Para abrir el formulario CrearCuenta
            CrearCuenta crearCuenta = new CrearCuenta();
            crearCuenta.Show();
            this.Hide();
        }

        private void linkAdministrador_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Para abrir el formulario CuentaAdministrador
            CuentaAdministrador cuentaAdministrador = new CuentaAdministrador();
            cuentaAdministrador.Show();
            this.Hide();

        }

        private void botonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string correoUsuario = tbUsuario.Text;
                string contrasenaUsuario = tbContrasena.Text;

                if (!string.IsNullOrWhiteSpace(correoUsuario) && !string.IsNullOrWhiteSpace(contrasenaUsuario))
                {
                    bool inicioSesionUsuarioExitoso = ValidarInicioSesionUsuario(correoUsuario, contrasenaUsuario);

                    if (inicioSesionUsuarioExitoso)
                    {
                        MessageBox.Show("Inicio de sesión exitoso como usuario.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PantallaUsuario usuario = new PantallaUsuario();
                        usuario.CorreoUsuario = correoUsuario;
                        usuario.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Datos de inicio de sesión incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese el correo y la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MostrarErrorInicioSesion("Error en la conexión a la base de datos.");
            }
            catch (Exception ex)
            {
                MostrarErrorInicioSesion(ex.Message);
            }
        }

        private bool ValidarInicioSesionUsuario(string correo, string contrasena)
        {
            using (SqlConnection conexion = new Conexion().ObtenerConexion())
            {
                string consulta = "SELECT COUNT(*) FROM Usuarios WHERE Correo = @Correo AND Contrasena = @Contrasena";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Correo", correo);
                    comando.Parameters.AddWithValue("@Contrasena", contrasena);

                    conexion.Open();
                    int cantidadUsuarios = (int)comando.ExecuteScalar();

                    return cantidadUsuarios > 0;
                }
            }
        }

        private void MostrarErrorInicioSesion(string mensaje)
        {
            MessageBox.Show($"Error al iniciar sesión: {mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}