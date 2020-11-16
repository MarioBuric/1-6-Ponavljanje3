using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buricMarioPonavljanje3
{
    class Program
    {
        static void Main(String[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();
            Console.WriteLine("Unos prvog stringa: ");
            Console.WriteLine("Unos drugog stringa: ");
            Console.WriteLine("Unos trećeg stringa: ");
            
            string x = str1+str2+str3;
            x = new string(x.Reverse().ToArray());
            
            Console.WriteLine(x);
            Console.ReadKey();

        }
    }
}