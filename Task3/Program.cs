// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

namespace task3
{
    class Task3
    {
        static void ShowArray(int[] nums, int n)
        {
            if (n == 0)
            {
                Console.Write($"{nums[n]}");
                return;
            }
            Console.Write($"{nums[n]}, ");
            ShowArray(nums, --n);
        }
        
        

        static void Main(string[] args)
        {
            int[] nums = {1, 3, 5, 7, 8, 10, 5, 3};
            ShowArray(nums, nums.Length - 1);
        }
    }
}