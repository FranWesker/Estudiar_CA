using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecogar.Entidades.POCOs
{
    public class Movimiento
    {
        public int Id { get; set; }
        public required Concepto Concepto { get; set; }
        public required Cuenta Cuenta { get; set; }
        public float Importe { get; set; }
        public DateTime Fecha { get; set; }
        public required string Descripcion { get; set; }
    }
}
