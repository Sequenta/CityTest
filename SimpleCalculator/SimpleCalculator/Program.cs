using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main()
        {
            var calculator = new Calculator();
            Console.WriteLine("Введите аргументы и нажмите Enter");
            var firstArgument = int.Parse(Console.ReadLine());
            var secondArgument = int.Parse(Console.ReadLine());
            Console.WriteLine("+:{0}",calculator.Add(firstArgument,secondArgument));
            Console.WriteLine("-:{0}",calculator.Substract(firstArgument, secondArgument));
            Console.WriteLine("Нажмите любую клавишу, чтобы выйти...");
            Console.ReadKey();
        }
    }
}
