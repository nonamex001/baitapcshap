using System;
using System.Text;
namespace bai_1

{
    class  Bai_1
    {
         static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;

            Console.Write("nhap so a= ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("nhap so b= ");
            int b= int.Parse(Console.ReadLine()!);
            if (a == 0)
            {
                if(b==0)
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
                 double x = -b / (double)a;
                Console.Write("nghiệm x= " + x);
            }
          
        }    
    }
}
