using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Thuong
{
    public class tinhChuViDienTich
    {
        public void ex1()
        {
            float dai, rong, chuVi, dienTich;
            Console.WriteLine("Nhap chieu dai:");
            dai = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong");
            rong = float.Parse(Console.ReadLine());
            chuVi = (dai + rong) * 2;
            dienTich = dai * rong;
            Console.WriteLine("Chu vi la: " + chuVi);
            Console.WriteLine("Dien tich la: " +dienTich);
        }
    }
}
