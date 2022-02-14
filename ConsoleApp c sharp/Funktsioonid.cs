using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_c_sharp
{
    class Funktsioonid
    {
        public static int korrutamine(int arv1,int arv2)
        {
            int kor = arv1 * arv2;
            return kor;
        }
        public static int[] arvud_massiviisse(int n,bool t_f)
        {
            Random rnd = new Random();
            int[] mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (t_f)
                {
                    int output;
                    string input=Console.ReadLine();
                    if (int.TryParse(input, out output))
                    {
                        mass[i] = output;
                    }
                    else
                    {
                        Console.WriteLine("Sissestage ainult arvud");
                    }

                }
                else
                {
                    mass[i] = rnd.Next(1, 100);
                }
            
            
            
            }
            return mass;


        }
        public static void arvud_ekranile(Array massivv)
        {
            int k, max = 0;
            foreach (var m in massivv)
            {
                k = m.ToString().Length;
                if (k>max)
                {
                    max = k;
                }
            }
            max++;
            foreach (var m in massivv)
            {
                
                Console.Write("{0,1}",m,max);
            }
        }








    }
    









}
