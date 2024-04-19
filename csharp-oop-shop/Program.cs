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
            Console.WriteLine("Price: " + evianXBoolean.GetPrice() + "$");
            Console.WriteLine("Price whit IVA: " + evianXBoolean.PriceWhitIva() + "$");
            Console.WriteLine("Extended name: " + evianXBoolean.ExtendedName());
        }
    }
}
