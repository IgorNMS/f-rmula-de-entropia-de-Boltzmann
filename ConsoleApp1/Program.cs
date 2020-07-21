using System;

namespace Entropy_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            double boltzman_constant, microestados, elevado, s_entropy;
            char option;
            
            boltzman_constant = 1.3807 * Math.Pow(10, -23);
           
            microestados = 0;
           
            elevado = 0;
            
            s_entropy = 0;
            do
            {
                Console.Write("Digite o numero de microestados: ");
                microestados = double.Parse(Console.ReadLine());
                Console.Write("x10 elevado a quantos?: ");
                elevado = double.Parse(Console.ReadLine());
                microestados = microestados * Math.Pow(10, elevado);
                s_entropy = boltzman_constant * Math.Log10(microestados);
                Console.WriteLine("____________________________________________________________");
                Console.WriteLine(boltzman_constant);
                Console.WriteLine("____________________________________________________________");
                Console.WriteLine(microestados);
                Console.WriteLine("____________________________________________________________");
                Console.WriteLine(Math.Log10(microestados));
                Console.WriteLine("____________________________________________________________");
                Console.WriteLine(s_entropy);
                Console.WriteLine("____________________________________________________________");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Quer fazer outra operação?");
                Console.Write("S para sim, N para não: ");
                option = char.Parse(Console.ReadLine());
            } while (option == 's');            
        }
    }
}
