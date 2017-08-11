using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program1
    {
        delegate int IntOps(int n);

        static void ApplyOperation(int[] arr, IntOps ops)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ops(arr[i]);
            }
        }

        static void Main()
        {
            int[] A = new int[] { 1, 2, 3 };

            IntOps myOp = Add10;
            PrintArray(A);
            ApplyOperation(A, myOp);
            PrintArray(A);

            myOp = Minus1;
            PrintArray(A);
            ApplyOperation(A, myOp);
            PrintArray(A);

            myOp = Multiply2;
            PrintArray(A);
            ApplyOperation(A, myOp);
            PrintArray(A);
        }

        static double Sqrt(int x)
        {
            return Math.Sqrt(x);
        }
        static int Add10(int x)
        {
            return x + 10;
        }

        static int Multiply2(int x)
        {
            return 2 * x;
        }

        static int Minus1(int x)
        {
            return x - 1;
        }

        static void PrintArray(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
