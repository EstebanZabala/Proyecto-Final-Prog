using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;

namespace Proyecto_Final
{
    public partial class VisitasAdmin : Form
    {
        E_Entidad entidadd = new E_Entidad();
        E_Negocio nego = new E_Negocio();
        public VisitasAdmin()
        {
            InitializeComponent();
            nego.ConsultarEdificio(comboBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            entidadd.Edificio = comboBox1.Text;
            sele();
        }
        void sele()
        {
            DataTable dt = nego.ConsultarVisitas(entidadd);
            dataGridView1.DataSource = dt;
        }
    }
}
