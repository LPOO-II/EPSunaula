using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasEpsUNAULA
{
    public class clsCancelarCita
    {
        public int CitaID { get; set; }
        
        public int PacienteID { get; set; }

        public int MedicoID { get; set; }
        public bool EliminarCita(int CitaID, int PacienteID)
        {
            clsBdConnection miConexion = new clsBdConnection();
            SqlConnection connection = miConexion.AbrirConexion();
            this.CitaID = CitaID;
            this.PacienteID = PacienteID;
            string sql = "DELETE FROM CitasMedicas WHERE CitaID = @CitaID AND PacienteID = @PacienteID";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@CitaID", CitaID);
            cmd.Parameters.AddWithValue("@PacienteID", PacienteID);


            cmd.ExecuteNonQuery();

            return true;
        }

        public bool EliminarCitaMedico(int CitaID, int MedicoID)
        {
            clsBdConnection miConexion = new clsBdConnection();
            SqlConnection connection = miConexion.AbrirConexion();
            this.CitaID = CitaID;
            this.MedicoID = MedicoID;
            string sql = "DELETE FROM CitasMedicas WHERE CitaID = @CitaID AND MedicoID = @MedicoID";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@CitaID", CitaID);
            cmd.Parameters.AddWithValue("@MedicoID", MedicoID);


            cmd.ExecuteNonQuery();

            return true;
        }
    }
}
