using Ecogar.Presentadores.Conceptos;
using Ecogar.Puertos.Conceptos;
using Microsoft.Extensions.DependencyInjection;

namespace Ecogar.Presentadores;

public static class ContenedorDependencias
{
    public static IServiceCollection Presentadores
        (this IServiceCollection servicios)
    {
        servicios.AddScoped<CrearConceptoOutputPort, 
            ConceptoDtoPresenter>();
        servicios.AddScoped<ModificarConceptoOutputPort,
            ConceptoDtoPresenter>();
        servicios.AddScoped<BorrarConceptoOutputPort,
            ConceptoDtoPresenter>();
        servicios.AddScoped<ListarConceptosOutputPort,
            ListaConceptoDtoPresenter>();

        return servicios;

    }
}
