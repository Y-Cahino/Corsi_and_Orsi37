using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Corsi_and_Orsi37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare
            int[] array = new int[100];
            genaarray(array);
        }
        static void genaarray(int[] array)
        {
            //declare
            Random r = new Random();
            //generazione array input
            Console.WriteLine("Inserire numero elementi array");
            int x = Convert.ToInt32(Console.ReadLine());
            array = new int[x];
            //generazaione casuale array
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1, 100);
                Console.WriteLine(array[i]);
            }
            //aggiunta valore
            Console.WriteLine("Aggiunta valore in corso...");
            Thread.Sleep(1000);
            for()
            {

            }
        }
        
    }
}
