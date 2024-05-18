using System;
using System.Globalization;

namespace desafioBarOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bill bill = new Bill();

            Console.Write("Sexo: ");
            bill.gender = char.Parse(Console.ReadLine());
            Console.Write("Quantidade de cervejas: ");
            bill.beer = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de refrigerantes: ");
            bill.softDrink = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de espetinhos: ");
            bill.barbecue = int.Parse(Console.ReadLine());

            double consumo = bill.feeding();
            double couvert = bill.cover();
            double ingresso = bill.ticket();
            double conta = bill.total();

            Console.WriteLine();
            Console.WriteLine("RELATÓRIO: ");
            Console.WriteLine("CONSUMO: R$  "+ consumo.ToString("F2",CultureInfo.InvariantCulture));
            if (consumo > 30.00)
            {
                Console.WriteLine("Insento de Couvert");
            }else
            {
                Console.WriteLine("Couvert: R$  " + couvert.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine("Ingresso: R$ " + ingresso.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();

            Console.WriteLine("Valor a pagar = R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
