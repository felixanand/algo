using System;
using System.Diagnostics;
using System.Reflection;

namespace DSAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch performanceMenasurement = new Stopwatch();
            performanceMenasurement.Start();

            //DoAmazonProblems();
            DoMicrosoftProblems();
            //DoOracleProblems();
            //LinkedListSingleImpl.Run();
            //ClassInitializer("BinaryTreeFromTraversal");

            performanceMenasurement.Stop();
            Console.WriteLine("Time Taken = {0}ms", performanceMenasurement.ElapsedMilliseconds);
        }

        public static void DoMicrosoftProblems()
        {
            //Add2NumberLinkedList solution = new Add2NumberLinkedList();
            //Merge2SortedLists solution = new Merge2SortedLists();
            //SpiralMatrix solution = new SpiralMatrix();
            //MinRotatedSortedArray solution = new MinRotatedSortedArray();
            //BinaryTreeInOrderTraversal solution = new BinaryTreeInOrderTraversal();
            //BinaryTreeLevelOrderTraversal solution = new BinaryTreeLevelOrderTraversal();
            //SetMatrixZero solution = new SetMatrixZero();
            //AddTwoNumbers2 solution = new AddTwoNumbers2();
            //ValidBST solution = new ValidBST();
            //MaxLengthOfNonRCChar solution = new MaxLengthOfNonRCChar();
            //CircularArrayPrint solution = new CircularArrayPrint();
            //MaxSubArrayProb solution = new MaxSubArrayProb();
            //RemoveDuplicateSortedArray solution = new RemoveDuplicateSortedArray();
            //MergeKSortedListLL solution = new MergeKSortedListLL();
            //ReverseInteger solution = new ReverseInteger();
            //KthSmallestBST solution = new KthSmallestBST();
            //PeakElement solution = new PeakElement();
            //Fibonacci solution = new Fibonacci();
            //ArrayProductExceptSelf solution = new ArrayProductExceptSelf();
            //MinHeapTest solution = new MinHeapTest();
            //ZigZag solution = new ZigZag();
            //RepeatedSubString solution = new RepeatedSubString();
            //MaxSubArrayProb solution = new MaxSubArrayProb();
            //MergeIntervals solution = new MergeIntervals();
            //UGraphTest solution = new UGraphTest();
            //TrieCheck solution = new TrieCheck();
            //LongestWordInDictionary solution = new LongestWordInDictionary();
            //LongestCommonPrefixSoln solution = new LongestCommonPrefixSoln();
            //LongestValidParan solution = new LongestValidParan();
            //CentsToChange solution = new CentsToChange();
            //SearchInsertPosition solution = new SearchInsertPosition();
            WordSearch solution = new WordSearch();
            solution.Run();
        }


        public static void DoAmazonProblems()
        {
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
            //solution.Run();
        }

        public static void DoOracleProblems()
        {
            //BinaryTreeFromTraversal solution = new BinaryTreeFromTraversal();
            //ParenthesisCreate solution = new ParenthesisCreate();
            //LeastBricksProblem solution = new LeastBricksProblem();
            //KthSortedList solution = new KthSortedList();
            //MedianOfSortedArray solution = new MedianOfSortedArray();
            //solution.Run();
        }


        public static void ClassInitializer(string className)
        {
            Type t = Type.GetType(className);
            var instance = Activator.CreateInstance(t);
            MethodInfo methodInfo = t.GetMethod("Run");
            methodInfo.Invoke(instance, null);
        }
    }

}
