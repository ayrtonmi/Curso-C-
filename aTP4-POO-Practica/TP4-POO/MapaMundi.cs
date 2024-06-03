using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_POO
{
    internal class MapaMundi 
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ingrese un continente: ");
            //string continenteString = Console.ReadLine();
            //Continente continenteMostrar = new Continente();
            //continenteMostrar.Nombre = continenteString;
            //MapaMundial mapa = new MapaMundial();


            //switch (continenteMostrar.Nombre) {
            //    case "Europa":
            //            mapa.GetPaises(continenteMostrar);
            //        break;
            //    case "America":
            //        mapa.GetPaises(continenteMostrar);
            //        break;
            //    case "Oceania":
            //        mapa.GetPaises(continenteMostrar);
            //        break;
            //    case "Africa":
            //        mapa.GetPaises(continenteMostrar);
            //        break;
            //    case "Antartida":
            //        mapa.GetPaises(continenteMostrar);
            //        break;

            //    default: Console.WriteLine("No existe ese continente.");
            //        break;
            //}

            //Console.ReadKey();
            Console.WriteLine("Ingrese un continente: ");
            string continenteString = Console.ReadLine();
            MapaMundial mapa = new MapaMundial();

            mapa.GetPaises(continenteString);

            Console.ReadKey();
        } 
        
    }
}
