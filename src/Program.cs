using System;
using System.Diagnostics;

namespace DSAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //MissingNumbers solution = new MissingNumbers();            
            //MostCommonWordAlgo solution = new MostCommonWordAlgo();
            //FirstNonRepeatingCharacter solution = new FirstNonRepeatingCharacter();
            //SingleNumber solution = new SingleNumber();            
            //PowerOfTwo solution = new PowerOfTwo();
            //WaterContainer solution = new WaterContainer();
            //BinaryArraySearch solution = new BinaryArraySearch();
            //BinarySearchTree solution = new BinarySearchTree();
            GroupedAnangrams solution = new GroupedAnangrams();
            solution.Run();
            sw.Stop();
            Console.WriteLine("Elapsed Time = {0}ms", sw.ElapsedMilliseconds);
        }
    }
}
