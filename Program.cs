using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Febonachii
{
    using System;
    using System.Numerics;
    class Program
    {
        static BigInteger[] memory;

        static BigInteger Febonachii(int numfebo)
        {
            if (numfebo <= 1)
                return numfebo;

            if (memory[numfebo] != -1)
                return memory[numfebo];

            memory[numfebo] = Febonachii(numfebo - 1) + Febonachii(numfebo - 2);
            return memory[numfebo];
        }

        static void Main(string[] args)
        {
            Console.Write("Enter The Number Febonachii=");
            int number = int.Parse(Console.ReadLine());

            memory = new BigInteger[number + 1];


            for (int i = 0; i <= number; i++)
                memory[i] = -1;

            BigInteger result = Febonachii(number);

            //نشان دهنده دنباله آن 
            //Console.WriteLine("\n Donbaleh{0}:", number);
            //for (int i = 0; i <= number; i++)
            //{
            //    Console.WriteLine($"F({i}) = {Febonachii(i)}");
            //}

            Console.WriteLine("Febonachii({0}) = {1}", number, result);
        }




    }
}
