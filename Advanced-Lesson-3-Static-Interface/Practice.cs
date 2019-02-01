using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_3_Static_Interface
{
    public partial class Practice
    {
        /// <summary>
        /// AL3-P1/3. Создать класс UniqueItem c числовым полем Id. 
        /// Каждый раз, когда создается новый экземпляр данного класса, 
        /// его идентификатор должен увеличиваться на 1 относительно последнего созданного. 
        /// Приложение должно поддерживать возможность начать идентификаторы с любого числа. 
        /// </summary>
        public static void AL3_P1_3()
        {
            for (int i = 0; i < 100; i++)
            {
                PracticeID a = new PracticeID();
            }
            Console.WriteLine(PracticeID.id);
            
        }

        public class PracticeID
        {
            public static int id { get; private set; }
            public string name;

            public PracticeID()
            {
                id++;
            }

            static PracticeID()
            {
                id = 1000;
            }
        }



        /// <summary>
        /// AL3-P2/3. Отредактировать консольное приложение Printer. 
        /// Заменить базовый абстрактный класс на интерфейс.
        /// </summary>
        public static void AL3_P2_3()
        {

        }


        /// <summary>
        /// AL3-P3/3. Создайте обобщенный метод GuessType<T>(T item), 
        /// который будет принимать переменную обобщенного типа и выводить на консоль, 
        /// что это за тип был передан.
        /// </summary>
        public static void AL3_P3_3()
        {

        }

        public static void GuessType<T>(T enterString)
        {
            switch (enterString)
            {
                case string item:
                    Console.WriteLine($"Enter type — {item.GetType().Name}");
                    break;
                case int item when item < 0:
                    Console.WriteLine($"Enter type — {item.GetType().Name} less than zero");
                    break;
                case int item when item > 0:
                    Console.WriteLine($"Enter type — {item.GetType().Name} more than zero");
                    break;
                case DateTime item:
                    Console.WriteLine($"Enter type — {item.GetType().Name}");
                    break;
                case double item:
                    Console.WriteLine($"Enter type — {item.GetType().Name}");
                    break;
                

                default:
                    Console.WriteLine("I don't know what you put in me");
                    break;


            }
        }


    }    
}
