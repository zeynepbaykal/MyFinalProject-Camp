using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool //bir tane oluşturulur proje boyunca uygulama bellleği bunu kullanır. Bir daha new leme yapmamak için (bu yüzden statik dedik)
    {
        public static void Validate(IValidator validator,object entity)//object hepsinin base olduğu için yazdık
        {
            var context = new ValidationContext<object>(entity);
            //ProductValidator productValidator = new ProductValidator();
            var result = validator.Validate(context); //burada ki context product anlamına gelmekte
            if (!result.IsValid) //eğer sonuç geçerli değilse
            {
                throw new ValidationException(result.Errors);  //hata fırlat
            }
        }
    }
}
