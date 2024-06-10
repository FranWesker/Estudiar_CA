using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecogar.DTOs.Conceptos;
using Ecogar.Puertos.Conceptos;

namespace Ecogar.Presentadores.Conceptos
{
    public class ListaConceptoDtoPresentar : 
        ListarConceptosOutputPort,
        IPresentador<ICollection<ConceptoDto>>
    {
        public ICollection<ConceptoDto> Contenido {  get; private set; }

        public Task Ejecutar(ICollection<ConceptoDto> conceptos)
        {
            Contenido = conceptos;
            return Task.CompletedTask;
        }
    }
}
