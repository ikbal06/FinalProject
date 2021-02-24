using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID o sunu yapıyoruz
    //Open Closed Principle
    //mevcut kodlara dokunmadan işini hallet
    class Program
    {
        static void Main(string[] args)
        {
             ProductTest();
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EFProductDal(),new CategoryManager(new EFCategoryDal()));

            var result = productManager.GetProductDetails();
            if(result.Success==true)
            {
               foreach (var product in result.Data)
            
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
        }
    }
}
