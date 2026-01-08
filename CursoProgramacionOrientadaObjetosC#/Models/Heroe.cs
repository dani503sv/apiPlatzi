using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProgramacionOrientadaObjetosC_.Models
{
    internal abstract class Heroe
    {
        //Definicion de propiedades
        // se ocupa cuando se quiere obligar a las clases derivadas a implementar este metodo
        public abstract string SalvarAlMundo();
        public abstract string NombreCompleto { get; set; }

        // Metodo virtual que puede ser sobrescrito
        //sirve para definir un comportamiento por defecto
        public virtual string SalvarLaTierra()
        {
            return $"{NombreCompleto} ha salvado la tierra";
        }

    }
}
