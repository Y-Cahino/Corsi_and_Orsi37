using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corsi_and_Orsi37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare
            Random r = new Random();
            int[] array = new int[10];
            //generazione array input

            //aggiunta valore
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1, 11);
                Console.WriteLine(array[i]);
            }
        }
    }
}
