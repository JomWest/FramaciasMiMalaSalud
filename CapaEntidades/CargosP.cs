using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public partial class Cargos
    {
        public Cargos( int IdCargo, string NombreCargo)
        {
            this.IdCargo = IdCargo;
            this.NombreCargo = NombreCargo;
        }
    }
}
