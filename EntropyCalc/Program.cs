using System;

namespace EntropyCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Formula de entropia de boltzman: S = K logW
            string option;

            do
            {
                EntropyEquation entropyEquation;
                entropyEquation = new EntropyEquation();

                Console.WriteLine("____________________________________________________________");
                Console.WriteLine(entropyEquation.Equation());
                Console.WriteLine("____________________________________________________________");
                Console.WriteLine();
                Console.WriteLine("Quer fazer outro calculo?");
                option = Console.ReadLine();
            } while (option == "S");
        }
    }
}