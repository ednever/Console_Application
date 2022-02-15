using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App1
{
    public class Funktsioonid
    {
        public static int Korrutamine(int arv1, int arv2) //void
        {
            int kor = arv1 * arv2;
            return kor;
        }
        public static int[] Arvud_Massiiviisse(int n,bool t_f)
        {
            Random rnd = new Random();
            int[] arvud = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (t_f)
                {
                    string input = Console.ReadLine();
                    int output;
                    if (int.TryParse(input, out output))
                    {
                        arvud[i] = output;
                    }
                    else
                    {
                        Console.WriteLine("Ainult arvud");
                    }
                }
                else
	            {
                    arvud[i] = rnd.Next(1, 100);
	            }
            }
            return arvud;
        }
        public static void Arvud_Ekraanile(Array massiiv)
        {
            int k,max = 0;
            foreach (var m in massiiv)
            {
                k = m.ToString().Length;
                if (k > max)
                {
                    max = k;
                }
            }
            max++;
            foreach (var m in massiiv)
            {
                Console.Write($"{0,1}",m,max);
            }
        }
        public static double Keskmine(int N)
        {
            double[] arvud = new double[N];
            double kesk = 0;
            for (int i = 0; i < N; i++)
            {
                arvud[i] = int.Parse(Console.ReadLine());
            }
            foreach (double item in arvud)
            {
                kesk = kesk + item;
            }
            kesk = Math.Round(kesk / N,4);
            return kesk;
        }
        public static void Kass(double result)
        {            
            for (int i = 0; i < result; i++)
            {
                Console.Write("nurr ");
            }
        }
        public static void Zvezda(int arv)
        {
            for (int i = 0; i < arv; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
