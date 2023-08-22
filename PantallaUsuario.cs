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

namespace ProyectoGB
{
    public partial class PantallaUsuario : Form
    {
        public string CorreoUsuario { get; set; }
        public PantallaUsuario()
        {
            InitializeComponent();
        }

        private void linkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.Show();
            this.Close();
        }

        private void botonLibro_Click(object sender, EventArgs e)
        {
            Solicitud_Libro solicitudLibro = new Solicitud_Libro();
            solicitudLibro.CorreoUsuario = CorreoUsuario;
            solicitudLibro.Show();
            this.Close();
        }

        private void btEstado_Click(object sender, EventArgs e)
        {
            EstadoUsuario estadoUsuario = new EstadoUsuario(CorreoUsuario);
            estadoUsuario.Show();
            this.Close();
        }
    }
}
