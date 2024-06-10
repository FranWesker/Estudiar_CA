using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecogar.DTOs.Conceptos;
using Ecogar.Entidades.Interfaces.Conceptos;
using Ecogar.Entidades.POCOs;
using Ecogar.Puertos.Conceptos;

namespace Ecogar.CasosUso.Conceptos
{
    public class CrearConceptoInteractor :
        CrearConceptoInputPort
    {
        private readonly ICrearConcepto _crearConcepto;
        private readonly CrearConceptoOutputPort _outputPort;

        public CrearConceptoInteractor(
            ICrearConcepto crearConcepto, 
            CrearConceptoOutputPort outputPort)
        {
            _crearConcepto = crearConcepto;
            _outputPort = outputPort;
        }

        public Task Ejecutar(ModificarConceptoDto conceptoDto)
        {
            /*
            var concepto = Map(conceptoDto);
            concepto = _crearConcepto.Crear(concepto);
            
            var conceptoOutput = Map(concepto);
            _outputPort.Ejecutar(conceptoOutput);

            return Task.CompletedTask;

            Esta es la version larga y ahora haremos la version resumida */

            var concepto = _crearConcepto.Crear(MapConcepto(conceptoDto));
            _outputPort.Ejecutar(MapConceptoDto(concepto));

            return Task.CompletedTask;
        }

        private ConceptoDto MapConceptoDto(Concepto conceptoDto)
        {
            return new ConceptoDto()
            {
                Id = conceptoDto.Id,
                Nombre = conceptoDto.Nombre,
            };
        }

        private Concepto MapConcepto(ModificarConceptoDto conceptoDto)
        {
            return new Concepto()
            { 
                Nombre = conceptoDto.Nombre, 
            };
        }
    }
}
