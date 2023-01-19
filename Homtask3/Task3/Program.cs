using System;
using System.Dynamic;
using System.Net.WebSockets;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.VisualBasic;

namespace Hometask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1 Verilmis ededler siyahisindaki ed en kiciyini tapan medhod
            int[] nums = { 7, 13, 33, 39, 8, 77, 70 };
            int result = MinNumber(nums);
            Console.WriteLine(result);
            #endregion
        }
        static int MinNumber(int[] nums)
        {
            #region
            int min = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    nums[i] = min;
                }
            }
            return min;
            
        }
        #endregion

        #region Task 3 : Verilmiş ədədlər siyahısında verilmiş ədədin yerləşdiyi indexi tapan metod, əgər həmin ədəd siyahıda yoxdursa 
        #region -1 qaytarsın, varsa ilk yerləşdiyi indexi.

        int[] num = { 7, 13, 40, 65, 120 };
        VariantType result0 = IndexOfNumber(MinNumber, 120);
        Consele.Writeline(result0);
            #endregion

        static int IndexOfNumber(int[] num, int dig)
        {
           #region
            for (int i =0; i < num.Length; i++)
            {
                if (num[i] == dig)
                {
                    return i;
                }
            }
            return -1;
            #endregion

        }
           
        #region Task 4: Verilmiş yazını əksinə çevirən metod
            Console.Writeline("Enter the script");
            string word2 = Console.ReadLine();
            var result5 = OppsiteWord(word1);
            Console.Writeline(result5);
            #endregion

            static string OppositeWord(string word2)
        {
            #region
            string oppoString = "";
            for (int i = word2.Length - 1; i >= 0; i--)
            {
                oppoString = oppoString + word2[i];
            }
            return oppoString;
            #endregion
        }

        #region Task 2:  Verilmiş yazıda verilmiş chardan neçə ədəd olduğunu tapan metod
        Console.Write("Enter the word: ");
        string word1 = Console.ReadLine();
        Console.Writeline("Enter the number");
        char wantChar = Convert.ToChar(Console.ReadLine());
        var result2 = Char(word1, wantChar);
        Console.Writeline(result2);
        #endregion

            static int Char(string word1,char cr1)
        {
              #region
              int count = 0;
              for (int i = 0; i < word1.Length; i++)
            {
                if (word1[i] == cr1)
                {
                    count++;
                }
            }
            return count;
            #endregion 

        }

        #region Task 5 : Verilmiş yazıda rəqəm olub olmadığını tapan metod
        static bool IsDigit(string str, char num)
        {
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int j =0; j < numbers.Length; j++) 
            {
                for(int i=0; i < str.Length; i++)
                {
                    if (str[i] == numbers[j])
                    {
                        return true;
                    }
                }

            }
            return false;
            
            


            
        }









    }
}
