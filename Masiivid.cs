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
            //Array arvud;
            //arvud = Funktsioonid.Arvud_Massiiviisse(5, true);
            //Funktsioonid.Arvud_Ekraanile(arvud);
            //Console.WriteLine();
            //string[] nimed = new string[5] { "Anna", "Olga", "Edgar", "Mark", "Jegor" };
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
            //} while (a < 1 || a > 5);
            //Console.WriteLine(nimed[a - 1]);

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
            //Array arvud;
            //arvuD = Funktsioonid.Arvud_Massiiviisse(5, true);
            //int summa = 0;
            //int korrutis = 1;
            //foreach (int arv in arvuD)
            //{
            //    summa += arv;
            //    korrutis *= arv;
            //}
            //Console.WriteLine($"Summa - {summa}, Srednee - {summa / arvud.Length}, Korrutis - {korrutis}");

            //4
            //string sona;
            //do
            //{
            //    Console.WriteLine("Osta elevant ära!");
            //    sona = Console.ReadLine();
            //} while (sona != "elevant");
            //Console.WriteLine("Hästi");

            //5
            //Random rnd = new Random();
            //int arv = rnd.Next(1,3);
            //Console.WriteLine("Kirjuta arv, mis arvuti mõtles välja");
            //for (int i = 0; i < 5; i++)
            //{
            //    int sona = int.Parse(Console.ReadLine());
            //    if (sona == arv)
            //    {
            //        Console.WriteLine("Tubli");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ei ole tubli");
            //    }
            //}

            //6
            //Array arvud;
            //arvud = Funktsioonid.Arvud_Massiiviisse(4, true);
            //int abi;
            //for (int i = 0; i < arvud.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < arvud.Length; j++)
            //    {
            //        if (arvud[i] < arvud[j])
            //        {
            //            abi = arvud[i];
            //            arvud[i] = arvud[j];
            //            arvud[j] = abi;
            //        }
            //    }
            //}
            //Console.WriteLine("Koostatud nendest arvudest suurim neliarvuline arv");
            //for (int i = 0; i < arvud.Length; i++)
            //{
            //    Console.Write(arvud[i]);
            //}

            //6 variant 2
            //Console.WriteLine("Palun kirjuta neli arve");
            //Array arvud;
            //arvud = Funktsioonid.Arvud_Massiiviisse(4, true);
            //Array.Sort(arvud);
            //int D = 0;
            //for (int t = 0; t < arvud.Length; t++)
            //{
            //    D = (int)(D + arvud[t] * Math.Pow(10, t));
            //}
            //Console.WriteLine(D);

            //7
            //for (int stroka = 1; stroka < 11; stroka++)
            //{
            //    for (int rjad = 1; rjad < 11; rjad++)
            //    {
            //        Console.Write("\t" + stroka * rjad);
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}

            //7 variant 2
            //int[,] tabel = new int[10, 10];
            //for (int s = 1; s < 11; s++)
            //{
            //    for (int r = 1; r < 11; r++)
            //    {
            //        tabel[s, r] = s * r;
            //        Console.Write($"{s * r,4}");
            //    }
            //    Console.WriteLine();
            //}

            //int q = 10;
            //int korrutis = Funktsioonid.Korrutamine(q, 5);
            //Console.WriteLine(korrutis);

            //8
            //Console.WriteLine(Funktsioonid.Keskmine(4));

            //9
            //Console.WriteLine("Palun kirjuta arv, tehe ja teine arv");
            //int arv = int.Parse(Console.ReadLine());
            //string tehe = Console.ReadLine();
            //int arv2 = int.Parse(Console.ReadLine());
            //double result = 0;
            //if (tehe == "+")
            //{
            //    result = arv + arv2;
            //    Funktsioonid.Kass(result);
            //}
            //else if (tehe == "-")
            //{
            //    result = arv - arv2;
            //    Funktsioonid.Kass(result);
            //}
            //else if (tehe == "*")
            //{
            //    result = arv * arv2;
            //    Funktsioonid.Kass(result);
            //}
            //else if (tehe == "/")
            //{
            //    result = arv / arv2;
            //    Math.Round(result);
            //    Funktsioonid.Kass(result);
            //}
            //else
            //{
            //    Console.WriteLine("Ups...");
            //}

            //10
            //Console.WriteLine("Kirjuta kui palju tahad arvu tärnidega väljatrükkida");
            //int kogu = int.Parse(Console.ReadLine());
            //Console.WriteLine("Kirjuta arvud");
            //Array arvud;
            //arvud = Funktsioonid.Arvud_Massiiviisse(kogu, true);
            //foreach (int arv in arvud)
            //{
            //    Console.Write($"{arv} >>> ");
            //    Funktsioonid.Zvezda(arv);
            //}

            Console.ReadLine();
        }
    }
}
