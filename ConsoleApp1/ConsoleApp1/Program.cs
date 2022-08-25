using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomClass<int> T = new CustomClass<int>();
            T.Add(23);
            T.Add(24);
            T.Add(7);
            T.Add(30);
            T.IndexOf(3);
            T.Add(4);
            T.Exist(10);
            T.LastIndexOf(2);
            T.Clear();

        }
    }
}   
