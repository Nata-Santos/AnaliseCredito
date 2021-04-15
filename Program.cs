using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal valorEmp, parcelas, rendaM, valorPar;
            decimal calcPorcent;


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----Solicitação de Emprestimo----");
            Console.ResetColor();

            Console.Write("\nQual é o Valor desejado : ");
            valorEmp = decimal.Parse(Console.ReadLine());

            Console.Write("Quantidade de parcelas desejada : ");
            parcelas = decimal.Parse(Console.ReadLine());

            Console.Write("Renda Mensal : ");
            rendaM = decimal.Parse(Console.ReadLine());

            valorPar = valorEmp/ parcelas;
            calcPorcent = (30* rendaM) /100;
            

            if (valorPar > calcPorcent)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNão é permitido valor de parcela que excede 30% da sua renda mensal");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nSeu emprestimo foi solicitado.");
                Console.ResetColor();
            }



        }
    }
}
