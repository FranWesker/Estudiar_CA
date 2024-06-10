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
    public class ModificarConceptoInteractor : 
        ModificarConceptoInputPort
    {
        private readonly IModificarConcepto _modificarConcepto;
        private readonly ModificarConceptoOutputPort _outputPort;

        public ModificarConceptoInteractor(
            IModificarConcepto modificarConcepto, 
            ModificarConceptoOutputPort outputPort)
        {
            _modificarConcepto = modificarConcepto;
            _outputPort = outputPort;
        }

        public Task Ejecutar(int id, ModificarConceptoDto conceptoDto)
        {
            var concepto = _modificarConcepto.Modificar(Map(id, conceptoDto));
            _outputPort.Ejecutar(Map(concepto));

            return Task.CompletedTask;
        }

        private Concepto Map(int id, ModificarConceptoDto conceptoDto)
        {
            return new Concepto()
            {
                Id = id,
                Nombre = conceptoDto.Nombre,
            };
        }

        private ConceptoDto Map(Concepto conceptoDto)
        {
            return new ConceptoDto()
            {
                Id = conceptoDto.Id,
                Nombre = conceptoDto.Nombre,
            };
        }

    }
}
