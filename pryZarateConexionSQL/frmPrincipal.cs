using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using pryZarateConexionSQL.Datos;

namespace pryZarateConexionSQL
{
    public partial class frmPrincipal : Form
    {
        private readonly ClsConexion conexion = new ClsConexion();
        private bool cargandoCombos = false;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string servidor = tbServidor.Text.Trim();
            if (string.IsNullOrEmpty(servidor))
            {
                MessageBox.Show("Ingresá el nombre del servidor.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!conexion.Conectar(servidor, "master"))
            {
                MarcarDesconectado();
                return;
            }

            MarcarConectado();
            CargarBasesDeDatos();
        }

        private void cmbBaseDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoCombos || cmbBaseDatos.SelectedItem == null)
                return;

            string bd = cmbBaseDatos.SelectedItem.ToString();
            if (!conexion.Conectar(tbServidor.Text.Trim(), bd))
            {
                MarcarDesconectado();
                return;
            }

            MarcarConectado();
            CargarTablas();
        }

        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoCombos || cmbTablas.SelectedItem == null)
                return;

            string tabla = cmbTablas.SelectedItem.ToString();
            DataTable datos = conexion.ObtenerDatosDeTabla(tabla);
            dgvDatos.DataSource = datos;

            int filas = datos != null ? datos.Rows.Count : 0;
            lblTablaActual.Text = tabla + "   ·   " + filas + " registros";
        }

        private void CargarBasesDeDatos()
        {
            DataTable bds = conexion.ObtenerBasesDeDatos();
            cargandoCombos = true;
            cmbBaseDatos.Items.Clear();
            cmbTablas.Items.Clear();
            cmbTablas.Enabled = false;
            if (bds != null)
            {
                foreach (DataRow fila in bds.Rows)
                    cmbBaseDatos.Items.Add(fila["name"].ToString());
            }
            cmbBaseDatos.Enabled = cmbBaseDatos.Items.Count > 0;
            cargandoCombos = false;
        }

        private void CargarTablas()
        {
            DataTable tablas = conexion.ObtenerTablas();
            cargandoCombos = true;
            cmbTablas.Items.Clear();
            dgvDatos.DataSource = null;
            if (tablas != null)
            {
                foreach (DataRow fila in tablas.Rows)
                    cmbTablas.Items.Add(fila["NombreTabla"].ToString());
            }
            cmbTablas.Enabled = cmbTablas.Items.Count > 0;
            lblTablaActual.Text = "Elegí una tabla del combo";
            cargandoCombos = false;
        }

        private void MarcarConectado()
        {
            lblEstado.Text = "● Conectado a " + conexion.BaseDatos;
            lblEstado.ForeColor = Color.FromArgb(76, 175, 80);
        }

        private void MarcarDesconectado()
        {
            lblEstado.Text = "● Desconectado";
            lblEstado.ForeColor = Color.FromArgb(231, 76, 60);
            cmbBaseDatos.Enabled = false;
            cmbTablas.Enabled = false;
            cmbBaseDatos.Items.Clear();
            cmbTablas.Items.Clear();
            dgvDatos.DataSource = null;
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            conexion.CerrarConexion();
        }
    }
}
