using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App1
{
    class Masiivid
    {
        static void Main(string[] args)
        {
            //1
            //Random rnd = new Random();
            //int[] arvud = new int[10];
            //for (int i = 0; i < arvud.Length; i++)
            //{
            //    arvud[i] = rnd.Next(1, 100);
            //}
            //foreach (int arv in arvud)
            //{
            //    Console.Write($"{arv,4}");
            //}
            //Console.WriteLine();
            //string[] nimed = new string[5] {"Anna", "Olga", "Edgar", "Mark", "Jegor"};
            //int a = 0;
            //do
            //{
            //    Console.WriteLine("Järjekorra number(tavaline inimene) 1-5: ");
            //    try
            //    {
            //        a = int.Parse(Console.ReadLine());
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e);
            //    }
            //} while (a<1 || a>5);
            //Console.WriteLine(nimed[a-1]);
            //2
            //Random rnd = new Random();
            //int N = rnd.Next(1, 100);
            //int M = rnd.Next(1, 100);
            //Console.WriteLine(N);
            //Console.WriteLine(M);
            //if (N > M)
            //{
            //    int abi = N;
            //    N = M;
            //    M = abi;
            //}
            //int[] NM = new int[M - N + 1];
            //for (int i = N; i < M; i++)
            //{
            //    NM[i-N] = i;
            //    Console.WriteLine(i * i);
            //}
            //3
            int[] arvud = new int[5];
            for (int mops = 0; mops < arvud.Length; mops++)
            {
                arvud[mops] = int.Parse(Console.ReadLine());
            }
            int summa = 0;
            int korrutis = 1;
            foreach (int arv in arvud)
            {
                summa += arv;
                korrutis *= arv;
            }
            Console.WriteLine($"Summa - {summa}, Srednee - {summa / arvud.Length}, Korrutis - {korrutis}");



            Console.ReadLine();
        }
    }
}
