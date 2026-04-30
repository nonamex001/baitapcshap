using System;
using System.Text;
namespace bai_2

{
    class  Bai_2
    {
         static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.Write("nhap so a= ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("nhap so b= ");
            int b= int.Parse(Console.ReadLine()!);
            Console.Write("nhap so c= ");
            int c= int.Parse(Console.ReadLine()!);
            if (a == 0)
            {
                if(b==0)
                {                  
                    if (c == 0)
                    {
                        Console.Write("phương trình vô số nghiệm");
                    }
                    else
                    {
                        Console.Write("phương trình vô nghiệm") ;
                    }
                }
                else
                {
                     
            
                    double x = -c / (double)b;
                    Console.Write("nghiệm x= " + x);
            
                }  
            }
            else
            {
                double delta = b*b - 4*a*c;
                if (delta == 0)
                {
                    double x = -b/(2*a);
                    Console.Write("PHƯƠNG TRÌNH CÓ NGHIỆM KÉP= " + x);
                }
                if (delta < 0)
                {
                    Console.Write("PHƯƠNG TRÌNH VÔ NGHIỆM");
                }
                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }
            }
        }    
    }
}

