using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of People: ");
            int TotalCount = Convert.ToInt16(Console.ReadLine());
            int[] inputArray = new int[TotalCount];
            int counter = 1;

            for (int index = 0; index < TotalCount; index++)
            {
                inputArray[index] = counter;
                counter++;
            }

            int survivor = RemoveAlternateElements(inputArray);
            Console.Write("{0}is the survivor", survivor);
            Console.ReadLine();
        }
        static int RemoveAlternateElements(int[] Number)
        {
            int TotalPeople = Number.Length;

            if (TotalPeople == 1)
                return Number[0];

            int[] OutputArray = new int[(TotalPeople + 1) / 2];

            int LengthOfoutputArray = 0;
            for (int index = 0; index < TotalPeople; index += 2)
            {

                OutputArray[LengthOfoutputArray] = Number[index];
                LengthOfoutputArray++;
            }

            if (TotalPeople % 2 == 0)
                return RemoveAlternateElements(OutputArray);
            else
            {
                int[] outputArray = new int[(TotalPeople + 1) / 2];
                for (int index = 1; index < LengthOfoutputArray; index++)
                {
                    outputArray[index] = OutputArray[index - 1];
                    outputArray[0] = OutputArray[index];
                }

                return RemoveAlternateElements(outputArray);
            }
        }

    }
}