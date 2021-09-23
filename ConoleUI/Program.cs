using Buisness.Concrete;
using DataAcsess.Concrete.EntityFramework;
using DataAcsess.Concrete.InMemory;
using System;

namespace ConoleUI
{
    class Program
    {
        //SOLID
        //Open Closed Principle
        static void Main(string[] args)
        {
            ProductManeger productManeger = new ProductManeger(new EfProductDal());
            foreach (var product in productManeger.GetByUnitPrice(10,50))
            {
                Console.WriteLine("{0}----{1}",product.ProductName,product.UnitsInStock);
                
            }
        }
    }
}
