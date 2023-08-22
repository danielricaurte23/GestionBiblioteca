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

namespace ProyectoDiseñoSoft
{
    public partial class CrearCuenta : Form
    {
        public CrearCuenta()
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

        private void botonCrearCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén los valores de los campos del formulario
                string correo = tbCorreo.Text;
                string nombres = tbNombres.Text;
                string apellidos = tbApellidos.Text;
                string contrasena = tbContrasena.Text;
                string direccion = tbDireccion.Text;

                int telefono;

                if (!int.TryParse(tbTelefono.Text, out telefono))
                {
                    MessageBox.Show("Teléfono inválido. Debe ser un número entero.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llama a la función para insertar el usuario
                Conexion conexion = new Conexion();
                conexion.InsertarUsuario(correo, nombres, apellidos, contrasena, direccion, telefono.ToString()); // Convertir telefono a cadena

                MessageBox.Show("Usuario creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
