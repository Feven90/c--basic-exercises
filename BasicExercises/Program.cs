using System;

namespace BasicExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SwapNumbers swapNumbers = new SwapNumbers();
            swapNumbers.swap();
            

            MultiplyingThreeNumbers multiplyNumbers = new MultiplyingThreeNumbers();
            multiplyNumbers.NumberMultiplication();
            Console.ReadLine();
        }
    }
}
