using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[100];
            input[0] = 1;

            for (int index = 1; index < input.Length; index++)
            {

                input[index] = (index + 1);

            }

            int finalanswer = RemoveAlternateElements(input);












            Console.WriteLine(finalanswer);

            Console.ReadLine();
        }


        static int RemoveAlternateElements(int[] input)
        {
            int count = input.Length;

            if (count == 1)
            {
                return input[0];
            }


            int oindex = 0;


            int[] output = new int[(count + 1) / 2];


            for (int index = 0; index < input.Length; index=index+2)
            {
                output[oindex] = input[index];
                oindex++;
            }
            if (count % 2 == 0)
            {

                return RemoveAlternateElements(output);
            }
            else
            {
                int[] output2 = new int[((count + 1) / 2)];
                {
                    for (int index = 1; index < output.Length; index++)
                    {
                        output2[index] = output[index - 1];
                        output2[0] = output[index];

                    }
                    return RemoveAlternateElements(output2);



                }


            }

        }
    }


}

            

         


        



    
    






