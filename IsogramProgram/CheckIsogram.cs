using System;

namespace IsogramProgram
{
    public class CheckIsogram
    {
        //public static void Main()
        //{
        //    Console.Write(IsIsogram(""));
        //    Console.ReadLine();
        //}
        public static bool IsIsogram(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (char.IsLetter(arr[i]))
                {
                    if (arr[i] == arr[i + 1])
                        return false;
                }
            }
            return true;
        }
    }
}
