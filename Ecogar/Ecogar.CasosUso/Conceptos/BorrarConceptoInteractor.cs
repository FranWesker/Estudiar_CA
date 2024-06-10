using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecogar.DTOs.Conceptos;
using Ecogar.Entidades.Interfaces.Conceptos;
using Ecogar.Entidades.POCOs;
using Ecogar.Puertos.Conceptos;

namespace Ecogar.CasosUso.Conceptos
{
    public class BorrarConceptoInteractor : BorrarConceptoInputPort
    {
        private readonly BorrarConceptoOutputPort _outputPort;
        private readonly IBorrarConcepto _borrarConcepto;

        public BorrarConceptoInteractor(
            IBorrarConcepto borrarConcepto,
            BorrarConceptoOutputPort outputPort)
        {
            _borrarConcepto = borrarConcepto;
            _outputPort = outputPort;
        }

        public Task Ejecutar(int id)
        {
            var concepto = _borrarConcepto.Borrar(new Concepto() { Id = id });
            _outputPort.Ejecutar(new ConceptoDto(concepto));

            return Task.CompletedTask;
        }
    }
}
