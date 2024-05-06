using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public partial class Empleados
    {
        public Empleados(int IdEmpleado, string NombreEmpleado, string CédulaEmpleado, int TeléfonoEmpleado,  string Email, string DirecciónEmpleado, int IdCargo ,string Género, string Usuario, string Contraseña)
        {
            this.IdEmpleado = IdEmpleado;
            this.NombreEmpleado = NombreEmpleado;
            this.CédulaEmpleado = CédulaEmpleado;
            this.TeléfonoEmpleado = TeléfonoEmpleado;
            this.Email = Email;
            this.DirecciónEmpleado = DirecciónEmpleado;
            this.IdCargo = IdCargo;
            this.Género = Género;
            this.Usuario = Usuario;
            this.Contraseña = Contraseña;


        }
     
    }
}
