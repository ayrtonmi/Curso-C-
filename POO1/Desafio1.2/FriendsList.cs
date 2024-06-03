using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class FriendsList
    {
        //private string nickname;
        private string name;
        //private int lastConection;
        //private bool estado;

        public FriendsList() { 
        }

        //propiedades
        public string nickName { get; set; }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int LastConection { get; set; }

        public bool Estado { get; set; }

        //metodos
        public void mostrarEstadoAmigo() {
            if (Estado == true) {
                Console.WriteLine(nickName + " está conectado!");
            }
            else
            {
                Console.WriteLine(nickName + " no está conectado...");
                Console.WriteLine("Última conexión: hace " + LastConection + " minutos.");
            }
        }
        public void mostrarEstadoAmigo(int LastConection)
        {
            if (Estado == true)
            {
                Console.WriteLine(nickName + "("+Name+")" + " está conectado!");
            }
            else
            {
                Console.WriteLine(nickName + " no está conectado...");
                Console.WriteLine("Última conexión: " + LastConection + " minutos.");
            }

        }

        



    }
}
