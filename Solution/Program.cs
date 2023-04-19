using BenchmarkDotNet.Running;
using Solution.Answers;
using Solution.Banchmarks;

//HasPathSum.Run();
//LetterCombinations.Run();
//StringtoIntegerAtoi.Run();
//SudokuSolver.Run();
//ThreeSum.Run();
//IntegerToRoman.Run();
//ZigzagConversion.Run();
//LongestSubstringWithoutRepeatingCharacters.Run();
//ThreeDigitLock.Run();
//PlusOne.Run();
//MaximumSubarray.Run();
//ValidParentheses.Run();
//LongestPalindromicSubstring.Run();
//ImplementStrStr.Run();
//ReverseInteger.Run();
//RemoveDuplicatesFromSortedArray.Run();
//LongestCommonPrefix.Run();
//PalindromeNumber.Run();
//MergeTwoSortedLists.Run();
//AddTwoNumbers.Run();
//RomantoInteger.Run();
//TwoSum.Run();
//MaxArea.Run();
//FourSum.Run();
//GenerateParenthesis.Run();
//MyPow.Run();
//UniquePaths.Run();

BenchmarkRunner.Run<UniquePathsBanchmarks>();


//Working working = new Working();
//Animal animal1 = new Horse();
//working.DoSomething(animal1);
////Console.WriteLine(animal1.GetType().Name);
//working.DoSomething((dynamic)animal1);
////Console.WriteLine(animal1.GetType().Name);

//public class Animal{}

//public class Horse : Animal{}

//public class Working
//{
//    public void DoSomething(Animal animal)
//    {
//        Console.WriteLine("Animal");
//    }
//    public void DoSomething(Horse horse)
//    {
//        Console.WriteLine("Horse");
//    }
//}