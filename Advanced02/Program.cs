using Advanced02.Data;
using Advanced02.Task03;
using Advanced02.Task04;
using Advanced02.task05;
using System.Threading.Channels;

namespace Advanced02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region category
            List<Product> catalog = new()
            {
        new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
        new Product { Id=2, Name="Phone", Category="Electronics", Price=800, Stock=25 },
        new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
        new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
        new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
        new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
        new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
        new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
        new Product { Id=9, Name="Headphones", Category="Electronics", Price=150, Stock=40 },
        new Product { Id=10, Name="Jacket", Category="Clothing", Price=120, Stock=15 }
        };
            #endregion

            #region Task01


            //List<Product> electronics = FilltirationClass.SearchProducts(catalog, p => p.Category == "Electronics");
            //Console.WriteLine("category have electronics");
            //foreach (Product product in electronics)
            //{

            //    Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: ${product.Price}, Stock: {product.Stock}");
            //}
            //Console.WriteLine("--------------------------------------");
            //List<Product> ProductPrice = FilltirationClass.SearchProducts(catalog, Price => Price.Price < 50);
            //Console.WriteLine("ProductPrice cheaper than 50");
            //foreach (Product product in ProductPrice)
            //{
            //    Console.WriteLine($"Id: {product.Id}, Name: {product.Name}");
            //}
            //Console.WriteLine("--------------------------------------");
            //List<Product> ProductStock = FilltirationClass.SearchProducts(catalog, S => S.Stock > 0);
            //Console.WriteLine("the avaiable stock");
            //foreach (Product product in ProductStock)
            //{
            //    Console.WriteLine($"Id: {product.Id}, Name: {product.Name}");
            //}
            //Console.WriteLine("--------------------------------------");
            //List<Product> ProductPrice02 = FilltirationClass.SearchProducts(catalog, Price => Price.Price < 100);
            //Console.WriteLine("ProductPrice cheaper than 100");
            //foreach (Product product in ProductPrice02)
            //{
            //    Console.WriteLine($"Id: {product.Id}, Name: {product.Name}");
            //}
            #endregion
            #region task03
            //Console.WriteLine("short report : ");
            //Report.PrintReport(catalog, p=> Console.WriteLine($"{p.Name}     {p.Price}"));
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("details report  : ");
            //Report.PrintReport(catalog, p => Console.WriteLine($"{p.Category}    {p.Price}     {p.Price}"));
            #endregion
            #region task03
            //Transformationproduct.TransformProducts(catalog, p => $"{p.Name} {p.Price}");
            //Transformationproduct.TransformProducts(catalog, p => $" {(p.Price > 100 ? "Expensive!" : "Affordable")}");
            #endregion
            #region task04
           List<Product> data= filltrationProduct.FilterProducts(catalog, p => p.Stock < 20);
            foreach(Product p in data)
            {
                Console.WriteLine($"[LOW STOCK] {p.Name}: only {p.Stock} left!");
            }
            #endregion

        }
    }
}

