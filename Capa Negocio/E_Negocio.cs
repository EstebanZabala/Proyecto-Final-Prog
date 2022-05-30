using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;
using System.Data;
using System.Windows.Forms;

namespace Capa_Negocio
{
    public class E_Negocio
    {
        E_Datos obj = new E_Datos();
        public DataTable login(E_Entidad entid)
        {
            return obj.login(entid);
        }

        public void Visitas2(E_Entidad visitas2 )
        {
            obj.Visitas2(visitas2);
        }

        public void ConsultarEdificio (ComboBox cb)
        {
            obj.ConsultarEdificio(cb);

        }

        public void AñadirUsuario (E_Entidad entidadd)
        {
            obj.AñadirUsuario(entidadd);
        }
        public DataTable ConsultarVisitas(E_Entidad entidadd)
        {
            return obj.ConsultarVisitas(entidadd);
        }
        public void insertarEdificio(E_Entidad entidadd)
        {
            obj.insertarEdificio(entidadd);
        }
        public DataTable verEdificios(E_Entidad entidadd)
        {
            return obj.verEdificio(entidadd);
        }
       
    }
}
