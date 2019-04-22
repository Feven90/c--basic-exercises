using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class MultiplyingThreeNumbers
    {
        public void NumberMultiplication()
        {
            Console.WriteLine("/nAdd first number: ");
            var firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("/nAdd second number");
            var secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("/nAdd third number");
            var thirdNumber = int.Parse(Console.ReadLine());
            var multiplicationResult = ($"/nthe result of {firstNumber} * {secondNumber} * {thirdNumber} is {firstNumber * secondNumber * thirdNumber}");
            Console.WriteLine(multiplicationResult);
        }
    }
}
