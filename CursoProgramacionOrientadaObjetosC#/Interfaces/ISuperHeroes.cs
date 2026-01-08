using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProgramacionOrientadaObjetosC_.Interfaces
{
    internal interface ISuperHeroes
    {
        //Interfaces son un contrato que obliga a las clases que la implementan
        //Para definir ciertas propiedades y metodos
        int id { get; set; }
        string name { get; set; }
        string identidad { get; set; }

    }
}
