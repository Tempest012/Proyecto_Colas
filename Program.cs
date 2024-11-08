using Proyecto_Colas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_pilas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cola cola = null;
            int opcion = 0;
            while(opcion != 6)
            {
                Console.WriteLine("1.- Establecer Tamaño");
                Console.WriteLine("2.- Imprimir conteo");
                Console.WriteLine("3.- Insert");
                Console.WriteLine("4.- Extract");
                Console.WriteLine("5.- Imprimir Cola");
                Console.WriteLine("6.- Salir");
                opcion =Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Usted eligió la opción 1");
                        Console.WriteLine("Ingresa el tamaño de la cola");
                        int max=Convert.ToInt32(Console.ReadLine());
                        cola = new cola(max);
                        break;

                        case 2:

                        if(cola != null)
                        {
                            Console.WriteLine("Usted eligió la opción 2");
                            int n = cola.Count();
                            if(n != 0)
                            {
                                Console.WriteLine($"El numero de elemento insertado es {n}");
                            }
                            else
                            {
                                Console.WriteLine("La cola esta vacía");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Esta vacía");
                        }
                        break;

                    case 3:
                        if(cola != null)
                        {
                            Console.WriteLine("Usted eligió la opción 3");
                            Console.WriteLine("Dame valor del Nodo");
                            int num = Convert.ToInt32(Console.ReadLine());
                            cola.Insert(num);
                        }
                        else
                        {
                            Console.WriteLine("Esta vacía");
                        }
                        break;

                        case 4:
                        if(cola != null)
                        {
                            Console.WriteLine("Usted eligió la opción 4");
                            int valorsacado=cola.Extract();
                            if(valorsacado != -1)
                            {
                                Console.WriteLine($"El valor sacado es {valorsacado}");
                            }
                            else
                            {
                                Console.WriteLine("La cola esta Underflow");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Esta vacía");
                        }
                        break;

                    case 5:
                        if(cola != null)
                        {
                            Console.WriteLine("Usted eligió la opción 5");
                            cola.Print();
                        }
                        else
                        {
                            Console.WriteLine("Esta vacía");
                        }
                        break;


                    case 6:
                        break;
                }
            }

        }
    }
}
