using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int row,col;

            Console.WriteLine("Size Of Matrix?");//הכנסת גודל מטריצה
            int Number = Convert.ToInt32(Console.ReadLine());
            string [][] Matrix = new string[Number][];//בניית מטריצה לפי הגודל שהמשתמש בחר
            for ( row = 0; row < Matrix.Length; row++)//לולאת פור על השורות
            {
               Matrix[row] = new string [Matrix.Length];//מכניס סטרינגים לשורות 
                
                for (col = 0; col < Matrix.Length; col++)//לולאת פור על העמודות
                {
                     if (Matrix.Length % 2 != 0 && Matrix.Length / 2 == row && Matrix.Length / 2 == col)//בודק האם המטריצה בגודל אי-זוגי אם כן יכניס סנטר
                    {
                        Matrix[row][col] = " center";
                    }

                    else if (row == col )//הכנסתי את כל התנאים לפי שביקשת
                    {
                        Matrix[row][col] = " main";
                    }
                    
                    else if (row + col == Matrix.Length - 1)
                    {
                        Matrix[row][col] = " sub";

                    }
                    else if (row < col && col+row!=Matrix[row].Length-1)
                    {
                        Matrix[row][col]= " up";

                    }
                    else if (row > col)
                    {
                        Matrix[row][col] = " down";

                    }
                    
                }
                


            }
            foreach (string [] s in Matrix)//הדפסת המטריצה
            {
                foreach (string s2 in s)
                {
                    Console.Write($"{s2}");

                }
                Console.WriteLine();


            }
            Console.ReadKey();

        }
        
            
            


            
        }
    }

