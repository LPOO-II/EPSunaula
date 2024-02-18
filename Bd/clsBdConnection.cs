using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasEpsUNAULA
{
    public class clsBdConnection
    {

        private SqlConnection conexion;
        private string cadenaConexion = "server=DESKTOP-HTU55TU; database=EpsUnaula; integrated security=true";

        public clsBdConnection()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public SqlConnection AbrirConexion()
        {
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("ERROR EN LA CONEXION A LA BASE" + ex.Message);
                return null;
            }

            
        }

        public void CerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("ERROR AL CERRAR LA BASE DE DATOS " + ex.Message);
            }
        }
    }
}
