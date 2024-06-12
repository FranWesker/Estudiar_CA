using Ecogar.DTOs.Conceptos;
using Ecogar.Presentadores;
using Ecogar.Puertos.Conceptos;
using Microsoft.AspNetCore.Mvc;

namespace Ecogar.Controladores.Conceptos;

[ApiController]
[Route("/concepto")]
public class CrearConceptoController
{
    private readonly CrearConceptoInputPort _inputPort;
    private readonly CrearConceptoOutputPort _outputPort;

    public CrearConceptoController(
        CrearConceptoInputPort inputPort,
        CrearConceptoOutputPort outputPort)
    {
        _inputPort = inputPort;
        _outputPort = outputPort;
    }

    [HttpPost]
    public async Task<ConceptoDto>CrearConcepto(ModificarConceptoDto modificarConceptoDto)
    {
        await _inputPort.Ejecutar(modificarConceptoDto);

        return ((IPresentador<ConceptoDto>)_outputPort).Contenido;
    }
}
