using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadora
{
    internal abstract class Calculadora
    {
        public abstract decimal Calcular(decimal a, decimal b);

        public abstract void ObtenerResultado(decimal a, decimal b);

    }
}
