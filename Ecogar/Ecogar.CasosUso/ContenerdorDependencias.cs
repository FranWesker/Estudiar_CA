using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecogar.CasosUso.Conceptos;
using Ecogar.Puertos.Conceptos;
using Microsoft.Extensions.DependencyInjection;

namespace Ecogar.CasosUso
{
    public static class ContenerdorDependencias
    {
        public static IServiceCollection Interactores(this IServiceCollection services)
        {
            services.AddTransient<CrearConceptoInputPort, CrearConceptoInteractor>();
            services.AddTransient<ModificarConceptoInputPort, ModificarConceptoInteractor>();
            services.AddTransient<BorrarConceptoInputPort, BorrarConceptoInteractor>();
            services.AddTransient<ListarConceptosInputPort, ListarConceptosInteractor>();

            return services;
        }
    }
}
