namespace Estudos.Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            var mouse = new Product(1, "Mouse", 299.99, EProductType.Product);
            var manutencaEletrica = new Product(2, "Manutenção Elétrica", 100, EProductType.Service);
            
            mouse.Id = 55;
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
        }
    }

    struct Product
    {
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        
        public EProductType Type { get; set; }
        
        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2,
    }
}

    

