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
            Console.WriteLine("Tere mis ülesanne kontrolime? 2 või 3?");
            string vastus = Console.ReadLine();
            if (vastus=="2")
            {
                double hind = 15;
                Console.WriteLine("Tere tulemast!!! Mis on sinu nimi?");
                Console.Title = "Pealkiri";
                string nimi = Console.ReadLine();
                string p_tuup = "";
                char[] tahed = nimi.ToCharArray();//juku->['j','u','k','u']
                int i = 0;
                nimi = "";
                foreach (var t in tahed)
                {
                    if (i == 0)
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
                if (nimi.ToUpper() == "JUKU" || nimi.ToLower() == "vlademir")
                {


                    Console.WriteLine($"Tule külla! {nimi} kas tahad kinno?");
                    string vast = Console.ReadLine();
                    if (vast.ToLower() == "jah" || vast.ToLower() == "jah")
                    {
                        Console.WriteLine($"kui vana sa oled {nimi}?");
                        int vanus = int.Parse(Console.ReadLine());


                        if (vanus <= 0 || vanus > 109)
                        {
                            Console.WriteLine("viga");
                        }
                        else
                        {
                            if (vanus > 0 && vanus < 6)
                            {
                                hind -= hind;
                                p_tuup = "tasuta";
                                Console.WriteLine("tasuta");
                            }
                            else if (vanus > 6 && vanus < 14)
                            {
                                p_tuup = "laste pilet";
                                hind -= hind * 0.5;
                                Console.WriteLine("sinu hind on -50%");
                            }
                            else if (vanus > 14 && vanus < 65)
                            {
                                p_tuup = "täispilet";

                                Console.WriteLine("sinu hind on normalne");
                            }
                            else if (vanus > 65)
                            {
                                p_tuup = "soodus pilet";
                                Console.WriteLine("sul on soodus pilet");

                            }

                            else
                            {
                                Console.WriteLine("{0},sul on {2}pilet vaja maksa {1}", nimi, hind, p_tuup);
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
            else if (vastus=="3")
            {
                string n1 = "";
                string n2 = "";
                Console.WriteLine("Tere Naabrid mis on sinu nimed? ");
                if ((n1 == "EL" && n2 == "VG" || n1 == "VG" && n2 == "EL") || (n1 == "MLAST" && n2 == "MLEM" || n1 == "MLEM && n2==MLAST") || (n1 == "MLEM" && n2 == "EN" || n1 == "EN" && n2 == "MLEM") || (n1 == "AK" && n2 == "SA" || n1 == "SA" && n2 == "AK") || (n1 == "SA" && n2 == "DK" || n1 == "DK" && n2 == "SA") || (n1 == "EA" && n2 == "AKOL" || n1 == "AKOL" && n2 == "EA"))
                {
                    Console.WriteLine("Tere naabrid!");
                }
                else if (n1 == "MARK" && n2 == "MARK")
                {
                    Console.WriteLine("sa oled Mark");
                }
            }
            

            










            
            
        }
    }
}
