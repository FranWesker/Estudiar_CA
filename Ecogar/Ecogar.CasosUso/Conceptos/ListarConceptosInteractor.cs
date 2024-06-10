using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecogar.DTOs.Conceptos;
using Ecogar.Entidades.Interfaces.Conceptos;
using Ecogar.Puertos.Conceptos;

namespace Ecogar.CasosUso.Conceptos
{
    public class ListarConceptosInteractor : ListarConceptosInputPort
    {
        private readonly ListarConceptosOutputPort _outputPort;
        private readonly IListarConceptos _listarConceptos;

        public ListarConceptosInteractor(
            ListarConceptosOutputPort outputPort, 
            IListarConceptos listarConceptos)
        {
            _outputPort = outputPort;
            _listarConceptos = listarConceptos;
        }

        public Task Ejecutar()
        {
            var conceptos = _listarConceptos.Listar();
            var salida = conceptos.Select(c => new ConceptoDto(c)).ToList();
            _outputPort.Ejecutar(salida);

            return Task.CompletedTask;
        }
    }
}
