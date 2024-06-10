using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecogar.Presentadores.Conceptos;
using Ecogar.Puertos.Conceptos;
using Microsoft.Extensions.DependencyInjection;

namespace Ecogar.Presentadores
{
    public static class ContenedorDependencias
    {
        public static IServiceCollection Presentadores(this IServiceCollection servicios)
        {
            servicios.AddScoped<CrearConceptoOutputPort, ConceptoDtoPresenter>();
            servicios.AddScoped<ModificarConceptoOutputPort, ConceptoDtoPresenter>();
            servicios.AddScoped<BorrarConceptoOutputPort, ConceptoDtoPresenter>();
            servicios.AddScoped<ListarConceptosOutputPort, ListaConceptoDtoPresentar>();
            
            return servicios;
        }
    }
}
