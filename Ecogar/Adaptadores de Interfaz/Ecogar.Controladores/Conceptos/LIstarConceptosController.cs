using Ecogar.DTOs.Conceptos;
using Ecogar.Presentadores;
using Ecogar.Puertos.Conceptos;
using Microsoft.AspNetCore.Mvc;

namespace Ecogar.Controladores.Conceptos;

[ApiController]
[Route("/concepto")]
public class LIstarConceptosController
{
    private readonly ListarConceptosInputPort _inputPort;
    private readonly ListarConceptosOutputPort _outputPort;

    public LIstarConceptosController(
        ListarConceptosInputPort inputPort,
        ListarConceptosOutputPort outputPort)
    {
        _inputPort = inputPort;
        _outputPort = outputPort;
    }

    [HttpGet]
    public async Task<ICollection<ConceptoDto>> ListarConceptos()
    {
        await _inputPort.Ejecutar();

        return ((IPresentador<ICollection<ConceptoDto>>)_outputPort).Contenido;
    }
}
