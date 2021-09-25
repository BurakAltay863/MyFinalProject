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
            ProductTest();
            //CategoryTest();



        }

        private static void CategoryTest()
        {
            CategoryManeger categoryManeger = new CategoryManeger(new EfCategoryDal());
            foreach (var category in categoryManeger.GetAll())
            {
                Console.WriteLine("category name = " + category.CategoryName);

            }
        }

        private static void ProductTest()
        {
            ProductManeger productManeger = new ProductManeger(new EfProductDal());
            foreach (var product in productManeger.GetProductDetails())
            {
                Console.WriteLine( product.ProductName+"/"+ product.CategoryName);

            }
        }
    }
}
