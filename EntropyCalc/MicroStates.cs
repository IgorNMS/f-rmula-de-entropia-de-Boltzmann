using System;

namespace EntropyCalc
{
    public class MicroStates
    {
        public decimal MicroEstados()
        {
            decimal Microestados;
            double Elevado;
            
            Console.Write("Digite o numero de microestados: ");
            Microestados = decimal.Parse(Console.ReadLine());
            Console.Write("x10 elevado a quantos?: ");
            Elevado = double.Parse(Console.ReadLine());
            return Microestados * (decimal)Math.Pow(10, Elevado);
        }
    }
}