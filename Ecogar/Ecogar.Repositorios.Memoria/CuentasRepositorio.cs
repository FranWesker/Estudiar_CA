using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecogar.Entidades.Interfaces.Cuentas;
using Ecogar.Entidades.POCOs;

namespace Ecogar.Repositorios.Memoria
{
    public class CuentasRepositorio : 
        ICrearCuenta,
        IModificarCuenta,
        IBorrarCuenta,
        IListarCuentas
    {
        private readonly Dictionary<int, Cuenta> _data;
        private int _idCounter;

        public CuentasRepositorio()
        {
            _data = new Dictionary<int, Cuenta>();
            _idCounter = 0;
        }

        public Cuenta Crear(Cuenta cuenta)
        {
            cuenta.Id = ++_idCounter;
            _data.Add(cuenta.Id, cuenta);

            return cuenta;
        }

        public Cuenta Modificar(Cuenta cuenta)
        {
            if (!_data.ContainsKey(cuenta.Id))
                throw new Exception("Cuenta no encontrada");
            _data[cuenta.Id] = cuenta;

            return cuenta;
        }

        public Cuenta Borrar(Cuenta cuenta)
        {
            _data.Remove(cuenta.Id);

            return cuenta;
        }

        public ICollection<Cuenta> Listar()
        {
            return _data.Values;
        }
    }
}
