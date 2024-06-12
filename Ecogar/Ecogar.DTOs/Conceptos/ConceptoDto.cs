using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecogar.Entidades.POCOs;

namespace Ecogar.DTOs.Conceptos
{
    public class ConceptoDto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }

        public ConceptoDto() { }

        public ConceptoDto(Concepto concepto)
        {
            Id = concepto.Id;
            Nombre = concepto.Nombre;
        }
    }
}
