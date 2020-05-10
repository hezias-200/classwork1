using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace lesson_7
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Cookies c1 = new Cookies();
            c1.CountOfSugar = 2.5;
            c1.Flour = 4.8;
            c1.Gloten = true;
            c1.NumOfEgss = 5;

            Cookies c2 = new Cookies();
            c2.CountOfSugar = 3;
            c2.Flour = 8;
            c2.Gloten = false;
            c2.NumOfEgss = 4;

            

            Cookies c3 = new Cookies();

            Description(c1);
            Console.WriteLine();
            Description(c2);
            Console.WriteLine();
            c1.CountOfSugar = 15;
            Description(c1);
            Console.WriteLine();
            Description(c2);
            Console.WriteLine();
            c2 = c1;
            c2.NumOfEgss = 7;
            Description(c1);
            Console.WriteLine();
            Description(c2);

            Cars car1 = new Cars();
            car1.SpeedNow = 10;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Car 1:");
            Console.WriteLine("speed now:" +car1.SpeedNow+"\nspeed down:" + car1.SpeedDown + "\nSpeed Up:"+car1.SpeedUp);
            Console.WriteLine("How much Do You Want to Up the speed?");
            int s = Convert.ToInt32(Console.ReadLine());
            car1.SpeedNow = car1.SpeedNow + s;
            Console.WriteLine("After Up The Speed Now Is:" + car1.SpeedNow);
            car1.SpeedNow = car1.SpeedNow - 2;
            Console.WriteLine("After Down The Speed Now Is:" + car1.SpeedNow);
            car1.StopCar();
            Console.WriteLine("The Car Is Stoped!!! :" + car1.SpeedNow);










            Console.ReadKey();


        }
        public static void  Description(Cookies c)
        {
            Console.WriteLine("Count Of Sugar:" + c.CountOfSugar + "\nCount Of Flour: " + c.Flour + "\nCount Of Eggs:" + c.NumOfEgss + "\nWith Gloten:" + c.Gloten);
        }
         
        
    }
}
