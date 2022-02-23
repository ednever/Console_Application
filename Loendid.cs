using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App1
{
    class Loendid
    {
        static void Main(string[] args)
        {
            //List int
            //List<int> numbrid = new List<int>();
            //numbrid.Add(100);
            //for (int i = 0; i < 9; i++)
            //{
            //    numbrid.Add(i + 1);
            //}
            //int n = numbrid.Count();
            //foreach (int num in numbrid)
            //{
            //    Console.WriteLine(num);
            //}
            //if (numbrid.Contains(100))
            //{
            //    Console.WriteLine("100 on olemas loendis");
            //}
            //else
            //{
            //    Console.WriteLine("100 ei ole olemas loendis");
            //}

            //List string
            //List<Inimesed> inimesed = new List<Inimesed>(3);
            //inimesed.Add(new Inimesed() { Nimi = "Mati" });
            //inimesed.Add(new Inimesed() { Nimi = "Kati" });
            //inimesed.Add(new Inimesed() { Nimi = "Mark" });
            //foreach (Inimesed inimene in inimesed)
            //{
            //    Console.Write(inimene.Nimi+", ");
            //}
            //Console.WriteLine();

            //LinkedList
            //LinkedList<string> loetelu = new LinkedList<string>();
            //loetelu.AddLast("Kass");
            //loetelu.AddLast("Koer");
            //loetelu.AddFirst("Hunt");
            //LinkedList<string>.Enumerator ahel = loetelu.GetEnumerator();
            //while (ahel.MoveNext())
            //{
            //    Console.WriteLine(ahel.Current);
            //}

            //Dictionary
            //Dictionary<int, string> opilased = new Dictionary<int, string>(6);
            //opilased.Add(74589, "Mihhail");
            //opilased.Add(74590, "Edgar");
            //opilased.Add(74591, "Aleksandr");
            //opilased.Add(74592, "Daniil");
            //opilased.Add(74593, "Mark");
            //opilased.Add(74594, "Alina");
            //string nimi = opilased[74590];
            //Console.WriteLine(nimi);
            //opilased[74591] = "Alex";
            //foreach (KeyValuePair<int,string> keyValue in opilased)
            //{
            //    Console.WriteLine(keyValue.Key+"-"+keyValue.Value);
            //}

            //1 Ülesanne
            List<int> numbrid = new List<int>();
            Console.WriteLine("Sisetage 5 arvu");
            for (int i = 0; i < 5; i++)
            {
                numbrid.Add(int.Parse(Console.ReadLine()));
            }
            foreach (int num in numbrid)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            foreach (int num in numbrid)
            {
                if (numbrid.IndexOf(num) == 0)
                {
                    Console.Write(numbrid[4] + numbrid[1] + " ");
                }
                else if (numbrid.IndexOf(num) == 4)
                {
                    Console.Write(numbrid[3] + numbrid[0] + " ");
                }
                else
                {
                    Console.Write(numbrid[numbrid.IndexOf(num) - 1] + numbrid[numbrid.IndexOf(num) + 1] + " ");
                }
            }

            //int a1 = numbrid[0];
            //int an = numbrid[numbrid.Count - 1];
            //numbrid.Insert(0, an);

            //2 Ülesanne
            //Random rnd = new Random();
            //LinkedList<int> numbrid = new LinkedList<int>();
            //LinkedList<int> numbrid2 = new LinkedList<int>();
            //for (int i = 0; i < 20; i++)
            //{
            //    numbrid.AddLast(rnd.Next(1, 20));
            //}
            //foreach (int number in numbrid)
            //{
            //    Console.Write(number + " ");
            //    if (number % 2 == 0)
            //    {
            //        numbrid2.AddFirst(number);
            //    }
            //    else
            //    {
            //        numbrid2.AddLast(number);
            //    }
            //}
            //Console.WriteLine();
            //foreach (int number2 in numbrid2)
            //{
            //    Console.Write(number2 + " ");
            //}


            //3 Ülesanne
            //List<string> tooded = new List<string>();
            //tooded.Add("leib");
            //tooded.Add("piim");
            //tooded.Add("õun");
            //List<double> kalorid = new List<double>();
            //kalorid.Add(265);
            //kalorid.Add(42);
            //kalorid.Add(52);
            //Console.WriteLine("Olete naine või mees? (naine/mees)");
            //string soo = Console.ReadLine();
            //Console.WriteLine("Palun sisetage oma kaal, pikkus ja vanus");
            //int kaal = int.Parse(Console.ReadLine());
            //double pikkus = double.Parse(Console.ReadLine());
            //int vanus = int.Parse(Console.ReadLine());
            //Console.WriteLine("Passiivne elustiil/1, Vähe tegevust/2, Mõõdukas aktiivsus/3, Kõrge aktiivsus/4, Väga kõrge aktiivsus/5");
            //string sport = Console.ReadLine();
            //double BOO = 0;
            //double calories = 0;
            //if (soo == "mees")
            //{
            //    BOO = 66 + (13.7 * kaal) + (5 * pikkus) - (6.8 * vanus);
            //}
            //else if (soo == "naine")
            //{
            //    BOO = 655 + (9.6 * kaal) + (1.8 * pikkus) - (4.7 * vanus);
            //}
            //if (sport == "1")
            //{
            //    calories = BOO * 1.2;
            //}
            //else if (sport == "2")
            //{
            //    calories = BOO * 1.375;
            //}
            //else if (sport == "3")
            //{
            //    calories = BOO * 1.55;
            //}
            //else if (sport == "4")
            //{
            //    calories = BOO * 1.725;
            //}
            //else if (sport == "5")
            //{
            //    calories = BOO * 1.9;
            //}
            //Console.WriteLine($"Teie kalorite norm päevas - {Math.Round(calories, 2)}");
            //foreach (var item in tooded)
            //{
            //    Console.Write(item + ", ");
            //}
            //Console.WriteLine();
            //foreach (int toode in kalorid)
            //{
            //    Console.WriteLine(Math.Round(calories / toode, 2));
            //}

            //4 Ülesanne
            //Console.WriteLine("1. Kõik riigid ja pealinnad \n2. Otsimine \n3. Uus sõna \n4. Test");
            //int vastus = int.Parse(Console.ReadLine());
            //Dictionary<string, string> countries = new Dictionary<string, string>
            //{
            //    {"Prantsusmaa", "Pariis"},
            //    {"Saksamaa", "Berlin"},
            //    {"Suur-Britannia", "London"}
            //};
            //if (vastus == 1)
            //{
            //    foreach (var pair in countries)
            //    {
            //        Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            //    }
            //}
            //else if (vastus == 2)
            //{
            //    string slovo = Console.ReadLine();
            //    string otsing = countries[slovo];
            //    Console.WriteLine(otsing);
            //}
            //else if (vastus == 3)
            //{

            //}
            //else if (vastus == 4)
            //{

            //}

            Console.ReadLine();
        }
    }
}
