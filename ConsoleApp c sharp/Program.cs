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
            Console.WriteLine("Tere mis ülesanne kontrolime? 1,2,3,4?");
            string vastus = Console.ReadLine();
            while (true)
            {
                if (vastus == "1")
                {
                    string vastvast = "";
                    double hind = 15;
                    Console.WriteLine("Tere tulemast!!! Mis on sinu nimi?");
                    Console.WriteLine("kui sa tahad stop print 'jah' ");
                    vastvast = Console.ReadLine();
                    if (vastvast == "jah")
                    {
                        break;
                    }
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

                else if (vastus == "2")
                {
                    Console.WriteLine("kui sa tahad stop print 'jah' ");
                    string vastvast = "";
                    vastvast = Console.ReadLine();
                    if (vastvast == "jah")
                    {
                        break;
                    }
                    string n1 = "";
                    string n2 = "";
                    Console.WriteLine("Tere Naabrid mis on sinu nimed? ");
                    Console.WriteLine("nime1");
                    Console.WriteLine("nime2");
                    n1 = Console.ReadLine();
                    n2 = Console.ReadLine();
                    if ((n1 == "EL" && n2 == "VG" || n1 == "VG" && n2 == "EL") || (n1 == "MLAST" && n2 == "MLEM" || n1 == "MLEM && n2==MLAST") || (n1 == "MLEM" && n2 == "EN" || n1 == "EN" && n2 == "MLEM") || (n1 == "AK" && n2 == "SA" || n1 == "SA" && n2 == "AK") || (n1 == "SA" && n2 == "DK" || n1 == "DK" && n2 == "SA") || (n1 == "EA" && n2 == "AKOL" || n1 == "AKOL" && n2 == "EA"))
                    {
                        Console.WriteLine("Sa oled naabrid!");
                    }
                    else if (n1 == "MARK" && n2 == "MARK")
                    {
                        Console.WriteLine("sa oled Mark");
                    }



                }
                else if (vastus == "3")
                {


                    Console.WriteLine("Sisestage põranda pindala!");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    if ((a != 0 && b != 0) || (a < 0 && b < 0))
                    {
                        int S = a * b;
                        Console.WriteLine(S + "m2");
                        Console.WriteLine();
                        Console.WriteLine("Kas sa tahad remondi teha?");
                        string c = Console.ReadLine();
                        if (c.ToUpper() == "JAH" || c.ToLower() == "jah")
                        {
                            Console.WriteLine("Kui palju maksab 1 m2?");
                            int d = int.Parse(Console.ReadLine());
                            Console.WriteLine("Kui palju maksab põranda vahetus?");
                            int e = int.Parse(Console.ReadLine());
                            Console.WriteLine("Sul on vaja maksta -" + d + e + "€");
                        }
                        else
                        {
                            Console.WriteLine(":(");
                        }
                    }

                }
                else if (vastus == "4")
                {
                    Console.WriteLine("Sissestage oma pikkus!");
                    int rost = int.Parse(Console.ReadLine());
                    if (rost < 160)
                    {
                        Console.WriteLine("sa oled lühike");
                    }
                    else if (rost >= 170)
                    {
                        Console.WriteLine("sul on keskmine pikkus");
                    }
                    else if (rost >= 185)
                    {
                        Console.WriteLine("sul on suur pikkus");
                    }












                }
                else if (vastus == "5")
                {
                    Console.WriteLine("Sissestage oma pikkus!");
                    int rost = int.Parse(Console.ReadLine());
                    Console.WriteLine("Sissestage oma sugu");
                    string sugu = Console.ReadLine();
                    if (rost < 160 && sugu == "naine")
                    {
                        Console.WriteLine("sul on normalne pikkus");
                    }
                    else if (rost >= 170 && sugu == "naine")
                    {
                        Console.WriteLine("sul on suur pikkus");
                    }
                    else if (rost >= 185 && sugu == "naine")
                    {
                        Console.WriteLine("sul on suuuuuuuuuuuuuuuuuuuuuuuuuuuur pikkus");
                    }
                    else if (rost < 160 && sugu == "mees")
                    {
                        Console.WriteLine("sul on lühike pikkus");
                    }
                    else if (rost >= 170 && sugu == "mees")
                    {
                        Console.WriteLine("sul on keskmine pikkus");
                    }
                    else if (rost >= 185 && sugu == "mees")
                    {
                        Console.WriteLine("sul on suur pikkus");
                    }


                }
                else if (vastus=="6")
                {
                    Console.WriteLine("tere kas tahad ostsi piim,leib või saia jah!-ei?");
                    string otvet = Console.ReadLine();
                    if (otvet=="jah!")
                    {
                        int cena = 0;
                        int piim = 1;
                        int leib = 2;
                        int sai = 3;
                        Console.WriteLine("piim hind-1eur,leib-2eur saia-1eur");
                        string vastvet = Console.ReadLine();
                        Console.WriteLine("kas ostsime piim?");
                        if (vastvet=="piim")
                        {
                            Console.WriteLine($"{cena}" + piim);
                        }
                        
                        Console.WriteLine("kas ostsime leib?");
                        if (vastvet=="leib")
                        {
                            Console.WriteLine($"{cena}" + leib);
                        }
                        Console.WriteLine("kas ostsime sai?");
                        if (vastvet == "sai")
                        {
                            Console.WriteLine($"{cena}" + sai);
                        }
                        Console.WriteLine(cena);





                    }
                    
                }

















            }
        }
    }
}
