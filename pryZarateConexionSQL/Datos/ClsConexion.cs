using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pryZarateConexionSQL.Datos
{
    public class ClsConexion
    {
        private SqlConnection conn;
        private string servidor;
        private string baseDatos;

        public bool EstaConectado
        {
            get { return conn != null && conn.State == ConnectionState.Open; }
        }

        public string Servidor { get { return servidor; } }
        public string BaseDatos { get { return baseDatos; } }

        public bool Conectar(string servidor, string baseDatos)
        {
            this.servidor = servidor;
            this.baseDatos = baseDatos;

            string cs = "Server=" + servidor +
                        ";Database=" + baseDatos +
                        ";Integrated Security=True;TrustServerCertificate=True;";
            try
            {
                CerrarConexion();
                conn = new SqlConnection(cs);
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable ObtenerBasesDeDatos()
        {
            string query = @"SELECT name
                             FROM sys.databases
                             WHERE database_id > 4
                             ORDER BY name";
            return Consultar(query);
        }

        public DataTable ObtenerTablas()
        {
            string query = @"SELECT TABLE_SCHEMA + '.' + TABLE_NAME AS NombreTabla
                             FROM INFORMATION_SCHEMA.TABLES
                             WHERE TABLE_TYPE = 'BASE TABLE'
                             ORDER BY TABLE_SCHEMA, TABLE_NAME";
            return Consultar(query);
        }

        public DataTable ObtenerDatosDeTabla(string nombreTabla)
        {
            string query = "SELECT * FROM " + nombreTabla;
            return Consultar(query);
        }

        private DataTable Consultar(string query)
        {
            DataTable tabla = new DataTable();
            if (!EstaConectado)
                return tabla;

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }

        public void CerrarConexion()
        {
            if (conn != null)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Dispose();
                conn = null;
            }
        }
    }
}
