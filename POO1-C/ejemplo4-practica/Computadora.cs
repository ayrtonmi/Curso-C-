using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo4_practica
{
    internal class Computadora
    {
        public Computadora(string gabinete, int psu) {
            this.gabinete = gabinete;
            this.psu = psu;
            estado = false;
        }
        //ATRIBUTOS
        private string procesador;
        private string gpu;
        private int memoriaRAM;
        private int almacenamiento;
        private string gabinete;
        private int psu;
        private bool estado;

        //PROPIEDADES
        public string Procesador
        {
            get { return procesador; }
            set { procesador = value; }
        }

        public string GPU
        {
            get { return gpu; }
            set { gpu = value; }
        }
        public int MemoriaRAM
        {
            get { return memoriaRAM; }
            set { memoriaRAM = value; }
        }
        public int Almacenamiento
        {
            get { return almacenamiento; }
            set { almacenamiento = value; }
        }

        
        //METODOS
        public void encender()
        {
            estado = true;
            Console.WriteLine("Encendido.");
        }

        public void cargarComponentes()
        {
            if (estado == true)
            Console.WriteLine("CPU: "+procesador+ " GPU: "+gpu+ " "+memoriaRAM+"GB "+almacenamiento+"GB  check.");
            
            else Console.WriteLine("system off");
        }
        public void cargarSO()
        {
            if (estado == true)
                Console.WriteLine("Bienvenido a Windows...");
            
        }

    }
}
