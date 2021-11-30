using System;



namespace Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Informações do usuario
            Console.WriteLine("Qual é a cotação do dólar ? ");
            double cota = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos dólares você ira comprar? ");
            double CD = double.Parse(Console.ReadLine());

            //Valor a ser pago e calculos
            double Valorp = cota * CD;
            Console.WriteLine($"Valor a ser pago em reais = ${Valorp} ");

            //Valor com o IOF
            double IOF = 4.08; 
            double IOF2 = Valorp * 4.08 / 100;
            double Valort = Valorp + IOF2;

            //Mandar os valores finais
            Console.WriteLine($"Valor do pagamento IOF = {IOF}% ");
            Console.WriteLine("Valor de IOF para pessoas fisicas. 24/09/2021");
            Console.WriteLine($"Valor total com o IOF = ${Valort} ");
            Console.ReadKey();
        }
    }
}
//https://www.melhorcambio.com/dolar-hoje
//https://confirp.com.br/aumenta-o-iof-veja-o-impacto-para-pessoas-fisicas-e-juridicas/
