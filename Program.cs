using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Receiving array with numbers
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            // 2. Left side is leftCar, right side is rightCar, middle index is a final
            List<int> leftCar = new List<int>(numbers.Count / 2);
            leftCar = numbers.Take((numbers.Count) / 2).ToList();
            List<int> rightCar = new List<int>(numbers.Count / 2);
            rightCar = numbers.Skip((numbers.Count + 1) / 2).ToList();
            rightCar.Reverse();
            // 3. Sum leftCar numbers and rightCar numbers
            double leftCarSum = 0;
            for (int i = 0; i < leftCar.Count; i++)
            {
                // 4. If there is a 0, reduce by 20% and continue summing
                if (leftCar[i] == 0)
                {
                    leftCarSum = leftCarSum * 0.8;
                }
                else
                {
                    leftCarSum += leftCar[i];
                }

            }
            double rightCarSum = 0;
            for (int i = 0; i < rightCar.Count; i++)
            {
                if (rightCar[i] == 0)
                {
                    rightCarSum = rightCarSum * 0.8;
                }
                else
                {
                    rightCarSum += rightCar[i];
                }

            }
            // 5. Print: The winner is {left/right} with total time: {total time}"
            if (leftCarSum < rightCarSum)
            {
                Console.WriteLine($"The winner is left with total time: {leftCarSum}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightCarSum}");
            }

        }
    }
}
