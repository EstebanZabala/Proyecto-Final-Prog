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
    public partial class Usuarios : Form
    {

        E_Entidad obj = new E_Entidad();

        E_Negocio obj1 = new E_Negocio();
        public Usuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            obj.user = textU1.Text;
            obj.contra = textU2.Text;
            obj.Nombre = textU4.Text;
            obj.Apellido = textU5.Text;
            obj.FechaN = dateTimePicker1.Text;
            obj.TipoUsuario = textU3.Text;
            obj1.AñadirUsuario(obj);
            MessageBox.Show("Usuario Creado");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
