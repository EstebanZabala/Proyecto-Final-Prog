using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Entidad;

namespace Proyecto_Final
{
    public partial class Registrar : Form
    {
        E_Entidad obj = new E_Entidad();
        E_Negocio obj1 = new E_Negocio();

        public Registrar()
        {
            InitializeComponent();
            obj1.ConsultarEdificio(combo1);
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void Register_Click(object sender, EventArgs e)
        {
            obj.Nombre = txt1.Text;
            obj.Apellido = txt2.Text;
            obj.Correo = txt3.Text;
            obj.Carrera = tx4.Text;
            obj.Edificio = combo1.Text;
            obj.Motivo = txt5.Text;
            obj.Aula = txt6.Text;

            obj.Hora = Time1.Text;
            
            obj1.Visitas2(obj);
            MessageBox.Show("Datos Insertados");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
