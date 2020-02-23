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
            //ReverseString solution = new ReverseString();
            //ReverseLinkedList solution = new ReverseLinkedList();
            //IntersectionLinkedList solution = new IntersectionLinkedList(); //Not Wokring            
            //ValidPalindrome_LC125 solution = new ValidPalindrome_LC125();
            //LinkedListCycle_141 solution = new LinkedListCycle_141();
            //PhoneNumbers_17 solution = new PhoneNumbers_17();
            //SortColors_75 solution = new SortColors_75();
            //StringToIntATOI_8 solution = new StringToIntATOI_8();
            //ValidParanthesis_20 solution = new ValidParanthesis_20();
            //LongestPalindromeSubstring_5 solution = new LongestPalindromeSubstring_5();
            //ReverseString_334 solution = new ReverseString_334();
            //ReverseString2_186 solution = new ReverseString2_186(); 
            //MostRepeatingWords solution = new MostRepeatingWords();
            //Zombie solution = new Zombie();
            //RotateImage solution = new RotateImage();
            //ThirdMaxProblem solution = new ThirdMaxProblem();            

            //Add2NumberLinkedList solution = new Add2NumberLinkedList();
            Merge2SortedLists solution = new Merge2SortedLists();
            
            solution.Run();
            sw.Stop();
            Console.WriteLine("Elapsed Time = {0}ms", sw.ElapsedMilliseconds);
        }
    }
}
