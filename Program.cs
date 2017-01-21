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
            int[] input = new int[10];
                for (int index = 1; index <= 10; index += 2)
                {

                    input[index] = index;
                    index++;
                }

            int[] output = RemoveAlternateElements(input);
            Console.WriteLine("1st");
            int[] finalanswer=new int [output.Length];
            Console.WriteLine("2nd");

                while (finalanswer.Length <1)
                {
                    Console.WriteLine("2nd");
                    finalanswer = RemoveAlternateElements(output);
                }

                foreach (int v in finalanswer)
                {
                    Console.WriteLine(v);
                }
                Console.ReadLine();
            }


        static int[] RemoveAlternateElements(int[] input)
        {
              int temp, oindex = 1;
            
                if (input.Length % 2 == 0)
                {
                    temp = (input.Length / 2);
                }
                else
                {
                    temp = (input.Length / 2) + 1;
                }

            int[] output = new int[temp];

               for (int index = 0; index<=temp; index =index+1)
               {
                
                    
                output[oindex] = input[index];
                

            }
           
            return output;
            //determine the size of o/p array//
            //define an array=output array;
            // iterate through input array and pick alternate elements
            //return output//

        }

    }

}


