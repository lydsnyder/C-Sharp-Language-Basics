using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Basics
    {
        static void Main(string[] args)
        {

            const byte sample1 = 0x3A;
            byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            const float acceleration = 9.800F;
            float mass = 14.6F;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            const char integral = '\u222B';
            const string greeting = "Hello";
            string name = "Karen";

            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal\n");
            }
            else
            {
                Console.WriteLine("The samples are not equal.\n");
            }

            if( heartRate >= 40 && heartRate <= 80 )
            {
                Console.WriteLine("Heart rate is normal.\n");
            }
            else
            {
                Console.WriteLine("Heart rate is not normal.\n");
            }

            if( deposits >= 100000000 )
            {
                Console.WriteLine("You are exceedingly wealthy.\n");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor.\n");
            }

            float force = (mass * acceleration);

            Console.WriteLine("force = " + force + "\n");

            Console.WriteLine(distance + " is the distance.\n");

            if (lost == true)
            {
                if (expensive == true)
                {
                    Console.WriteLine("I am really sorry! I will get the manager.\n");
                }
                else
                {
                    Console.WriteLine("Here is coupon for 10% off.\n");
                }
            }

            switch(choice) {
               case 1:
                    Console.WriteLine("You chose 1.\n");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.\n");
                    break;
                case 3:
                    Console.WriteLine("You chose 3.\n");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.\n");
                    break;
            }

            Console.WriteLine(integral + " is an integral");


            for (int i = 5; i < 11; i++)
            {
                Console.WriteLine("i = " + i + "\n");
            }

            int age = 0;


            while (age < 6)
            {
                Console.WriteLine("age is " + age + "\n");
                age++;
            }

            Console.WriteLine(greeting + ", " + name + "\n");
        }
    }
}
