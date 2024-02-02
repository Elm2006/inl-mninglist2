using System;
using System.Collections.Generic;
namespace inlämninglist2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);   
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(0);
            Console.WriteLine(Max(list));
        }
        static int Max(List<int> list)
        {
            list.Sort();
            list.Reverse();
            int x = list[0];
            return x;

        }
    }
}
