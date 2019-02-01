using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_3_Static_Interface
{
        class Program
        {
            static void Main(string[] args)
            {
                Practice.AL3_P1_3();

            //Lesson.RentPointsExample();

            Practice.GuessType<int>(777);
            Practice.GuessType<int>(-8);
            Practice.GuessType<string>("Hello there");
            Practice.GuessType<DateTime>(DateTime.Now);
            Practice.GuessType<double>(-25.5);
            


            Console.ReadLine();
            }
        }

        

}
