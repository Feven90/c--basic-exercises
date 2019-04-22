using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class SwapNumbers
    {
        public void swap()
        {
            int number1, number2, temp;
            Console.Write("\nInput the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;    // if we don't have temp once we change number1= number2 then the value of number1 will be lost and when we do number2=number1 at this time number1 already has the value of number2 so number2 will stay the same. 
            number1 = number2;
            number2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);
            Console.Read();
        }
    }
}
