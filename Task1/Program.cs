// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

namespace task1
{
    class Task1
    {
        static void RecursionPrintNumber(int fNumber, int sNumber)
        {
            Console.Write(fNumber);
            if (fNumber == sNumber) return;
            RecursionPrintNumber(++fNumber, sNumber);
        }

        static bool CheckFirstAndSecondNumbers(ref int fNumber, ref int sNumber)
        {
            if (fNumber <= sNumber) return true;
            else
            {
                int temp;
                temp = fNumber;
                fNumber = sNumber;
                sNumber = temp;
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число начала числового ряда: ");
            int firstNumber = int.Parse(Console.ReadLine()!);
            Console.Write("Введите натуральное число конца числового ряда: ");
            int secondNumber = int.Parse(Console.ReadLine()!);
            if (!CheckFirstAndSecondNumbers(ref firstNumber, ref secondNumber)) Console.WriteLine("Последовательность ваших чисел заменил.");

            RecursionPrintNumber(firstNumber, secondNumber);

        }
    }
}