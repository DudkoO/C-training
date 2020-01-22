using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Traning
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Program.menu();
        }
        public static void menu()
        {
            int act = 0;

            Console.WriteLine("1.Сложение чисел");
            Console.WriteLine("2.Сравнение чисел");
            Console.WriteLine("3.Случайное число");
            Console.WriteLine("4.Массив случайных чисел");
            Console.WriteLine("5.Список");
            Console.WriteLine("6.Двумерный массив");
            Console.WriteLine("6.Работа со строками");

            Console.WriteLine("Выберите действие:");
            act = Convert.ToInt32(Console.ReadLine());

            switch (act)
            {
                case 1:
                    addition();
                    break;
                case 2:
                    comparisonOfNumbers();
                    break;
                case 3:
                    randomNumber();
                    break;
                case 4:
                    array();
                    break;
                case 5:
                    list();
                    break;
                case 6:
                    TwoDimensionalArray();
                    break;
                case 7:
                    strings();
                    break;
                    
                default:
                    Console.WriteLine("Неверное действие!");
                    break;

            }


        }

        public static void addition()
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;
            Console.WriteLine("Введите число 1:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число 2:");
            num2 = Convert.ToDouble(Console.ReadLine());
            result = num1 + num2;
            Console.WriteLine(num1 + "+" + num2 + "=" + result);

        }

        public static void comparisonOfNumbers()
        {
            double num1 = 0;
            double num2 = 0;
            Console.WriteLine("Введите число 1:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число 2:");
            num2 = Convert.ToDouble(Console.ReadLine());
            if (num1 > num2)
                Console.WriteLine(num1 + ">" + num2);
            else
                Console.WriteLine(num1 + "<" + num2);


            //альтернативная запись
            string str = num1 < num2 ? "Число 1 больше числа 2" : "Число 1 меньше числа 2";
            Console.WriteLine(str);

        }
        public static void randomNumber()
        {
            Random random = new Random();
            int min = 0;
            int max = 0;
            int num = 0;
            Console.WriteLine("Введите минимум:");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимум:");
            max = Convert.ToInt32(Console.ReadLine());
            num = random.Next(min, max);
            Console.WriteLine("Случайное число:" + num);

        }

        public static void array()
        {
            Random random = new Random();
            int size = 10;
            Console.WriteLine("Введите размер массива:");
            size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(-100, 100);
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.Write(" \n");
        }
        public static void list()
        {
            Random random = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
                list.Add(random.Next(0,100));
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);

            list.RemoveAt(1);//удалить второй элемент
            list.Remove(10);//удалить  элементы с значением 10
        }
        public static void TwoDimensionalArray()
        {
            Random random = new Random();

            int x = 5;
            int y = 5;
            int[,] array = new int[x,y];

            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    array[i, j] = random.Next(0, 100);

            Console.WriteLine(array.Length+"\n");

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y ; j++)
                    Console.Write(array[i, j] + " ");
                Console.WriteLine("\t");
            }


            Console.WriteLine();



        }

        public static void strings()
        {
            string str = "";
            string str2 = "Hello";
            Console.WriteLine(String.IsNullOrEmpty(str));//является ли строка пустой
            Console.WriteLine(String.IsNullOrWhiteSpace(str));//является ли строка набором пробелов

            String.Compare("a", "b");//сравнение по алфавиту. возвращает разницу в количеству букв между аргументами
            
        }
    }
}
