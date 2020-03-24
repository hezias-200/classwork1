using System;


namespace Classwork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose 2 numbers:");//Print on the screen ----> Choose 2 numbers:
            int lengthOfarray = Convert.ToInt32(Console.ReadLine());//I defined variable and choose my number from the console and convert him to integer
            int numOfmull = Convert.ToInt32(Console.ReadLine());//I defined variable and choose my number from the console and convert him to integer  
            int[] arr2 = new int[lengthOfarray];//I defined array in size of number that i chose before ,in name "lengthOfarray"
            for (int i = 0; i < arr2.Length; i++)//הרצתי לולאה עד גודל המערך 
            {
                arr2[i] = i * numOfmull;//הגדרתי שהאיבר במקום האינדקס יהיה שווה לאינדקס כפול המספר שבחרתי להכפיל לפני בשם "numOfmull"


                Console.Write(arr2[i] + " , ");//מדפיס את המערך עם פסיקים ורווחים
            }
            Console.WriteLine("\n");//ירדתי שורה
            Console.WriteLine($"num of elements:{lengthOfarray}"); //הדפסתי את המשתנה הראשון שהוא בעצם גודל המערך
            Console.WriteLine($"num of elements:{numOfmull}");//הדפסתי את המשתנה השני שהוא בעצם הכפלת של האינדקסים 
            Console.ReadKey();
        }
    }
}
