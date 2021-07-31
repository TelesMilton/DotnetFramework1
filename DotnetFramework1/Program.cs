using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetFramework1
{
    class Program
    {
        static void Main(string[] args)
        {
			int num1, num2, soma;
			Console.WriteLine("digite um numero");
			num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("digite um numero");
			num2 = int.Parse(Console.ReadLine());
			soma = num1 + num2;
			Console.WriteLine("a soma é: " + soma);
			soma = num1 * num2;
			Console.WriteLine("a mult é: " + soma);
			soma = num1 / num2;
			Console.WriteLine("a div é: " + soma);
			soma = num1 - num2;
			Console.WriteLine("a sub é: " + soma);
		}
    }
}
