using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _27_10
{
    internal class bai3
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong phan tu n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            int tg = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("A[" + i.ToString() + "]=");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(" Day so A la: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i] + " ");
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (A[i] > A[j])
                    {
                        tg = A[i];
                        A[i] = A[j];
                        A[j] = tg;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(" Day so A tu be den lon la: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i] + " ");
            }
        }
    }
}
