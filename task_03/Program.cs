using static System.Console;

internal class Program
{
    static void Main()
    {
        while (true)
        {
            int denominator = 2;
            bool flag = false;

            Write("\nВведите любое целое положительное число: ");
            int number = int.Parse(ReadLine());

            while (denominator < number)
            {
                if (number % denominator == 0
                    && denominator != number)
                {
                    flag = true;
                    break;
                }
                denominator += 1;
            }

            if (!flag)
                WriteLine($"Число {number} является простым числом.");
            else
                WriteLine($"Число {number} не является простым числом.");
        }
    }
}