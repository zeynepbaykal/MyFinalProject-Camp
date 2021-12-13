using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult <List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId); //tek basına bir ürün dönderir. ve ürünün sonucunu yazdırır.(mesela bır tane alışveriş sitesıne gırdık ve o urunun detayına ulaşmak istiyoruz , detayına ulaşmak için  kullanabılırız.) 
        IResult Add(Product product);
        IResult Update(Product product);

    }
}
