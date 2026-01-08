using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProgramacionOrientadaObjetosC_
{
    internal class SuperPoder
    {
        public string nombre;
        public string descripcion;
        public NivelPoder Nivel;

        public SuperPoder()
        {
            Nivel = NivelPoder.Bajo;
        }
    }


    enum NivelPoder
    {
        Bajo,
        Medio,
        Alto,
        Supremo
    }
}


