﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecogar.Entidades.POCOs;

namespace Ecogar.Entidades.Interfaces.Conceptos
{
    public interface IModificarConcepto
    {
        public Concepto Modificar(Concepto concepto);
    }
}
