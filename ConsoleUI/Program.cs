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
            // ProductTest();
            CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }


        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EFProductDal());
            foreach (var product in productManager.GetByUnitPrice(10, 100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
