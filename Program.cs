﻿namespace Classes
{
    public class Program
    {
        static void Product

        {static void Main()
        {
            double minPrice = 0;
            double maxPrice = 5;
            //int[] prices 
            Product[] products = new Product[5];
            products[0] = new Product("Alma", 3d);
            products[1] = new Product("Ciyelek", 0.8d);
            products[2] = new Product("Uzum", 2.3d);
            products[3] = new Product("Avakado", 8d);
            products[4] = new Product("Corek", 0.75d);
            foreach (var product in products)
            {
                if (product.Price >= minValue && product.Price <= maxValue)
                {
                    Console.WriteLine($"Sen {product.Brandname} mehsulunu {product.Price} manata ala bilersen");
                }
                else
                {
                    Console.WriteLine($"{product.Brandame} bahalidir, acindan ol");
                }
            }
        } }
    }
}