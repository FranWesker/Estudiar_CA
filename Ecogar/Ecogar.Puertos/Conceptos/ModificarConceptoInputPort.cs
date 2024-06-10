using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecogar.DTOs.Conceptos;

namespace Ecogar.Puertos.Conceptos
{
    public interface ModificarConceptoInputPort
    {
        Task Ejecutar(int id, ModificarConceptoDto conceptoDto);
    }
}
