using Buisness.Concrete;
using DataAcsess.Concrete.InMemory;
using System;

namespace ConoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManeger productManeger = new ProductManeger(new InMemoryProductDal());
            foreach (var product in productManeger.GetAll())
            {

                Console.WriteLine(product.ProductName);
            }
        }
    }
}
