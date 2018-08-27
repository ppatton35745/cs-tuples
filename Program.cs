using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            (string product, double amount, int quantity) hammer = ("Hammer", 19.99, 25);
            (string product, double amount, int quantity) nails = ("Nails", 7.99, 100);
            (string product, double amount, int quantity) nailGun = ("Nail Gun", 189.99, 1);
            (string product, double amount, int quantity) bandaids = ("Bandaids", 19.99, 25);
            (string product, double amount, int quantity) staples = ("Staples", 19.99, 25);

            transactions.Add(hammer);
            transactions.Add(nails);
            transactions.Add(nailGun);
            transactions.Add(bandaids);
            transactions.Add(staples);

            int totalProductsSold = 0;
            double totalRevenue = 0;
            foreach ((string product, double amount, int quantity) t in transactions)
            {
                totalProductsSold += t.quantity;
                totalRevenue += t.quantity * t.amount;
            }

            Console.WriteLine($"Total products sold {totalProductsSold} and total dollars sold {totalRevenue}");
        }
    }
}
