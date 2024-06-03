using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FriendsList friend1 = new FriendsList();


            friend1.Name = "Carlos";
            friend1.nickName = "CarlitosPro";
            friend1.Estado = false;
            friend1.LastConection = 25;

            friend1.mostrarEstadoAmigo();
            Console.ReadKey();
            

        }
    }
}
