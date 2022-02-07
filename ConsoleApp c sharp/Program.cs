using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double hind = 15;
            Console.WriteLine("Tere tulemast!!! Mis on sinu nimi?");
            Console.Title="Pealkiri";
            string nimi = Console.ReadLine();
            char[] tahed = nimi.ToCharArray();//juku->['j','u','k','u']
            int i = 0;
            nimi = "";
            foreach (var t in tahed)
            {
                if (i==0)
                {
                    nimi += t.ToString().ToUpper();
                }
                else
                {
                    nimi += t.ToString().ToLower();
                }
                i++;
            }

            Console.WriteLine("Tere{0} ", nimi);
            if (nimi.ToUpper()=="JUKU" || nimi.ToLower()=="vlademir")
            {


                Console.WriteLine($"Tule külla! {nimi} kas tahad kinno?");
                string vastus = Console.ReadLine();
                if (vastus.ToLower() == "jah" || vastus.ToLower() == "jah") 
                {
                    Console.WriteLine($"kui vana sa oled {nimi}?");
                    int vanus = int.Parse(Console.ReadLine());
                    if (vanus<=0 || vanus>109)
                    {
                        Console.WriteLine("viga");
                    }
                    else
                    {
                         if (vanus > 0 && vanus < 6)
                        {
                            hind -= hind;
                            Console.WriteLine("sinu hind on -50%");
                        }
                        else if (vanus < 6 && vanus < 12)
                        {
                            hind -= hind * 0.5;
                            Console.WriteLine("sinu hind on -25");
                        }

                        else
                        {
                            Console.WriteLine($"sull ei skidka NO SKIDKA {nimi} FULL PRICE,{hind}!!");
                        }
                    }
                    
                    

                }
                else
                {
                    Console.WriteLine("Ei taha?! :( ");
                }
            }
            else
            {
                Console.WriteLine("täna ma olen hõivatud! :(");
            }













            
        }
    }
}
