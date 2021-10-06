using Business.Concrete;
using DataAccsess.Concrete.EntityFramework;
using DataAccsess.Concrete.InMemory;
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
            var result = productManeger.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }


            }
            else
            {
                Console.WriteLine(result.Massege);
            }
            
        }
    }
}
