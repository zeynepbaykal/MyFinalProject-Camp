using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, string message):base(data,true,message) //data ve mesaj verdik
        {
                
        }

        public SuccessDataResult(T data):base(data,true)//sadece data verdik
        {
                 
        }


        public SuccessDataResult(string message):base(default,true,message) //sadece messaj verdik
        {
                
        }

        public SuccessDataResult():base(default,true) //burada da hiçbir şey vermedik.
        {
             
        }

    }
}
