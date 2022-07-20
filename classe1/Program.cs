using System;
using classe1.Carro;
using Carro.src;

namespace Carro.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            carro tesla = new carro(4,"Tesla Model S\n", "Branco\n",2022);
            Console.WriteLine(tesla.ToString());
        }
    }
}
