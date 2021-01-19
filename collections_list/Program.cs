using System;
using System.Collections.Generic;

namespace collections_list
{
    class Program
    {
        public static void show(List<string> list)
        {
            foreach (var i in list)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();
        }
        static void Main(string[] args)
        {
            
            List<string> list = new List<string>();
            list.Add("Lahore");
            list.Add("Islamabad");
            list.Add("Multan");
            list.Add("Karachi");

            System.Console.WriteLine("//////////////////List////////////////////");
            show(list);

            System.Console.WriteLine("//////////////////Insert at index 2////////////////////");
            list.Insert(2, "Quetta");
            show(list);

            System.Console.WriteLine("//////////////////Remove///////////////////");
            list.RemoveAt(4);
            show(list);

            System.Console.WriteLine("//////////////////sort////////////////////");
            list.Sort();
            show(list);

            System.Console.WriteLine("//////////////////Binary Search////////////////////");
            int i = list.BinarySearch("Multan");
            System.Console.WriteLine(i);


            System.Console.WriteLine("//////////////////reverse////////////////////");
            list.Reverse();
            show(list);

            System.Console.WriteLine("//////////////////Merge two list////////////////////");
            List<string> list1 = new List<string>() { "Mumbai", "Delhi", "Kolkata" };
            list.InsertRange(4, list1);
            show(list);


        }
    }
}
