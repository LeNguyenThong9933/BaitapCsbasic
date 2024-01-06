using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            int i;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("1. Cong");
            Console.WriteLine("2. Tru");
            Console.WriteLine("3. Nhan");
            Console.WriteLine("4. Chia");
            Console.WriteLine("0. Thoat ra");
            Console.Write("Nhap phep tinh: ");
            //i = Convert.ToInt32(Console.ReadLine()); // 1: Tính tổng2.Trừ3.Nhân4.Chia0.Thoát Gia tri khac nhap lai
            while (!int.TryParse(Console.ReadLine(), out i) || i < 0 || i > 4)
            {
                Console.WriteLine("Lua chon khong hop le! Vui long chon lai");
                Console.Write("Nhap phep tinh: ");
            }
            switch (i) 
            {
                case 0: // thoat
                    Console.Write("Bye Bye!");
                    break;
                case 1: //cong
                    Console.WriteLine($"a + b = {a + b}");
                    break;
                case 2: // tru
                    Console.WriteLine($"a - b = {a - b}");
                    break;
                case 3: // nhan
                    Console.WriteLine($"a * b = {a * b}");
                    break; 
                case 4: // chia
                    if (b == 0) Console.WriteLine("Phep tinh khong hop le");
                    else
                    {
                        Console.WriteLine($"a / b = {a / b}");                        
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
