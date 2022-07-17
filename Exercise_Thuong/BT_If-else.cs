using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Thuong
{
    public class BT_If_else
    {
        public void ex_5()
        {
        
            float height, weight, BMI;
            Console.Write("Please enter height value (m): ");
            height = float.Parse(Console.ReadLine());

            Console.Write("Please enter weight value (kg): ");
            weight = float.Parse(Console.ReadLine());
            BMI = (float)(weight / (Math.Pow(height, 2))); // BMI = Can Nang/(ChieuCao ^ 2)

            Console.WriteLine("Your BMI = " + BMI);

            if (BMI < 15)
                Console.WriteLine("Thân hình quá gầy");
            else if (BMI >= 15 && BMI < 16)
                Console.WriteLine("Thân hình gầy");
            else if (BMI >= 16 && BMI < 18.5)
                Console.WriteLine("Thân hình hơi gầy");
            else if (BMI >= 18.5 && BMI < 25)
                Console.WriteLine("Thân hình bình thường");
            else if (BMI >= 25 && BMI < 30)
                Console.WriteLine("Thân hình hơi béo");
            else if (BMI >= 30 && BMI < 35)
                Console.WriteLine("Thân hình béo");
            else
                Console.WriteLine("Thân hình quá béo");
            Console.ReadKey();
        }
    }
}
