using Ecogar.DTOs.Conceptos;
using Ecogar.Presentadores;
using Ecogar.Puertos.Conceptos;
using Microsoft.AspNetCore.Mvc;

namespace Ecogar.Controladores.Conceptos;

[ApiController]
[Route("/concepto")]
public class BorrarConceptoController
{
    private readonly BorrarConceptoInputPort _inputPort;
    private readonly BorrarConceptoOutputPort _outputPort;

    public BorrarConceptoController(
        BorrarConceptoInputPort inputPort,
        BorrarConceptoOutputPort outputPort)
    {
        _inputPort = inputPort;
        _outputPort = outputPort;
    }

    [HttpDelete("{id}")]
    public async Task<ConceptoDto> BorrarConcepto(int id)
    {
        await _inputPort.Ejecutar(id);

        return ((IPresentador<ConceptoDto>)_outputPort).Contenido;
    }
}
