using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES RECONOCIDO");
            //Queue
            Queue<char> miFila = new Queue<char>();
            //Agregando objetos al Queue
            miFila.Enqueue('a');
            miFila.Enqueue('b');
            miFila.Enqueue('c');
            miFila.Enqueue('d');
            int i = 0;
            //Recorriendo la Queue
            foreach(char elemento in miFila)
            {
                Console.WriteLine("{0}.{1}", i++,elemento);
            }
            //Agregando otro elemento
            Console.WriteLine("\nDespues de agregar a (e)\n");
            miFila.Enqueue('e');
            i = 0;
            //Recorriendo la Queue
            foreach(char elemento in miFila)
            {
                Console.WriteLine("{0}.{1}", i++,elemento);
            }
            //Despues de quitar un elemento
            Console.WriteLine("\nDespues de quitar el elemento");
            var objElim = miFila.Dequeue();
            i=0;
             foreach(var elemento in miFila)
            {
                Console.WriteLine("{0}.{1}", i++, elemento);
            }

            Console.WriteLine("\n({0}) fue eliminado correctamente", objElim);
        }


    }
}
