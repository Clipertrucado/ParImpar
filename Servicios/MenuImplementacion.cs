using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParImpar.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int Menu()
        {
            int selec;

            Console.WriteLine("###########################");
            Console.WriteLine("0. Se cerrara la aplicacion");
            Console.WriteLine("1. Introducir numero y ver si es par o impar");
            Console.WriteLine("###########################");
            selec = Convert.ToInt32(Console.ReadLine());

            return selec;
        }
    }
}
