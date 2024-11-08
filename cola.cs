using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Colas
{
    internal class cola
    {
        private int MAX;
        private int count = 0;
        private nodo inicio;

        public cola (int max)
        {
            MAX = max;
            inicio = null;
        }

        private bool Underflow()
        {
            if (inicio == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool Overflow()
        {
            if(MAX==count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Insert(int num)
        {
            //Regresa true si se inserto exitosamente
            //regresa false si la cola esta lleno
            nodo nuevo = new nodo(num);
            if (Overflow())
            {
                Console.WriteLine("La cola esta Overflow");
                return false;
            }
            else if (Underflow())
            {
                inicio = nuevo;
                count++;
                return true;
            }
            else
            {
                nodo act = inicio;
                while (act.Sig != null)
                {
                    act = act.Sig;
                }
                act.Sig = nuevo;
                count++;
                return true;
            }
        }
        public int Extract()
        {
            //regresa el numero sacado de la cola 0
            //regresa -1 cuando la cola esta vacia
            if (Underflow())
            {
                return -1;
            }
            else
            {
                int valorsacado = inicio.Valor;
                inicio = inicio.Sig;
                count--;
                return valorsacado;
            }
        }
        public int Count(int n=0)
        {
            //regresa cuantos elementos tiene la cola
            nodo act;
            act = inicio;
            if (Underflow())
            {
                return n;
            }
            else
            {
                n++;
                while(act.Sig != null)
                {
                    act= act.Sig;

                    n++;
                }
                return n;
            }
        }
        public void Print()
        {
            //imprime la cola
            nodo act;
            act = inicio;
            if (act == null)
            {
                Console.WriteLine("La pila esta Underflow");
            }
            else
            {
                while (act != null)
                {
                    Console.WriteLine($"[{act.Valor}]");
                    act = act.Sig;
                }
            }
        }
    }
}
