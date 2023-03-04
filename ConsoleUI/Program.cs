using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System.ComponentModel.Design;
using System.Net.WebSockets;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CategoryManager categorymanager = new CategoryManager(new EfCategoryDal());

            //foreach (var category in categorymanager.GetAll())
            //{
            //    Console.WriteLine( category.CategoryName);
            //}
            
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();

            if (result.Success == true)
            {
                foreach (var product in productManager.GetProductDetails().Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
               
            }
            else
            {
                Console.WriteLine( result.Message);
            }

            
        }
    }
}