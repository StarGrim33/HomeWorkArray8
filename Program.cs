namespace HomeWorkArray8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            int leftShiftInput = 0;
            int temporary = 0;

            Console.WriteLine("Массив: ");
            foreach (int number in numbers)
            {
                Console.Write(number + ",");
            }

            Console.WriteLine("\nВведите цифрой количество сдвигов массива влево: ");
            leftShiftInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Массив со сдвигом на " + leftShiftInput + " шаг(ов)");

            for (int i = 0; i < leftShiftInput; i++)
            {
                leftShiftInput = leftShiftInput % numbers.Length;
                temporary = numbers[0];

                for (int j = 0; j < numbers.Length-1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers[numbers.Length - 1] = temporary;

            }

            foreach (int number in numbers)
            {
                Console.Write(number + ",");
            }

        }
    }
}