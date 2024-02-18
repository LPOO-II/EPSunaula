using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasEpsUNAULA
{
    public class clsConsultarCitas
    {
        clsBdConnection miConexion = new clsBdConnection();

        public int PacienteID { get; set; }
        public int MedicoID { get; set; }

        public DataTable ConsultarMiCita()
        {
            SqlConnection conexionOpen = miConexion.AbrirConexion();
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM CitasMedicas WHERE PacienteID = @PacienteID";
            SqlCommand cmd = new SqlCommand(sql, conexionOpen);
            cmd.Parameters.AddWithValue("@PacienteID", PacienteID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public DataTable ConsultarLaCita()
        {
            SqlConnection conexionOpen = miConexion.AbrirConexion();
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM CitasMedicas WHERE MedicoID = @MedicoID AND PacienteID IS NOT NULL";
            SqlCommand cmd = new SqlCommand(sql, conexionOpen);
            cmd.Parameters.AddWithValue("@MedicoID", MedicoID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public DataTable ConsultarHistorial()
        {
            SqlConnection conexionOpen = miConexion.AbrirConexion();
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Pacientes WHERE PacienteID = @PacienteID";
            SqlCommand cmd = new SqlCommand(sql, conexionOpen);
            cmd.Parameters.AddWithValue("@PacienteID", PacienteID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
