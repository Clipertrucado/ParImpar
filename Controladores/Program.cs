using ParImpar.Servicios;
using System.Net.Mail;
using System.Runtime.InteropServices;

namespace ParImpar;

class Program 
{
    static void Main(string[] args)
    {   
        
        int n1;
        bool cerrar = false;
        int opcionSeleccionada;

        while (!cerrar)
        { 
            MenuInterfaz mi = new MenuImplementacion();
         
            int selec = mi.Menu();
      
            switch (selec)
            {
                case 0:
                    Console.WriteLine("[INFO] - se ejecuta caso uno 0");
                    cerrar = true;
                    break;

                case 1:
                    Console.WriteLine("Ingresa un número");
                    n1 = Convert.ToInt32(Console.ReadLine());


                    if ((n1 % 2) == 0)
                    {
                        Console.WriteLine("Es par");
                    }
                    else
                    {
                        Console.WriteLine("Es impar");
                    }
                    break;

                default:
                    Console.WriteLine("");
                    break;

            }

        }

    }



}
