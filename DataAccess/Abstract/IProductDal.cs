using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product> //entity reposıtory'i product için yapılandır demektir.
    {
        List<ProductDetailDto> GetProductDetails();
       
    }
}


//code refactoring: kodun iyileştirilmesi demektir.