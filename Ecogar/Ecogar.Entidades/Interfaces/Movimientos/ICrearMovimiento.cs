using Ecogar.Entidades.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecogar.Entidades.Interfaces.Movimientos
{
    public interface ICrearMovimiento
    {
        Movimiento Crear(Movimiento movimiento);
    }
}
