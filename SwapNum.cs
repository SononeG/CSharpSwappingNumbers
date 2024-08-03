using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingNumbers
{
    internal class SwapNum
    {
        //write a program where the first and last character of a string swap ends
        public static void SwapEnds(string ustr)
        {
                string result;

               if (ustr.Length > 1)
                result = ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1);
               else
                result = ustr;


            Console.WriteLine($"resultant string after swapping end characters:{result}");
        }
        public static void SwapNumbers()
        {
            //swapping Numbers using third variabl
            //***********using 3rd variable*********
            string A = "Kshitij", B = "Aakash", C = "";
            Console.WriteLine($"Before Swapping A={A} and B={B}");
            C = A;
            A = B;
            B = C;
            Console.WriteLine($"After Swapping A={A} and B={B}");

            //*********using XOR Bitwise Operator******
            bool X = true , Y = false;
            Console.WriteLine($"Before Swapping X={X} and Y={Y}");
            X = X ^ Y;//
            Y = Y ^ X; // =Y^(X^Y)=(Y^Y)^X=0^X=X  
            X = X ^ Y; // =X^Y^X = X^X^Y = 0^Y =Y

            Console.WriteLine($"Swapping using XOR X={X} and Y={Y}");

            //Swapping numbers using * / operator
            long a = 231313, b = 43313;
            Console.WriteLine($"a={a} b={b}");
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine($"swapping using * and / a={a} b={b}");

            //Using + - operator
            double i = 2313.31231, j = 1231.313;
            Console.WriteLine($"Before i={i}, j={j}");

            i = i + j;
            j = i - j;
            i = i - j;

            Console.WriteLine($"After swapping using + and - operator i={i}, j={j}");


        }

        public static void ReverseWord( string word )
        {
            char[] chararrayword = word.ToCharArray();
            Array.Reverse(chararrayword);
            string reverseWord = new string (chararrayword);
            
            Console.WriteLine($"Reversed word :{reverseWord}");
            string reverseWord1 = new string(word.Reverse().ToArray());
            Console.WriteLine($"Reversed string of {word} is {reverseWord1}");
        }

    }
}
