using CursoProgramacionOrientadaObjetosC_.Interfaces;
using CursoProgramacionOrientadaObjetosC_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProgramacionOrientadaObjetosC_
{
    internal class SuperHeroe : Heroe, ISuperHeroes
    {
        private string _Name;
        public int id { get; set; } = 1;
        public string name { 
            get { return _Name; } 
            set { _Name = value.Trim(); }
        }

        public string nombreIdentidadSecreta {
            get {
                return $"{_Name} ({identidad})";
            }
        }

        public string identidad { get; set; }

        //Crear un array de superpoderes
        public string ciudad;
        public List<SuperPoder> superPoderes =  new List<SuperPoder>();
        public bool puedeVolar;


        public SuperHeroe()
        {
            superPoderes = new List<SuperPoder>();
            puedeVolar = false;
            id = 1;
        }

        public string usarSuperPoderes()
        {
            //es una funcion que devuelve un string
            StringBuilder sb = new StringBuilder();

            foreach (var item in superPoderes)
            {
               sb.AppendLine($"{nombreIdentidadSecreta} esta usando el superpoder: {item.nombre}" );
            }

            return sb.ToString();
        }

        //Implementacion del metodo abstracto
        public override string SalvarAlMundo()
        {
            return $"{nombreIdentidadSecreta} esta salvando al mundo!";
        }

        public override string NombreCompleto
        {
            get
            {
                return nombreIdentidadSecreta;
            }
            set
            {
               _Name = value.Trim();
            }
        }

        public override string SalvarLaTierra()
        {
            //Implementacion personalizada del metodo virtual
            //return base.SalvarLaTierra();

            return $"{nombreIdentidadSecreta} ha salvado la tierra de un asteroide!";
        }
    }
}
