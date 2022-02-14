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
        {   Console.WriteLine("kakuyu programu proverjaem? 1,2,3,4,5,6");
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
                else if (vastus=="4")//osta elevant выглядит правильно но почему-то не работает скорее всего здесь какято элементарнейшая ошибка
                {
                    string vastvast = Console.ReadLine();
                    while (true)
                    {
                        Console.WriteLine("Osta elevant!");
                        Console.ReadLine();
                        if (vastvast == "elevant")
                        {
                            Console.WriteLine("Sis hästi");
                            
                        }



                        break;
                    }
                }
                else if (vastus=="5")
                {
                    Random rnd = new Random();
                    int[] arvud = new int[1];
                    for (int i = 0; i < arvud.Length; i++)
                    {
                        arvud[i] = rnd.Next(1, 100);

                    }
                    foreach (int arv in arvud)
                    {
                        Console.Write($"{arv,4}");
                    }
                    //87,62,43,41,80 вот такие цифры задумал компьютер
                }
                else if (vastus=="6")
                {
                    
                    
                    
                        for (int i = 1; i < 11; i++)
                        {
                            Console.Write(i + " ");
                        }
                        Console.Write("\n");
                        for (int i = 2; i < 21; i+=2)
                        {
                            Console.Write(i + " ");
                        }
                        Console.Write("\n");
                        for (int i = 3; i < 31; i += 3)
                        {
                            Console.Write(i + " ");
                        }
                        Console.Write("\n");
                        for (int i = 4; i < 41; i += 4)
                        {
                            Console.Write(i + " ");
                        }
                        Console.Write("\n");
                        for (int i = 5; i < 51; i += 5)
                        {
                            Console.Write(i + " ");
                        }
                        Console.Write("\n");
                        for (int i = 6; i < 61; i += 6)
                        {
                            Console.Write(i + " ");
                        }
                        Console.Write("\n");
                        for (int i = 8; i < 81; i += 8)
                        {
                            Console.Write(i + " ");
                        }
                        Console.Write("\n");
                        for (int i = 9; i < 91; i += 9)
                        {
                            Console.Write(i + " ");
                        }
                        Console.Write("\n");
                        for (int i = 10; i < 101; i += 10)
                        {
                            Console.Write(i + " ");
                        }
                        Console.Write("\n");









                
                
                
                
                
                }
                else if (vastus=="7")
                {
                    int[] massiiv4 = new int[4];
                    for (int i = 0; i < massiiv4.Length; i++)
                    //andmed massivisse
                    {
                        massiiv4[i] = int.Parse(Console.ReadLine());
                    }
                    Array.Sort(massiiv4);
                    int plus = 0;
                    for (int t = 0; t < massiiv4.Length; t++)
                    {
                        plus=(int)(plus+massiiv4[t] * Math.Pow(10, t));
                    }
                    Console.WriteLine(plus);
                
                
                
                
                
                
                
                
                
                }










                Console.ReadKey();

            }



             
         




            
        }   
    }
}
