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

            foreach (var categories in categoryManager.GetAll().Data)
            {
                Console.WriteLine(categories.CategoryName);
                Console.WriteLine("-----------------------");
            }
            Console.WriteLine("Al sana birinci :" + categoryManager.GetById(1).Data);
        }

        private static void ProductManager()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductDetails();

            if (result.Success)
            {
                foreach (var product in productManager.GetProductDetails().Data)
            {
                Console.WriteLine(product.ProductName + "   "+ product.CategoryName);
            } 
            }else
            {
                Console.WriteLine(result.Message);
            }
            


        }
    }
}
