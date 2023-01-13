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
            int x = 0;
            //stampa delle opzioni
            Console.WriteLine("0 - Uscita");
            Console.WriteLine("1 - Aggiungi elemento");
            Console.WriteLine("2 - Stampa elementi caricati");
            //scelta opzione
            Console.WriteLine("Inserisci scelta");
            int scelta = int.Parse(Console.ReadLine());
            do
            {
                //exe
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("Inserire numero elementi array");
                        x = Convert.ToInt32(Console.ReadLine());
                        //generazione array input
                        array = new int[x];
                        genaarray(array);
                        break;
                    case 2:
                        //aggiunta valore
                        Console.WriteLine("Aggiunta valore in corso...");
                        Thread.Sleep(1000);
                        for (int j = 0; j < 1; j++)
                        {
                            array[j] = j;
                            Console.WriteLine(array[j]);
                        }
                        break;
                }
            }while(scelta != 0);
        }
        static void genaarray(int[] array)
        {
            //declare
            Random r = new Random();
            
            //generazaione casuale array
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1, 100);
                Console.WriteLine(array[i]);
            }
            
        }

        
    }
}
