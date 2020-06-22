using System;

namespace MetodosEAtributosEst_ticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Conversor.CotacaoDolar= 5.23f;
            System.Console.WriteLine(Conversor.DolarParaReal(200));
            System.Console.WriteLine(Conversor.RealParaDolar(200));
           
            Conversor.CotacaoEuro= 5.90f;
            System.Console.WriteLine(Conversor.EuroParaReal(252));
            System.Console.WriteLine(Conversor.RealParaEuro(252));

         Console.ResetColor();
        }
    }
}
