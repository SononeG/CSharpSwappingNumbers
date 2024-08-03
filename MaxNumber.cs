using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SwappingNumbers
{
    internal class MaxNumber
    {
        public static void FindMaxNumber() 
        {
            //printing araay in specified format...removing last element in each teration
            int[] num = [50, 4, 7, 2,1];

            for (int i = 0; i < num.Length; i++)
            {                
                for (int j = 0; j < num.Length - i; j++)
                {
                    Console.Write(num[j] + " ");//this wll print the array in single line

                }
                Console.WriteLine(""); //to print the next series on new line

            }

            // print the max number from the array - using Max() method
           Console.WriteLine("Max number using Max() method is  :"+ num.Max());

            // using for loop and if condition
            int maxnum = num[0];
            
                for (int i = 1; i < num.Length; i++)
                {
                    if (num[i] > maxnum)

                        maxnum = num[i];
                       
                }
            

            Console.WriteLine($"Max Number using for loop is :{maxnum}");
//********************************************************Generic collections Stack and Queue****************
//stck is LIFO 
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            // Queue is FIFO
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
        }
    }
}
