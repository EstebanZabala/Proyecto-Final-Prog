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
    public partial class Form1 : Form
    {
        E_Entidad entid = new E_Entidad();
        E_Negocio nego = new E_Negocio();

        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            entid.user = txtuser.Text;
            entid.contra = txtContra.Text;
            dt = nego.login(entid);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][3].ToString() == "admin")
                {
                    MessageBox.Show("Bienvenido Administrador " + entid.user);
                    this.Hide();
                    new admin().Show();
                }
                else if (dt.Rows[0][3].ToString() == "usuario")
                {
                    MessageBox.Show("Buenas " + entid.user + " Digita los datos !");
                    this.Hide();
                    new Registrar().Show();
                }
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
