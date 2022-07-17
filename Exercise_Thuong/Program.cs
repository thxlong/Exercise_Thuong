using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Thuong
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            int numberChooseEx = 0;
            InDeBai();
            ChooseExercise(numberChooseEx);
        }

        #region Method
        static void InDeBai()
        {
            string bai1 = "Bai 1";
            string bai2 = "Bai 2";
            string bai3 = "Bai 3";

            Console.WriteLine("--------------------------");
            Console.WriteLine(bai1);
            Console.WriteLine(bai2);
            Console.WriteLine(bai3);
            Console.WriteLine("--------------------------");
        }
        static void ChooseExercise(int i) 
        {
            BT_If_else bt = new BT_If_else();
            Console.Write("Nhập số để chọn kết quả bài tập: ");
            i = int.Parse(Console.ReadLine());
            while (i < 0 || i > 10)
            {
                NhapSoKhongHopLe(i);
                ChooseExercise(i);
            }
            switch (i)
            {
                case 1:
                    bt.ex_5();
                    Console.ReadLine();
                    break;
            }
        }

        static void NhapSoKhongHopLe(int i) 
        {
            Console.Write("Số {0} bạn nhập không hợp lệ! Vui lòng nhập lại: ", i);
        }

        
        #endregion
    }
}
