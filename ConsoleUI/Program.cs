using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductManager productManager = new ProductManager(new InMemoryProductDal());
            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //ProductManager productManager = new ProductManager(new EfProductDal());
            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //Solid
            //O : open closed principle

            //ProductManager productManager = new ProductManager(new EfProductDal());
            //foreach (var product in productManager.GetAllByCategoryId(2))
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine(product.ProductName);
            }
        }

    }
}
