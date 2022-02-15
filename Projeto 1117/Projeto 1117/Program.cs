using System;
using System.Globalization;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota = 0, soma = 0;
            int cont = 0;

            while (cont < 2)
            {
                nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (nota >= 0 && nota <= 10)
                {
                    soma = soma + nota;

                    cont = cont + 1;
                }

                else
                {
                    Console.WriteLine("nota invalida");
                }


            }

            var media = soma / 2;
            Console.WriteLine("media = " + media);


            //Console.ReadLine();
        }
    }
}
