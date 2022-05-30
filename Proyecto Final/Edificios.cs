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
    public partial class Edificios : Form
    {
        E_Entidad entidadd = new E_Entidad();
        E_Negocio nego = new E_Negocio();
        public Edificios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entidadd.Edificio = textBox1.Text;
            nego.insertarEdificio(entidadd);
            MessageBox.Show("Datos Insertados");
            ver();
        }

        private void Edificios_Load(object sender, EventArgs e)
        {
            ver();
        }
        void ver()
        {
            DataTable dt = nego.verEdificios(entidadd);
            dataGridView1.DataSource = dt;
        }

        
    }
}
