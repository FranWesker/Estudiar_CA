using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Ecogar.Entidades.Interfaces.Conceptos;
using Ecogar.Entidades.Interfaces.Cuentas;
using Ecogar.Entidades.Interfaces.Movimientos;

namespace Ecogar.Repositorios.Memoria
{
    public static class ContenedorDependencias
    {
        public static IServiceCollection RepositoriosMemoria
            (this IServiceCollection services)
        {
            // Servicios para acciones de Concepto
            var conceptoRepositorio = new ConceptosRepositorio();

            services.AddSingleton<ICrearConcepto>(conceptoRepositorio);
            services.AddSingleton<IModificarConcepto>(conceptoRepositorio);
            services.AddSingleton<IBorrarConcepto>(conceptoRepositorio);
            services.AddSingleton<IListarConceptos>(conceptoRepositorio);

            // Servicios para acciones de Cuenta
            var cuentasRepositorio = new CuentasRepositorio();

            services.AddSingleton<ICrearCuenta>(cuentasRepositorio);
            services.AddSingleton<IModificarCuenta>(cuentasRepositorio);
            services.AddSingleton<IBorrarCuenta>(cuentasRepositorio);
            services.AddSingleton<IListarCuentas>(cuentasRepositorio);

            // Servicios para acciones de los Movimientos
            var movimientoRepositorio = new MovimientosRepositorio();

            services.AddSingleton<ICrearMovimiento>(movimientoRepositorio);
            
            return services;
        }
    }
}
