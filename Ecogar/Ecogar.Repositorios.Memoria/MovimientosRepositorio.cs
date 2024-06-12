using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecogar.Entidades.Interfaces.Movimientos;
using Ecogar.Entidades.POCOs;

namespace Ecogar.Repositorios.Memoria
{
    public class MovimientosRepositorio :
        ICrearMovimiento
    {
        private readonly List<Movimiento> _data;
        private int _idCounter;

        public MovimientosRepositorio()
        {
            _data = new List<Movimiento>();
            _idCounter = 0;
        }

        public Movimiento Crear(Movimiento movimiento)
        {
            movimiento.Id = ++_idCounter;
            _data.Add(movimiento);
            return movimiento;
        }
    }
}
