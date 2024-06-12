using Ecogar.DTOs.Conceptos;
using Ecogar.Puertos.Conceptos;

namespace Ecogar.Presentadores.Conceptos;

public class ListaConceptoDtoPresenter :
    ListarConceptosOutputPort,
    IPresentador<ICollection<ConceptoDto>>
{
    public ICollection<ConceptoDto> Contenido { get; private set;}

    public Task Ejecutar(ICollection<ConceptoDto> conceptos)
    {
        Contenido = conceptos;

        return Task.CompletedTask;
    }
}
