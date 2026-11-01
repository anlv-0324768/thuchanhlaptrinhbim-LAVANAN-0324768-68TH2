using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _27_10
{
    internal class bai12
    {

        static void Main(string[] args)
        {
            int[] A = new int[100];
            int[] B = new int[100];

            Console.Write("Nhap so luong phan tu n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("A[=" + i.ToString() + "]=");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadLine();



        }
    }
}

