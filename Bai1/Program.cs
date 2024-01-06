using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static bool isPrime(int number) 
        {
            if (number <=1) return false;
            for (int i = 2; i < Math.Sqrt(number); i++) 
            {
                if (number % i == 0)
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] array = new int[10];        
            Console.WriteLine("Nhap vao 10 so nguyen: ");
                for (int i = 0; i < 10; i++) 
                    {
                        array[i] = int.Parse(Console.ReadLine());
                    } 
            //in ra so nguyen to
            Console.Write("So nguyen to la: " + " ");
            foreach (int number in array)
            {
                if (isPrime(number)) 
                {
                    Console.Write(number +" ");
                }             
            }
            Console.ReadLine();
        }
    }
}
