using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_c_sharp
{

    class NewWork
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arvud = new int[10];
            for (int i = 0; i < arvud.Length; i++)
            {
                arvud[i] = rnd.Next(1, 100);
            }

            foreach (int arv in arvud)
            {
                Console.Write($"{arv,4}");
            }
            string[] nimed = new string[5] { "Sasha", "Masha", "Pasha", "Igor", "David" };
            int a=0;
            do
            {
                Console.Write("jrkordne number(tavaline inimene) 1-5: ");
                try
                {
                    a = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                a = int.Parse(Console.ReadLine());



            } while (a<1 || a>5);
            Console.WriteLine(nimed[a-1]);
            


            Console.ReadLine();
        
        
        
        
        }   
    }
}
