using Ecogar.DTOs.Conceptos;
using Ecogar.Presentadores;
using Ecogar.Puertos.Conceptos;
using Microsoft.AspNetCore.Mvc;

namespace Ecogar.Controladores.Conceptos;

[ApiController]
[Route("/concepto")]
public class ModificarConceptoController
{
    private readonly ModificarConceptoInputPort _inputPort;
    private readonly ModificarConceptoOutputPort _outputPort;

    public ModificarConceptoController(
        ModificarConceptoInputPort inputPort,
        ModificarConceptoOutputPort outputPort)
    {
        _inputPort = inputPort;
        _outputPort = outputPort;
    }

    [HttpPut("{id}")]
    public async Task<ConceptoDto> ModificarConcepto(
        int id,
        ModificarConceptoDto modificarConceptoDto)
    {
        await _inputPort.Ejecutar(id, modificarConceptoDto);

        return ((IPresentador<ConceptoDto>)_outputPort).Contenido;
    }
}
