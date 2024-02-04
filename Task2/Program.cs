// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    // Если m = 0, то A(m, n) = n + 1
    // Если m > 0 и n = 0, то A(m, n) = A(m - 1, 1)
    // Если m > 0 и n > 0, то A(m, n) = A(m - 1, A(m, n - 1))

namespace task2
{
    class Task2
    {
        static int AckermanFunctions(int m, int n)
        {
            if (m == 0) return n + 1;
            else if (m > 0 && n == 0) return AckermanFunctions(m - 1, 1);
            else return AckermanFunctions(m - 1, AckermanFunctions(m, n - 1));
        }

        static void Main(string[] args)
        {
            Console.Write("Введите первое число для расчет функции Аккермана: ");
            int firstNumber = int.Parse(Console.ReadLine()!);
            Console.Write("Введите второе число для расчет функции Аккермана: ");
            int secondNumber = int.Parse(Console.ReadLine()!);

            Console.Write(AckermanFunctions(firstNumber, secondNumber));
        }

    }
}
