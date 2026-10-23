using System;
using System.ComponentModel.Design.Serialization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace Program
{
    class Testing
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\r\n Введи номер задания");
                int number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Напиши своё имя");
                        string name = Console.ReadLine();
                        Console.WriteLine($"Привет, {name}");
                        break;
                    case 2:
                        int firstNumber = int.Parse(Console.ReadLine());
                        int secondNumber = int.Parse(Console.ReadLine());
                        if (secondNumber != 0) Console.WriteLine(firstNumber / secondNumber);
                        break;
                    case 3:
                        char alphabet = char.Parse(Console.ReadLine());
                        Console.WriteLine(++alphabet);
                        break;
                    case 4:
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        int c = int.Parse(Console.ReadLine());
                        int discriminant = b * b - 4 * a * c;
                        if (discriminant < 0) Console.WriteLine("Корней нет!");
                        else
                        {
                            double firstRoot = (-b + Math.Sqrt(discriminant)) / (2 * a);
                            double secondRoot = (-b - Math.Sqrt(discriminant)) / (2 * a);
                            Console.WriteLine($"{firstRoot}, {secondRoot}");
                            if (Math.Round(firstRoot * firstRoot * a + firstRoot * b + c) == 0) Console.WriteLine("Корни справедливы");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Введите X первой точки");
                        int firstx = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите Y первой точки");
                        int firsty = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите X первой точки");
                        int secondx = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите Y первой точки");
                        int secondy = int.Parse(Console.ReadLine());
                        int globalx = Math.Max(firstx, secondx) - Math.Min(firstx, secondx);
                        int globaly = Math.Max(firsty, secondy) - Math.Min(firsty, secondy);
                        Console.WriteLine(Math.Sqrt(globalx * globalx + globaly * globaly));
                        break;
                    default:
                        Console.WriteLine("Такое задание отсутствует");
                        break;
                }
            }
        } 
    }
}