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

            foreach (var i in list)
                Console.WriteLine(i);

            list.Remove();
            list.Remove();

            Console.WriteLine("-------------");

            foreach (var i in list)
                Console.WriteLine(i);
        }
    }
}