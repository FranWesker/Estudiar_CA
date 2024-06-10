using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecogar.Entidades.POCOs;
using Ecogar.Entidades.Interfaces.Conceptos;

namespace Ecogar.Repositorios.Memoria
{
    public class ConceptosRepositorio :
        ICrearConcepto,
        IModificarConcepto,
        IBorrarConcepto,
        IListarConceptos
    {
        private readonly Dictionary<int, Concepto> _data;
        private int _idCounter;

        public ConceptosRepositorio()
        {
            _data = new Dictionary<int, Concepto>();
            _idCounter = 0;
        }

        public Concepto Crear(Concepto concepto)
        {
            concepto.Id = ++_idCounter;
            _data.Add(concepto.Id, concepto);
            return concepto;
        }

        public Concepto Modificar(Concepto concepto)
        {
            if (!_data.ContainsKey(concepto.Id))
                throw new Exception("Concepto no encontrado");
            _data[concepto.Id] = concepto;

            return concepto;
        }
        
        public Concepto Borrar(Concepto concepto)
        {
            _data.Remove(concepto.Id);
            return concepto;
        }

        public ICollection<Concepto> Listar()
        {
            return _data.Values;
        }
    }
}
