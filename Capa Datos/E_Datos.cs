using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Capa_Datos
{
    public class E_Datos
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString);
        SqlCommand cmd;

        public DataTable login(E_Entidad entid)
        {
            con.Open();


            cmd = new SqlCommand("loguin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", entid.user);
            cmd.Parameters.AddWithValue("@contra", entid.contra);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }

        public void Visitas2(E_Entidad entidadd)
        {
            con.Open();
            cmd = new SqlCommand("visita2", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Nombre", entidadd.Nombre));
            cmd.Parameters.Add(new SqlParameter("@Apellido", entidadd.Apellido));
            cmd.Parameters.Add(new SqlParameter("@Carrera", entidadd.Carrera));
            cmd.Parameters.Add(new SqlParameter("@Correo", entidadd.Correo));
            cmd.Parameters.Add(new SqlParameter("@Edificio", entidadd.Edificio));
            cmd.Parameters.Add(new SqlParameter("@Hora", entidadd.Hora));
            cmd.Parameters.Add(new SqlParameter("@Motivo", entidadd.Motivo));
            cmd.Parameters.Add(new SqlParameter("@Aula", entidadd.Aula));

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ConsultarEdificio(ComboBox cb)
        {

            cb.Items.Clear();
            con.Open();
            cmd = new SqlCommand("ConsultaEdif", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[1].ToString());
            }
            con.Close();
            cb.Items.Insert(0, "Edificio");
            cb.SelectedIndex = 0;
        }

        public void AñadirUsuario(E_Entidad entidadd)
        {
            con.Open();

            cmd = new SqlCommand("RegistrarUsuario", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario", entidadd.user);
            cmd.Parameters.AddWithValue("@Contra", entidadd.contra);
            cmd.Parameters.AddWithValue("@TipoUsuario", entidadd.TipoUsuario);
            cmd.Parameters.AddWithValue("@Nombre", entidadd.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", entidadd.Apellido);
            cmd.Parameters.AddWithValue("@FechaN", entidadd.FechaN);
            cmd.ExecuteNonQuery();


      
            con.Close();
        }
        public DataTable ConsultarVisitas(E_Entidad entidadd)
        {
            cmd = new SqlCommand("visita4", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@edificio", entidadd.Edificio);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public void insertarEdificio(E_Entidad entidadd)
        {
            con.Open();
            cmd = new SqlCommand("insertarEdificio", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@edificio", entidadd.Edificio));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable verEdificio(E_Entidad entidadd)
        {
            cmd = new SqlCommand("ConsultaEdif", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
         
}
}
