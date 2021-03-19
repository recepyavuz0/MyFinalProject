using Business.Concreate;
using DataAccess.Concreate.InMemory;
using Entities.Concreate;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------ÜRÜNLERİ LİSTELE-------------------------");

            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            
            Console.WriteLine("----------------YENİ ÜRÜN EKLE VE LİSTELE----------------------------");

            Product product1 = new Product {
            ProductId=6,
            ProductName="Masa",
            CategoryId=3,
            UnitPrice=500,
            UnitsInStock=10
            };

            productManager.Add(product1);

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("--------------ÜRÜN SİL VE LİSTELE------------------------------");

            Product product2 = new Product
            {
                ProductId = 2
            };
            productManager.Delete(product2);

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("--------------ÜRÜN GÜNCELLE VE LİSTELE------------------------------");

            Product product3 = new Product
            {
                ProductId = 1,
                ProductName = "Sandalye",
                CategoryId = 3,
                UnitPrice = 150,
                UnitsInStock = 10
            };

            productManager.Update(product3);

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("--------------SEÇİLEN KATEGORİ ÜRÜNLERİNİ LİSTELE------------------------------");

            foreach (var product in productManager.GetAllByCategory(2))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
