using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int C = 0;

            Console.Write("Введiть частину завдання, яку бажаєте виконати: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Виконується " + a + " частина лаби");
            if (a == 1)
            {
                first(k, C);
            }


            else if ( a == 2)
            {
                var buildings = new Dictionary<int, string>()

                {

                {7, "Театр на подолi" },
                {1, "Посольство Королевства Нiдерланди" },
                {9, "Kyiv Food Market" },
                {6, "Юнiт Сiтi" },
                {10, "Сага Сiтi Спейс" },
                {3, "IQ Business Center" },

                };

                foreach (var pair in buildings.OrderBy(pair => pair.Key))
                {
                    Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
                };


                string json = JsonConvert.SerializeObject(buildings.OrderBy(pair => pair.Key), Formatting.Indented);
                Console.WriteLine("Контент json: " + json); //виводимо контент json



                int dicLength = buildings.Count;
                Console.WriteLine("Кiлькiсть значень: " + dicLength);

                int product = 1;
                foreach (var i in buildings.Keys)
                {
                    int[] mass = new int[] { i };
                    product *= i;
                }
                Console.WriteLine("Добуток ключiв" + product);


                

            }

            else if (a == 3)
            {
                third();
            }
        }



        static void first(int k, int C)
        {
            var cili = new List<int>() { 0, -1, 2, -3, 4, -5, 6, -7, 8, 9 };

            Console.Write("Введiть k = ");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("коефiцiент k =" + k);
            if (k > 9)
            {
                Console.WriteLine("Iндекс виходить за межi списку!");
                Environment.Exit(0);
            }
            else if (k < 1)
            {
                Console.WriteLine("Iндекс виходить за межi списку!");
                Environment.Exit(0);
            }

            Console.Write("Введiть C = ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("значення С = " + C);

            cili.Insert(k - 1, C);

            foreach (int i in cili)
            {
                Console.WriteLine(i + " ");
            }

        }


        static void third()
        {
            
            List<string> ryadky = new List<string>();
            Console.WriteLine("Створiть список: ");

            bool listIsFilled = false;

            while (listIsFilled == false)
            {
                string listElement = Console.ReadLine();
                if (listElement == "stop")
                {
                    listIsFilled = true;
                    break;
                }
                ryadky.Add(listElement);
            }
            Console.WriteLine("////////////////////////////////////////////////////");
            foreach (string element in ryadky)
            {
                Console.Write(element + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("////////////////////////////////////////////////////");


            Console.WriteLine(ryadky.Aggregate("", (a, b) => a + b.First()));

        }
    }
}
