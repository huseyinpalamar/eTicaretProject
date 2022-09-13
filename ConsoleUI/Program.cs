using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Reflection;

namespace ConsoleUI
{

    class Program
    {
        static void Main(string[] args)
        {
            //GetAllTest();
            //CategoryTest();
            /* ProductManager productManager = new ProductManager(new EfProductDal());
             GetAllDto(productManager);

             Product product1 = new Product {CategoryId=1,ProductName="Deneme",UnitPrice=150,UnitsInStock=100 };

             productManager.delete(product1);

            */

           /* var type = typeof(CategoryManager);

             var  instance = Activator.CreateInstance(type);
            MethodInfo methodInfo = instance.GetType().GetMethod("GetAll");

            var methods=type.GetMethods();

            foreach (var info in methods)
            {
                Console.WriteLine(info.Name);
                foreach (var parametre in info.GetParameters())
                {
                    Console.WriteLine("Parametre " +parametre.Name);
                }
            }
           */

        }



        /* private static void GetAllDto(ProductManager productManager)
         {
             foreach (var p in productManager.GetProductDetail())
             {
                 Console.WriteLine(p.ProductName + " -----  " + p.CategoryName);
             }
         }

         private static void CategoryTest()
         {
             CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

             foreach (var c in categoryManager.GetAll())
             {
                 Console.WriteLine(c.CategoryName);
             }
         }

         private static void GetAllTest()
         {
             ProductManager productManager = new ProductManager(new EfProductDal());
             foreach (var p in productManager.GetAll())
             {
                 Console.WriteLine(p.ProductName);
             }
         }*/
    }
}