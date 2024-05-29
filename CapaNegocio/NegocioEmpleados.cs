using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Windows.Forms;
using System.Data.Entity;

namespace CapaNegocio
{
    public class NegocioEmpleados
    {

        DBFARMMSEntities db = new DBFARMMSEntities();

        #region Empleados
        public void NuevoEmpleado(int IdEmpleado, string NombreEmpleado, string CédulaEmpleado, int TeléfonoEmpleado, string Email, string DirecciónEmpleado, int IdCargo, string Género, string Usuario, string Contraseña)
        {
           
                using(db = new DBFARMMSEntities())
                {
                    Empleados empleados = new Empleados();
                    db.Empleados.Add(new Empleados(IdEmpleado, NombreEmpleado, CédulaEmpleado, TeléfonoEmpleado, Email, DirecciónEmpleado, IdCargo, Género, Usuario, Contraseña));
                    db.SaveChanges();
                }
     
        }

        public List<Empleados> LeerDatos()
        {
         
                using (db = new DBFARMMSEntities())
                {
                    var result = (from _Empleados in db.Empleados.OfType<Empleados>() select _Empleados).ToList();
                    return result;
                }
     
        }
        #endregion

        #region Cargo

        public List<spobteneridCargo_Result> obtehneridcargo()
        {
            try
            {
                using (db = new DBFARMMSEntities())
                {
                    var result = db.spobteneridCargo();
                    return result.ToList();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }


        public void NuevoCargo(int IdCargo, string NombreCargo)
        {
            try
            {
                using (db = new DBFARMMSEntities())
                {
                    Cargos empleados = new Cargos();
                    db.Cargos.Add(new Cargos( IdCargo,  NombreCargo));
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion
    }


}
