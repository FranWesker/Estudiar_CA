

using Ecogar.CasosUso;
using Ecogar.Presentadores;
using Ecogar.Repositorios.Memoria;
using Microsoft.Extensions.DependencyInjection;

namespace Ecogar.IoC;

public static class ContenedorDependencias
{
    public static IServiceCollection AgregarServicios(this IServiceCollection servicios)
    {
        servicios.Interactores();
        servicios.RepositoriosMemoria();
        servicios.Presentadores();

        return servicios;
    }
}
