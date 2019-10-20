using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrioMobilBolenlerinToplamı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A değerini giriniz : ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B değerini giriniz : ");
            int B = Convert.ToInt32(Console.ReadLine());
            int X= 0;
            while (X == 0)
            {
                Console.Write("X değeri sıfır olamaz. X değerini giriniz : ");
                X = Convert.ToInt32(Console.ReadLine());
            }
            int toplam = 0;
            for(int i = A; i <= B; i++)
            {
                if(i%X == 0)
                {
                    toplam += i;
                    Console.Write(i+ " ");
                }
            }
            Console.WriteLine("Toplam : " + toplam);
            Console.ReadLine();
        }
    }
}
