using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Simulation
{
    public static class Inventory_Management
    {
        public static int product_id = 1;
        public static void Entry_Point()
        {
            while (true)
            {
                Console.WriteLine("What you want to do?");
                Dictionary<string, Tuple<string, Action>> map = new Dictionary<string, Tuple<string, Action>>
                {
                    {"1", new Tuple<string, Action>("Add Product: ", Inventory.Add_Product)},
                    {"2", new Tuple<string, Action>("Display Product: ", Inventory.Display_Product)},
                    {"3", new Tuple<string, Action>("Exit: ", Kill)}
                };
                foreach (var option in map)
                {
                    Console.WriteLine($"{option.Key}\t:\t {option.Value.Item1}");
                }
                Console.Write("Choose a option: ");
                map[Console.ReadLine()].Item2.Invoke();
            }
        }

        public static void Kill() { Environment.Exit(0); }

    }

    class Product
    {
        public Product(string product_name, double price, int quantity) 
        {
            this.product_name = product_name;
            this.price = price;
            this.quantity = quantity;

        }
        public string product_name;
        public double price;
        public int quantity;
    }

    static class Inventory
    {
        static Dictionary<int, Product> inventory= new Dictionary<int, Product>{};
        public static void Add_Product() 
        {
            Console.Write("Enter Product Name: ");
            string product_name = Console.ReadLine();

            Console.Write($"Enter price for {product_name}: ");
            Double.TryParse(Console.ReadLine(), out double price);

            Console.Write($"Enter Stock Quantity for {product_name}: ");
            int.TryParse(Console.ReadLine(), out int quantity);

            Product new_product = new Product(product_name, price, quantity);
            inventory.Add(Inventory_Management.product_id, new_product);
            Inventory_Management.product_id += 1;
        }
        public static void Display_Product()
        {
            foreach (var item in inventory)
            {
                Console.WriteLine($"{item.Key}\t: {item.Value.quantity} number of {item.Value.product_name} @ Rs. {item.Value.price}/- each");
            }
        }
    }
}
