using System;
using System.Diagnostics;
using MSFT;
using Amazon;

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
            //GroupedAnangrams solution = new GroupedAnangrams();
            //TwoSumProblem solution = new TwoSumProblem();
            //KthMissing solution = new KthMissing();
            //IntSlidingWindow solution = new IntSlidingWindow();   
            //FirstDuplicate solution = new FirstDuplicate();  
            //IslandProblem solution = new IslandProblem();  
            //RottingOranges solution = new RottingOranges();
            //MaxLenConcString solution = new MaxLenConcString();
            //KthDay solution = new KthDay();


            // Amazon Problems
            // ---------------
            //MostRepeatingWords solution = new MostRepeatingWords();
            //Zombie solution = new Zombie();

            RotateImage solution = new RotateImage();
            solution.Run();
            sw.Stop();
            Console.WriteLine("Elapsed Time = {0}ms", sw.ElapsedMilliseconds);
        }
    }
}
