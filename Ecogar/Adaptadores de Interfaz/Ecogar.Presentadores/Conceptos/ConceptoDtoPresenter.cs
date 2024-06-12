using Ecogar.DTOs.Conceptos;
using Ecogar.Puertos.Conceptos;

namespace Ecogar.Presentadores.Conceptos;

public class ConceptoDtoPresenter : 
    CrearConceptoOutputPort,
    ModificarConceptoOutputPort,
    BorrarConceptoOutputPort,
    IPresentador<ConceptoDto>
{
    public ConceptoDto Contenido {get; private set;}
    public Task Ejecutar(ConceptoDto conceptoDto)
    {
        Contenido = conceptoDto;

        return Task.CompletedTask;
    }
}
