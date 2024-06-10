using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecogar.Entidades.POCOs;

namespace Ecogar.Entidades.Interfaces.Cuentas
{
    public interface IListarCuentas
    {
        ICollection<Cuenta> Listar();
    }
}
