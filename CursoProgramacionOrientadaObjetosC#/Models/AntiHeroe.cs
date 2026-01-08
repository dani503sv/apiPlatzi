using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProgramacionOrientadaObjetosC_.Models
{
    internal class AntiHeroe : SuperHeroe
    {
        public AntiHeroe()
        {

        }

        public string RealizarAccionMalvada(string accion)
        {
            return $"El AntiHeroe {nombreIdentidadSecreta} " +
                $"esta realizando una accion malvada ({accion})!";
        }

    }
}
