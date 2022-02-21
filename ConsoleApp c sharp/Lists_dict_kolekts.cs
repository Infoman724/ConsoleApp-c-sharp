using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_c_sharp
{
    class Lists_dict_kolekts
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string vastus = Console.ReadLine();
                if (vastus=="2")
                {
                    Random rnd = new Random();
                    LinkedList<int> numbrid = new LinkedList<int>();
                    LinkedList<int> numbrid2 = new LinkedList<int>();
                    for (int i = 0; i < 20; i++)
                    {
                        numbrid.AddLast(rnd.Next(1, 20));
                    }
                    foreach (int number in numbrid)
                    {
                        Console.Write(number + " ");
                        if (number % 2 == 0)
                        {
                            numbrid2.AddFirst(number);
                        }
                        else
                        {
                            numbrid2.AddLast(number);
                        }
                    }
                    Console.WriteLine();
                    foreach (int number2 in numbrid2)
                    {
                        Console.Write(number2 + " ");
                    }
                    Console.ReadKey();
                }
                else if (vastus=="1")
                {
                    
                }
                else if (vastus=="3")
                {
                    LinkedList<string> tooded = new LinkedList<string>();
                    LinkedList<int> cal = new LinkedList<int>();
                }
















            }
            
        }
    }
}
