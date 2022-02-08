using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double hind = 15;
            //string p_tuup = "täis";
            //if (vastus == "+")
            //{
            //    Console.WriteLine("Kui palju maksab ruutmeeter?");
            //    double summa = double.Parse(Console.ReadLine());
            //}
            //Console.WriteLine();
            //Console.WriteLine("Tere tulemast! Mis on sinu nimi?");
            //Console.Title = "Pealkiri";
            //string nimi = Console.ReadLine();
            //char[] tahed = nimi.ToCharArray();//juku -> ['j','u','k','u']
            //int i = 0;
            //nimi = "";
            //foreach (var t in tahed)
            //{
            //    if (i == 0)
            //    {
            //        nimi += t.ToString().ToUpper();
            //    }
            //    else
            //    {
            //        nimi += t.ToString().ToLower();
            //    }
            //    i++;
            //}
            //Console.WriteLine("Tere {0}", nimi);
            //if (nimi.ToUpper() == "JUKU" || nimi.ToLower() == "edgar")
            //{
            //    Console.WriteLine($"Tule külla! {nimi} Kas tahad kinno?");
            //    string vastus = Console.ReadLine();
            //    if (vastus.ToLower() == "jah" || vastus.ToLower() == "yes")
            //    {                    
            //        int vanus = int.Parse(Console.ReadLine());
            //        if (vanus < 0 || vanus > 109)
            //        {
            //            Console.WriteLine("Viga!");
            //        }
            //        else
            //        {
            //            if (vanus > 0 && vanus < 6)
            //            {
            //                hind -= hind;
            //                p_tuup = "tasuta";
            //            }
            //            else if (vanus >= 6 && vanus < 16)
            //            {
            //                hind -= hind * 0.5;
            //                p_tuup = "laste";
            //            }
            //            else if (vanus >= 16 && vanus < 21)
            //            {
            //                hind -= hind * 0.9;
            //                p_tuup = "noor";
            //            }
            //            Console.WriteLine("{0}, sul on {2}pilet vaja maksta {1}", nimi, hind, p_tuup);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ei taha?! :(");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Täna ma olen hõivatud :(");
            //}
            

            //Console.WriteLine("Kirjutage kaks nime");
            //string n1 = Console.ReadLine();
            //string n2 = Console.ReadLine();
            //if ((n1 == "Edgar" && n2 == "Marco") || (n1 == "Mihhail" && n2 == "Marco") || (n1 == "Marco" && n2 == "Edgar") || (n1 == "Marco" && n2 == "Mihhail") || (n1 == "Ervin" && n2 == "Vlademir") || (n1 == "Vlademir" && n2 == "Ervin") || (n1 == "Aleksandr" && n2 == "Aleksandr") || (n1 == "Daniil" && n2 == "Aleksandr") || (n1 == "Aleksandr" && n2 == "Daniil") || (n1 == "Jelena" && n2 == "Alina") || (n1 == "Alina" && n2 == "Jelena"))
            //{
            //    Console.WriteLine("Te olete pinginaabrid");
            //}
            //else
            //{
            //    Console.WriteLine("Te ei ole pinginaabrid");
            //}


            Console.WriteLine("Kirjutage ristkülikukujulise toa seinte pikkused");
            double a;
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{a}");
            double b;
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{b}");
            Console.WriteLine("Remont?");
            string vastus = Console.ReadLine();


            ConsoleKeyInfo klik;
            do
            {
                klik = Console.ReadKey(true);
                Console.Beep();
            } while (klik.Key != ConsoleKey.Escape;
            Environment.Exit(0);
        }
    }
}
