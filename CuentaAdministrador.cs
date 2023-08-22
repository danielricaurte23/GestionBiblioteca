using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Data.SqlClient;
using Conexionusers;

namespace ProyectoDiseñoSoft
{
    public partial class CuentaAdministrador : Form
    {
        public CuentaAdministrador()
        {
            InitializeComponent();
        }

        private void linkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Para retoceder a Inicio Sesion
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.Show();
            this.Close(); 
        }

        private void botonLoginAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                string usuarioAdmin = tbUsuarioAdmin.Text;
                string contrasenaAdmin = tbContrasenaAdmin.Text;

                bool inicioSesionAdminExitoso = ValidarInicioSesion(usuarioAdmin, contrasenaAdmin, "Admins");

                MostrarMensajeInicioSesion(inicioSesionAdminExitoso, "Admins");
            }
            catch (Exception ex)
            {
                MostrarErrorInicioSesion(ex);
            }
        }

        private bool ValidarInicioSesion(string usuario, string contrasena, string tipo)
        {
            using (SqlConnection conexion = new Conexion().ObtenerConexion())
            {
                string consulta = "SELECT COUNT(*) FROM Admins WHERE Correo = @correo AND Contrasena = @Contrasena";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@correo", usuario);
                    comando.Parameters.AddWithValue("@Contrasena", contrasena);

                    conexion.Open();
                    int cantidadAdmins = (int)comando.ExecuteScalar();

                    return cantidadAdmins > 0;
                }
            }
        }

        private void RedirigirAAdministrador()
        {
         
            Administrador administradorForm = new Administrador();
            administradorForm.Show();
            this.Close();
        }

        private void MostrarMensajeInicioSesion(bool exitoso, string tipo)
        {
            if (exitoso)
            {
                MessageBox.Show($"Inicio de sesión exitoso como {tipo}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (tipo == "Admins")
                {
                    RedirigirAAdministrador();
                }
            }
            else
            {
                MessageBox.Show("Datos de inicio de sesión incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarErrorInicioSesion(Exception ex)
        {
            MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}