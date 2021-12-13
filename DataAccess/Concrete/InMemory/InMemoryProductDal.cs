using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal() //constructer
        {
            //Herhangi bir veritabanından veri çekiyormuş gibi düşünelim. (Oracle,sql server, mongoDb,Posygres)
            _products = new List<Product>
            {
            new Product {ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15,UnitsInStock=15},

            new Product { ProductId = 2, CategoryId = 2, ProductName = "Kamera", UnitPrice = 15, UnitsInStock = 15 },

            new Product { ProductId = 3, CategoryId = 3, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock = 3 },

            new Product { ProductId = 4, CategoryId = 4, ProductName = "Klavye", UnitPrice = 150, UnitsInStock = 2 },

            new Product { ProductId = 5, CategoryId = 5, ProductName = "Fare", UnitPrice = 85, UnitsInStock = 1 }
            };



        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //Product productToDelete=null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId==p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}

            //LINQ- Language Integrated Query
            //Lampda "=>" bu işaretin adıdır.
            //LINQ kod sayesinde yukarıdaki foreach döngüsünü yazmaya gerek kalmaz. 
            //foreach döngüsü gibi kodu dönmeye yarar.
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            
            _products.Remove(productToDelete); //direk  olarak bu kod ile silme işlemi yapamyız çünkü referansları farklı. referans tiplerini bu şekilde silemeyiz. bool , string , int vs olsaydı silebilirdik yani değer tip.
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        
        public void Update(Product product)
        { 
            //Gönderdiğim ürün Id'sine sahip olan listedeki ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            //where koşulu içindeki şarta uyan butun elemanları yeni birliste halıne getiri  ve onu dönderir.
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
