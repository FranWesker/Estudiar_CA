using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecogar.Puertos.Conceptos
{
    public interface BorrarConceptoInputPort
    {
        Task Ejecutar(int id);
    }
}
