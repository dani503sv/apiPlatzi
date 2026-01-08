using CursoProgramacionOrientadaObjetosC_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProgramacionOrientadaObjetosC_
{
    internal class ImprimirInfo
    {
        public void ImprimirSuperHeroe(ISuperHeroes superHeroe) { 
            Console.WriteLine("---- Informacion del Super Heroe ----");
            Console.WriteLine("ID: " + superHeroe.id);
            Console.WriteLine("Nombre: " + superHeroe.name);
            Console.WriteLine("Identidad: " + superHeroe.identidad + "\n");
        }
    }
}
