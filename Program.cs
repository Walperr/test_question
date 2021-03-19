using System;

namespace test_question
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("one");
            list.Add("three");
            list.Add("four");
            list.Add("seven");
            list.Add("zero");

            Console.WriteLine("------list-------");

            foreach (var i in list)
                Console.WriteLine(i);

            list.Remove();
            list.Remove();

            Console.WriteLine("------list_removed-------");

            foreach (var i in list)
                Console.WriteLine(i);

            List<int> a = new List<int>();

            a.Add(0);
            a.Add(2);
            a.Add(3);
            a.Add(5);

            List<int> b = new List<int>();

            b.Add(1);
            b.Add(4); 
            b.Add(6);
            b.Add(7);
            b.Add(8);
            b.Add(9);

            var Unitedab = List<int>.Unite(a, b);

            Console.WriteLine("------a-------");

            foreach (var i in a)
                Console.WriteLine(i);

            Console.WriteLine("------b-------");

            foreach (var i in b)
                Console.WriteLine(i);

            Console.WriteLine("-------a + b------");

            foreach (var i in Unitedab)
                Console.WriteLine(i);
        }
    }
}