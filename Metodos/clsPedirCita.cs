using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitasEpsUNAULA
{
    public class clsPedirCita
    {
        clsBdConnection miConexion = new clsBdConnection();

        public int PacienteID { get; set; }
        public DateTime Fecha {  get; set; }
        public TimeSpan Hora { get; set; }

        public int MedicoID { get; set; }

        public bool IngresarCita()
        {
            SqlConnection conexionOpen = miConexion.AbrirConexion();
            string sqlVerificacion = "SELECT COUNT(*) FROM CitasMedicas WHERE Fecha = @Fecha AND Hora = @Hora AND MedicoID = @MedicoID AND PacienteID IS NOT NULL";
            SqlCommand cmdVerificacion = new SqlCommand(sqlVerificacion, conexionOpen);
            cmdVerificacion.Parameters.AddWithValue("@Fecha", Fecha);
            cmdVerificacion.Parameters.AddWithValue("@Hora", Hora);
            cmdVerificacion.Parameters.AddWithValue("@MedicoID", MedicoID);

            int citasExistentes = (int)cmdVerificacion.ExecuteScalar();

            if (citasExistentes > 0)
            {
                MessageBox.Show("Ya existe una cita programada en la misma fecha y hora con un paciente asignado.");
            }
            else
            {
                string sqlInsercion = "UPDATE CitasMedicas SET PacienteID = @PacienteID WHERE MedicoID = @MedicoID AND Fecha = @Fecha AND Hora = @Hora";
                SqlCommand cmdInsercion = new SqlCommand(sqlInsercion, conexionOpen);
                cmdInsercion.Parameters.AddWithValue("@Fecha", Fecha);
                cmdInsercion.Parameters.AddWithValue("@Hora", Hora);
                cmdInsercion.Parameters.AddWithValue("@MedicoID", MedicoID);
                cmdInsercion.Parameters.AddWithValue("@PacienteID", PacienteID);

                cmdInsercion.ExecuteNonQuery();
                MessageBox.Show("Cita programada con éxito.");
            }

            return true;
        }

        public DataTable ConsultarDispo()
        {
            SqlConnection conexionOpen = miConexion.AbrirConexion();
            DataTable dt = new DataTable();
            string sql = "SELECT Hora FROM CitasMedicas WHERE PacienteID IS NULL AND MedicoID = @MedicoID AND Fecha = @Fecha";
            SqlCommand cmd = new SqlCommand(sql, conexionOpen);
            cmd.Parameters.AddWithValue("@MedicoID", MedicoID);
            cmd.Parameters.AddWithValue("@Fecha", Fecha);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
