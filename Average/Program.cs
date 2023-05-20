using System;

namespace Average
{
    class Program
    {
        static double CalculateNormalAverage(int[] numbers)
        {
            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
        }

        static double CalculateGeometricAverage(int[] numbers)
        {
            double product = 1;
            foreach (int number in numbers)
            {
                product *= number;
            }
            return Math.Pow(product, 1.0 / numbers.Length);
        }

        static double CalculateHarmonicAverage(int[] numbers)
        {
            double sum = 0;
            foreach (int number in numbers)
            {
                sum += 1.0 / number;
            }
            return numbers.Length / sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements: ");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];
            Console.WriteLine("Enter the numbers:");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            double normalAverage = CalculateNormalAverage(numbers);
            double geometricAverage = CalculateGeometricAverage(numbers);
            double harmonicAverage = CalculateHarmonicAverage(numbers);

            Console.WriteLine("Normal Average: " + normalAverage);
            Console.WriteLine("Geometric Average: " + geometricAverage);
            Console.WriteLine("Harmonic Average: " + harmonicAverage);

            Console.ReadLine();
        }
    }
}
