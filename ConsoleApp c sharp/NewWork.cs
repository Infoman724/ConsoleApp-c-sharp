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
        {   Console.WriteLine("kakuyu programu proverjaem? 1,2,3,4,5");
            string vastus = Console.ReadLine();
            while (true)
            {
                if (vastus=="1")
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
                    int a = 0;
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



                    } while (a < 1 || a > 5);
                    Console.WriteLine(nimed[a - 1]);



                    Console.ReadLine();
                }
                else if (vastus == "2")
                {
                    Random rnd = new Random();
                    int N = rnd.Next(1, 100);
                    int M = rnd.Next(1, 100);
                    Console.WriteLine($"N={N}");
                    Console.WriteLine($"M={M}");
                    if (N>M)
                    {
                        int abi = N;
                        N = M;
                        M = abi;
                    }
                    int[] NM = new int[M - N + 1];
                    for (int J = N; J < M + 1; J++)
                    {
                        NM[J-N] = J;
                        Console.WriteLine( J*J );
                    }
                }
                else if (vastus=="3")
                {

                    int[] arvudd = new int[5];
                    for (int i = 0; i < arvudd.Length; i++)
                        //andmed massivisse
                    {
                        arvudd[i] = int.Parse(Console.ReadLine());
                    }
                    //massiv ekrannile
                    int summa = 0;
                    int korrutis = 1;
                    foreach (int arv in arvudd)
                    {
                        summa += arv;
                        korrutis *= arv;
                        
                    }
                    Console.Write($"Summa={summa,4}");
                    Console.Write($"korrutis={korrutis,4}");
                    Console.Write($"Keskmine={summa/arvudd.Length,4}");
                    
                   






                }






                Console.ReadKey();
            }




            
        }   
    }
}
