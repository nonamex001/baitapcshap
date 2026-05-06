using System;
namespace bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so a : ");
          int a = int.Parse(Console.ReadLine()!);
            int [] arr = new int[a];
            for (int i=0; i < a; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()!);
            }
            for (int i=0; i < a; i++)
            {
                Console.Write(arr[i]+" ");
            }
            int max = arr[0];
            for (int i=0; i < a; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine();
            Console.Write("Gia tri lon nhat trong mang la: " + max);
            
        }
    }
}
