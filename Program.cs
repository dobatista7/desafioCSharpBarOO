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


        }
    }
}
