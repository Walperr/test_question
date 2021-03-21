using System;

namespace test_question
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>(7);

            a = a.Add(5);
            a = a.Add(1);
            a = a.Add(2);
            a = a.Add(8);

            Console.WriteLine("-------a-------");

            foreach (var i in a)
                Console.WriteLine(i);

            var b = a.Add(45);

            Console.WriteLine("------b = a.add(45)------");

            foreach (var i in b)
                Console.WriteLine(i);

            Console.WriteLine("------c = b.remove()------");

            var c = b.Remove();

            Console.WriteLine("------c = b.remove()------");

            foreach (var i in c)
                Console.WriteLine(i);

            var t = List<int>.Unite(b, c);

            Console.WriteLine("------t = b + c------");

           foreach (var i in t)
                Console.WriteLine(i);

        }
    }
}
