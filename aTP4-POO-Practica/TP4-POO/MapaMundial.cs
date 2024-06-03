using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_POO
{
    internal class MapaMundial
    {
        //static void Main(string[] args)
        public List<Continente> Continentes { get; set; } = new List<Continente>();
        public MapaMundial()//REPASAR CONSTRUCTOR
        {
            //CONTINENTES
            Continente Europa = new Continente();
            Europa.Nombre = "Europa";
            Continente America = new Continente();
            America.Nombre = "America";
            Continente Asia = new Continente();
            Asia.Nombre = "Asia";
            Continente Africa = new Continente();
            Africa.Nombre = "Africa";
            Continente Oceania = new Continente();
            Oceania.Nombre = "Oceania";
            Continente Antartida = new Continente();
            Antartida.Nombre = "Antartida";

            //PAISES
            Pais Argentina = new Pais();
            Argentina.Nombre = "Argentina";
            Argentina.Capital = "Buenos Aires";
            Argentina.Continente = America;
            America.Paises.Add(Argentina);
            
            Pais Uruguay = new Pais();
            Uruguay.Nombre = "Uruguay";
            Uruguay.Capital = "Montevideo";
            Uruguay.Continente = America;
            America.Paises.Add(Uruguay);
           
            Pais Brasil = new Pais();
            Brasil.Nombre = "Brasil";
            Brasil.Capital = "Brasilia";
            Brasil.Continente = America;
            America.Paises.Add (Brasil);
            
            Pais Chile = new Pais();
            Chile.Nombre = "Chile";
            Chile.Capital = "Santiago";
            Chile.Continente = America;
            America.Paises.Add(Chile);
          
            Pais Paraguay = new Pais();
            Paraguay.Nombre = "Paraguay";
            Paraguay.Capital = "Asuncion";
            Paraguay.Continente = America;
            America.Paises.Add(Paraguay);

            Pais Bolivia = new Pais();
            Bolivia.Nombre = "Bolivia";
            Bolivia.Capital = "Sucre, La Paz";
            Bolivia.Continente = America;
            America.Paises.Add(Bolivia);

            Pais España = new Pais();
            España.Nombre = "España";
            España.Capital = "Madrid";
            España.Continente = Europa;
            Europa.Paises.Add(España);

            Pais Francia = new Pais();
            Francia.Nombre = "Francia";
            Francia.Capital = "Paris";
            Francia.Continente = Europa;
            Europa.Paises.Add(Francia);

            Pais Italia = new Pais();
            Italia.Nombre = "Italia";
            Italia.Capital = "Roma";
            Italia.Continente = Europa;
            Europa.Paises.Add(Italia);

            Pais Portugal = new Pais();
            Portugal.Nombre = "Portugal";
            Portugal.Capital = "Lisboa";
            Portugal.Continente = Europa;
            Europa.Paises.Add (Portugal);

            //PROVINCIAS
            Provincia EntreRios = new Provincia();
            EntreRios.Nombre = "Entre Rios";
            Argentina.Provincias.Add(EntreRios);

            Provincia BuenosAires = new Provincia();
            BuenosAires.Nombre = "Buenos Aires";
            Argentina.Provincias.Add (BuenosAires);

            Provincia SantaFe = new Provincia();
            SantaFe.Nombre = "SantaFe";
            Argentina.Provincias.Add(SantaFe);

            Provincia Corrientes = new Provincia();
            Corrientes.Nombre = "Corrientes";
            Argentina.Provincias.Add(Corrientes);

            Provincia Cordoba = new Provincia();
            Cordoba.Nombre = "Cordoba";
            Argentina.Provincias.Add(Cordoba);

            Provincia Salto = new Provincia();
            Salto.Nombre = "Salto";
            Uruguay.Provincias.Add(Salto);

            Provincia Paysandu = new Provincia();
            Paysandu.Nombre = "Paysandu";
            Uruguay.Provincias.Add(Paysandu);

            Provincia Canelones = new Provincia();
            Canelones.Nombre = "Canelones";
            Uruguay.Provincias.Add(Canelones);

            Provincia Rocha = new Provincia();
            Rocha.Nombre = "Rocha";
            Uruguay.Provincias.Add(Rocha);

            Provincia Maldonado = new Provincia();
            Maldonado.Nombre = "Maldonado";
            Uruguay.Provincias.Add(Maldonado);

            // Tenga un método getPaises que reciba como parámetro un String con el nombre del
            //          Continente y devuelva un Set de Países.
            // Tenga un método getProvincias que reciba como parámetro un String con el nombre de un
            //País y devuelva un Set de Provincias.
            Continentes.Add(Europa);
            Continentes.Add(America);
            Continentes.Add(Asia);
            Continentes.Add(Oceania);
            Continentes.Add(Africa);
            
        }
        //public void GetPaises(Continente continente)
        //{
        //    Console.WriteLine("Paises de "+continente.Nombre +":");
        //    continente.MostrarPaises();
        //}
        
        public void GetPaises(string nombreContinente)
        {
            Continente continenteEncontrado = Continentes.FirstOrDefault(c => c.Nombre == nombreContinente);

            if (continenteEncontrado != null)
            {
                Console.WriteLine("Paises de " + continenteEncontrado.Nombre + ":");
                continenteEncontrado.MostrarPaises();
            }
            else
            {
                Console.WriteLine("No existe ese continente.");
            }
        }

        public void GetProvincias(Pais pais)
        {
            Console.WriteLine("Provincias de "+pais.Nombre+":");
            pais.MostrarProvincias();
        }
        
        
    }
    
}
