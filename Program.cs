using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı girin");
            int sayi=Convert.ToInt16(Console.ReadLine());
            int yuzde = sayi * 18 / 100;
            Console.WriteLine($"girdiğiniz sayının %18'i {yuzde}'dir.");
            Console.ReadKey();
        }
    }
}
