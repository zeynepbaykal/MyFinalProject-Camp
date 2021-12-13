using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal; //bir iş sınıfı başka bir iş  sınıfını new leyerek yazamaz . Bu yuzden burada olduğu gibi "dependency injection" yaparız.

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        //void ben  özel bir tip döndermiyorum demektir

        [ValidationAspect(typeof(ProductValidator))] //Add methodunu doğrula "productvalidator" kullanarak 
        public IResult Add(Product product)
        {
            //business code(eğer bu şekildeyse ekle gibi)-- mesela kredi alırken uygun mu değil mi diye bakılması finansal puanına bakılması

            //validation-- nesneyi iş kurallarına dahil etmek için , yapılan doğrulama kuralları demektir. (munimum kaç karakter olabilir vs.)

            //magic strings-strinkleri ayrı ayrı yazmak anlamına gelir

           
            //validate

            //ValidationTool.Validate(new ProductValidator(), product);
 
            _productDal.Add(product);

            return new SuccessResult(Messages.ProductAdded); // constructor olusturduk

        }
        //mesela burada liste donuyor.
        public IDataResult<List<Product>> GetAll()
        {
            //iş kodları
            //yetkisi var mı?

            if (DateTime.Now.Hour == 9)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime); //generatefield
            }
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductListed);
             
        }

        public IDataResult <List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult <Product> GetById(int productId)
        {
            return new SuccessDataResult<Product> (_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult <List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>> (_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>> ( _productDal.GetProductDetails());
        }
    }
}
