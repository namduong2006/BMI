using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float nang, cao, bmi;
            Console.Write("Cân nặng của bạn (Kg) :");
            nang= float.Parse(Console.ReadLine());
            Console.Write("Chiều cao của bạn (m) :");
            cao= float.Parse(Console.ReadLine());
            bmi = nang / (cao * cao);
            Console.WriteLine("Chỉ số BMI của bạn là : "+bmi);
            if (bmi<18)
                Console.WriteLine("Gầy");
            else if ( bmi<25)
                Console.WriteLine("Bình thường");
            else if(bmi<30)
                Console.WriteLine("Thừa cân");
            else
                Console.WriteLine("Béo phì");
            Console.ReadLine();
        }
    }
}
