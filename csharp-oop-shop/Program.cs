namespace csharp_oop_shop
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Product evianXBoolean = new Product("Acqua naturale Evian x Boolean", "Sofisticata acqua naturale", 10.50m, 22);

            Console.WriteLine("Product Information:");
            Console.WriteLine("Code: " + evianXBoolean.Code);
            Console.WriteLine("Name: " + evianXBoolean.Name);
            Console.WriteLine("Description: " + evianXBoolean.Description);
            Console.WriteLine("Price: " + evianXBoolean.GetPrice() + " $");
            Console.WriteLine("Price whit IVA: " + evianXBoolean.PriceWhitIva() + " $");
            Console.WriteLine("Extended name: " + evianXBoolean.ExtendedName());

            //BONUS
            Product[] products = new Product[3];

            products[0] = new Product("Smartphone KIA", "Smartphone di ultima generazione", 799.99m, 22);
            products[1] = new Product("TV SONY", "TV LED 55 pollici", 899.99m, 22);
            products[2] = new Product("Laptop SAGUARO", "Laptop ultraleggero", 1299.99m, 22);

            Console.WriteLine("Products List : ");
            foreach (Product product in products)
            {
                Console.WriteLine($"Code: {product.CodeWhitPadding()} || Name: {product.Name} || Price: {product.PriceWhitIva()} EUR");
            }
        }
    }
}
