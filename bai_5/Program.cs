using System;
using System.Text;

namespace bai_5
{
    class Program
    {

        static int Sum(int[] arr)//hàm tính tổng của một mảng số nguyên
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = {100,100,100,100,100,100,100,100};
            Console.WriteLine("chọn quả giả(1-8): ");
            int choice = int.Parse(Console.ReadLine()!);
            if (choice >= 1 && choice <= 8)
            {
                arr[choice - 1] = 90; // trừ 1 vì mảng bắt đầu từ 0
            }
            else
            {
                Console.WriteLine("Nhap sai!");
                return;
            }
            int[] A = new int[3];
            int[] B = new int[3];
            int[] C = new int[2];

            for (int i = 0; i < 3; i++) //duyệt các phần tử của cho mảng A và B
            {
                A[i] = arr[i];
                B[i] = arr[i + 3];
            }
            for (int i = 0; i < 2; i++) //duyệt các phần tử của cho mảng C
            {
                C[i] = arr[i + 6];
            }
            int sumA = Sum(A);
            int sumB = Sum(B);
           if (sumA == sumB) //nếu tổng của mảng A bằng tổng của mảng B
            {
                if (C[0] < C[1]) //so sánh mảng c để tìm ra vị trí của quả gia
                {
                    Console.WriteLine("Qua gia  vi tri: 7");
                }
                else
                {
                    Console.WriteLine("Qua gia  vi tri: 8");
                }
            }
            else  //nếu tổng của mảng A khác tổng của mảng B
            {
                if (sumA < sumB) // đặt nếu quả giả thuộc trong a
                {
                    if (A[0] < A[1]) // so sánh các phần tử của mảng A để tìm ra vị trí của quả gia
                    {
                        Console.WriteLine("Qua gia  vi tri: 1");
                    }
                    else if (A[0] > A[1])
                    {
                        Console.WriteLine("Qua gia  vi tri: 2");
                    }
                    else
                    {
                        Console.WriteLine("Qua gia  vi tri: 3");
                    }
                }
                else //  nếu quả giả thuộc trong b
                {
                    if (B[0] < B[1])// so sánh các phần tử của mảng B để tìm ra vị trí của quả gia
                    {
                        Console.WriteLine("Qua gia  vi tri: 4");
                    }
                    else if (B[0] > B[1])// so sánh các phần tử của mảng B để tìm ra vị trí của quả gia
                    {
                        Console.WriteLine("Qua gia  vi tri: 5");
                    }
                    else
                    {
                        Console.WriteLine("Qua gia  vi tri: 6");
                    }
                    Console.Write("Mang: ");
                    for (int i = 0; i < arr.Length; i++)// kiểm tra mang 
                    {
                        Console.Write(arr[i] + " ");
                    }
                    Console.WriteLine();
                }
             }
                        
        }
    }      
}
