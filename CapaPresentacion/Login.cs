using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        menu home = new menu();
        SqlConnection conexion = new SqlConnection("server=AZAZYEL;" +
            "database=DBFARMMS; integrated security=true");
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarsesion_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "select * from Empleados where Usuario='" + txtUsuario.Text + "' and Contraseña='" + txtContraseña.Text + "'";
            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataReader Leer;

            try
            {

                Leer = comando.ExecuteReader();

                if (Leer.HasRows == true)
                {
                    Leer.Close();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario y la contraseña no coinciden");

                    conexion.Close();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("El usuario y contraseña no coinciden");
                conexion.Close();
            }
        }
    }
}
