using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecogar.Presentadores
{
    public interface IPresentador<out TDato>
    {
        TDato Contenido { get; }
    }
}
