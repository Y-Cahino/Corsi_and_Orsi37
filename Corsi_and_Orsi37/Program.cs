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
        }
        void genaarray()
        {
            //declare
            Random r = new Random();
            //generazione array input
            Console.WriteLine("Inserire numero elementi array");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[x];
            //generazaione casuale array
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1, 100);
                Console.WriteLine(array[i]);
            }
        }
        
    }
}
