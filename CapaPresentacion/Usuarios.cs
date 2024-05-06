using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Usuarios : Form
    {
        //Intancia de la capa negocio
        NegocioEmpleados metodosempleados = new NegocioEmpleados();
        //Variables varias
        int IdEmpleado, idcargo;
        int TeléfonoEmpleado;
        int IdCargo;
        string Usuario, Contraseña, Género, DirecciónEmpleado, Email, CédulaEmpleado, NombreEmpleado, cargo;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            metodosempleados.NuevoCargo(idcargo,cargo);
            obteneridcargo();
            idcargo = 2;
            MessageBox.Show(Género);
            MessageBox.Show(idcargo.ToString());
            metodosempleados.NuevoEmpleado(IdEmpleado,NombreEmpleado,CédulaEmpleado,TeléfonoEmpleado,Email,DirecciónEmpleado,idcargo,Género,Usuario,Contraseña);
        }

        public Usuarios()
        {
            InitializeComponent();
            CargarDatos();       }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        public void CargarDatos()
        {
            var lista = metodosempleados.LeerDatos();
            dataUsuariio.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dataUsuariio.Rows.Add(lista[i].Usuario, lista[i].Contraseña, lista[i].NombreEmpleado, lista[i].CédulaEmpleado, lista[i].TeléfonoEmpleado, lista[i].Género);
            }
            dataUsuariio.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue;
        }

        public void obteneridcargo()
        {
            var lista = metodosempleados.obtehneridcargo();
            IdCargo = Convert.ToInt32(lista[0].Current_Identity);
        }
        public void CapturarDatos()
        {
            TeléfonoEmpleado = Convert.ToInt32(txtnumber.Text);
            NombreEmpleado = txtname.Text.Trim() + " " + txtlastname.Text.Trim();
            DirecciónEmpleado = txtaddres.Text.Trim();
            CédulaEmpleado = txtcedula.Text.Trim();
            if (rbF.Checked)
            {
                Género = "F";
            }
            else
            {
                Género = "M";
            }
            cargo = txtcargo.Text.Trim();
            Usuario = txtuser.Text.Trim();
            Contraseña = txtcontra.Text.Trim();
 
        }
    }
}
