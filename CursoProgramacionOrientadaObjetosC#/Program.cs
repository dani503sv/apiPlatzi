using CursoProgramacionOrientadaObjetosC_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProgramacionOrientadaObjetosC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crear un super heroe forma statica
            CursoProgramacionOrientada.CrearSuperHeroe();

        }

    }

    public class CursoProgramacionOrientada
    {
        public static void CrearTelefono()
        {
            //Crear un objecto
            Telefono Tel = new Telefono();

            //Utilizar propiedades de un objecto
            Tel.color = "Black";
            Tel.tamaño = 50.00;
            Tel.cantidadButtones = 3;
            Tel.numeroCamaras = 4;
            Tel.marca = "SAMSUNG";
            Tel.modelo = "S22 ULTRA";
            Tel.versionAndroid = 15;
            Tel.precio = 500.00;
        }
        public static void CrearSuperHeroe() {

            var imprimir = new ImprimirInfo();

            //Crear super poderes
            var poderVolar = new SuperPoder();
            poderVolar.nombre = "Volar";
            poderVolar.descripcion = "Puede volar";
            poderVolar.Nivel = NivelPoder.Medio;

            var poderSuperFuerza = new SuperPoder();
            poderSuperFuerza.nombre = "Super Fuerza";
            poderSuperFuerza.descripcion = "Golpiar super fuerte";
            poderSuperFuerza.Nivel = NivelPoder.Alto;

            var poderRegeneracion = new SuperPoder();
            poderRegeneracion.nombre = "Regeneracion";
            poderRegeneracion.descripcion = "Recupera fisicamente";
            poderRegeneracion.Nivel = NivelPoder.Alto;

            var numeroId = 0;

            //-----------Crear un super heroe-----------
            var superman = new SuperHeroe();

            //Utilizar propiedades de un super heroe
            superman.id = numeroId++;
            superman.name = "Spider-man";
            superman.identidad = "Piter Parker";
            superman.ciudad = "NEW YORK";
            superman.puedeVolar = false;

            imprimir.ImprimirSuperHeroe(superman);

            //Introducir datos array
            List<SuperPoder> poderesSuperman = new List<SuperPoder>();

            //Agregar poderes al array
            poderesSuperman.Add(poderVolar);
            poderesSuperman.Add(poderSuperFuerza);

            //Asignar poderes al super heroe
            superman.superPoderes = poderesSuperman;

            //-------------Crear otro super heroe---------------
            var wolwereine = new AntiHeroe();

            //Utilizar propiedades de un super heroe
            wolwereine.id = numeroId++;
            wolwereine.name = "wolwerine";
            wolwereine.identidad = "Logan";
            wolwereine.ciudad = "Tokio";
            wolwereine.puedeVolar = false;

            imprimir.ImprimirSuperHeroe(wolwereine);

            List<SuperPoder> poderesWowerine = new List<SuperPoder>();

            //Agregar poderes al array
            poderesWowerine.Add(poderRegeneracion);
            poderesWowerine.Add(poderSuperFuerza);
            wolwereine.superPoderes = poderesWowerine;

            //Usar metodo de super heroe
            string resultSuperPoderes = superman.usarSuperPoderes();
            string resultSuperPoderesWolwereine = wolwereine.usarSuperPoderes();

            Console.WriteLine(resultSuperPoderes);
            Console.WriteLine("--------------");
            Console.WriteLine(resultSuperPoderesWolwereine);

            string accion = wolwereine.RealizarAccionMalvada("Ataca a la policia");
            Console.WriteLine(accion);

            string salvarMundo = superman.SalvarAlMundo();
            Console.WriteLine(salvarMundo);
            string resultSalvarTierra = wolwereine.SalvarLaTierra();
            Console.WriteLine(resultSalvarTierra);

        }

    }
}
