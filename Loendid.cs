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
            //LinkedList<int> numbrid = new LinkedList<int>();
            //Random rnd = new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //    numbrid.AddLast(int.Parse(Console.ReadLine()));
            //}
            //LinkedList<int>.Enumerator ahel = numbrid.GetEnumerator();
            //while (ahel.MoveNext())
            //{
            //    Console.Write(ahel.Current+" ");
            //}
            //int j = 0;
            //foreach (int item in numbrid)
            //{
            //    if (j == 0)
            //    {

            //    }
            //    j++;
            //}


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
            //    Console.Write(number+" ");
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
            List<string> tooded = new List<string>();
            List<double> kalorid = new List<double>();
            Console.WriteLine("Olete naine või mees? (woman/man)");
            string soo = Console.ReadLine();
            Console.WriteLine("Palun sisetage oma kaal, pikkus ja vanus");
            int kaal = int.Parse(Console.ReadLine());
            int pikkus = int.Parse(Console.ReadLine());
            int vanus = int.Parse(Console.ReadLine());
            Console.WriteLine("1/1,2/2,3/3,4/4,5/5");
            string sport = Console.ReadLine();
            if (soo == "man")
            {
                double ВОО = 66 + (13.7 * kaal) + (5 * pikkus) - (6.8 * vanus);
            }
            else if (soo == "woman")
            {
                double ВОО = 655 + (9.6 * kaal) + (1.8 * pikkus) - (4.7 * vanus);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Vale vastus");   
            }
            Console.WriteLine(BOO);
            if (sport == "1")
            {
                double calories = BOO * 1.2;
            }
            else if (sport == "2")
            {
                double calories = BOO * 1.375;
            }
            else if (sport == "3")
            {
                double calories = BOO * 1.55;
            }
            else if (sport == "4")
            {
                double calories = BOO * 1.725;
            }
            else if (sport == "5")
            {
                double calories = BOO * 1.9;
            }
            else
            {
                Console.WriteLine("Vale vastus");
            }
            Console.WriteLine($"Teie kalorite norm päevas - {calories}");
            //4 Ülesanne








            Console.ReadLine();
        }
    }
}
