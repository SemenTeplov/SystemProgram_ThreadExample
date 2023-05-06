using System;
using System.Threading;

namespace Homework1
{
    class Program
    {
        class Task1
        {
            public void Run() 
            {
                Thread tread1 = new Thread(() => Console.WriteLine("Минимальное значение " + inputValue().Min()));
                Thread tread2 = new Thread(() => Console.WriteLine("Максимальное значение " + inputValue().Max()));

                tread1.Start();
                tread2.Start();
            }
        }
        class Task2
        {
            public void Run()
            {
                string text = File.ReadAllText("test2.txt");

                int CountNumber()
                {
                    int count = 0;

                    foreach (char simbol in text)
                    {
                        if (Char.IsDigit(simbol)) count++;
                    }

                    return count;
                }

                int CountCharacter()
                {
                    int count = 0;

                    foreach (char simbol in text)
                    {
                        if (Char.IsLetter(simbol)) count++;
                    }

                    return count;
                }

                int SumNumber()
                {
                    int sum = 0;

                    foreach (char simbol in text)
                    {
                        if (Char.IsDigit(simbol)) sum += Convert.ToInt32(simbol);
                    }

                    return sum;
                }

                Thread tread1 = new Thread(() => Console.WriteLine("Количество чисел: " + CountNumber()));
                Thread tread2 = new Thread(() => Console.WriteLine("Количество символов: " + CountCharacter()));
                Thread tread3 = new Thread(() => Console.WriteLine("Сумма чисел: " + SumNumber()));

                tread1.Start();
                tread2.Start();
                tread3.Start();
            }
        }
        class Task3
        {
            public void Run()
            {
                IEnumerable<int> numbers = inputValue();

                Thread tread1 = new Thread(() => Console.WriteLine("Четное число: " + countNumberOddEven(numbers)[0]));
                Thread tread2 = new Thread(() => Console.WriteLine("Не четное число: " + countNumberOddEven(numbers)[1]));

                tread1.Start();
                tread2.Start();
            }
        }
        static int[] inputValue()
        {
            Console.WriteLine("Введите количество чисел: ");
            int[] numbers = new int[Convert.ToInt32(Console.ReadLine())];
            int i = 0;

            do
            {
                Console.WriteLine("Введите число: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            } while (i < numbers.Length);

            return numbers;
        }
        static int[] countNumberOddEven(IEnumerable<int> arr)
        {
            int[] numb = new int[2];

            foreach (int sibol in arr)
            {
                if (sibol % 2 == 0) numb[0]++;
                else numb[1]++;
            }

            return numb;
        }

        static void Main()
        {
            //Task1 task1 = new Task1();
            //Task2 task2 = new Task2();
            Task3 task3 = new Task3();

            //task1.Run();
            //task2.Run();
            task3.Run();
        }
    }
}