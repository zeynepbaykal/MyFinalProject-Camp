using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
    
        public Result(bool success, string message):this(success) //c# da this demek clssın kendisi demek(Yani "Result" demek)
        {
            Message = message; //get read only olduğu için constructor da set edilelebilir.
        }

        public Result(bool success) //overloading
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }   //lambdanın kaesısı sadece get oldugu için ne yazarsak yazalım onu return eder.
        //get set edilemez.
    }
}
