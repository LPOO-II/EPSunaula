using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasEpsUNAULA
{
    public class clsVerificar
    {
        clsBdConnection miConexion = new clsBdConnection();
        public int PacienteID { get; set; }
        public int MedicoID { get; set; }
        public string Nombre { get; set; }

        public clsVerificar() { }

        public clsVerificar(int PacienteID, int MedicoID, string Nombre)
        {
            this.PacienteID = PacienteID;
            this.MedicoID = MedicoID;
            this.Nombre = Nombre;
        }

        public bool VerificarPaciente()
        {
            SqlConnection conexionOpen = miConexion.AbrirConexion();
            string sql = "SELECT PacienteID, Nombre FROM Pacientes WHERE PacienteID = @PacienteID AND Nombre = @Nombre";
            SqlCommand cmd = new SqlCommand(sql, conexionOpen);
            cmd.Parameters.AddWithValue("@PacienteID", PacienteID);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            SqlDataReader dataReader = cmd.ExecuteReader();
            return dataReader.Read();
        }

        public bool VerificarMedico()
        {
            SqlConnection conexionOpen = miConexion.AbrirConexion();
            string sql = "SELECT MedicoID, Nombre FROM Medicos WHERE MedicoID = @MedicoID AND Nombre = @Nombre";
            SqlCommand cmd = new SqlCommand(sql, conexionOpen);
            cmd.Parameters.AddWithValue("@MedicoID", MedicoID);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            SqlDataReader dataReader = cmd.ExecuteReader();
            return dataReader.Read();
        }

    }
}
