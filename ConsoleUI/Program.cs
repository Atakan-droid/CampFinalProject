using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //DTO -- Data Taransformation object taşınan objeler
            ProductManager();

           // CategoryManager();



        }

        private static void CategoryManager()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var categories in categoryManager.GetAll())
            {
                Console.WriteLine(categories.CategoryName);
                Console.WriteLine("-----------------------");
            }
            Console.WriteLine("Al sana birinci :" + categoryManager.GetById(1).CategoryName);
        }

        private static void ProductManager()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "   "+ product.CategoryName);
            } 


        }
    }
}
