using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
     class Program
    {
        static void Main(string[] args)
        {
            DortIslem islem = new DortIslem();
            Console.WriteLine("Hangi işlemi yapmak istiyorsunuz?");
            Console.WriteLine("1.Çarpma\n2. Bölme\n3.Toplama\n4.Çıkarma\n");
            int x;
            x= int.Parse(Console.ReadLine());

            int a, b;
            Console.WriteLine("1. değer: ");
            a= int.Parse(Console.ReadLine());
            Console.WriteLine("2. değer: ");
            b = int.Parse(Console.ReadLine());



            switch (x)
            {
                case 1: Console.WriteLine(islem.carpma(a, b)); break;
                case 2: Console.WriteLine(islem.bolme(a, b)); break;
                case 3: Console.WriteLine(islem.toplama(a, b)); break;
                case 4: Console.WriteLine(islem.cıkarma(a, b)); break;
                default: Console.WriteLine("hatalı değer girdiniz!"); break;


            }
            
            

        }
    }
}
