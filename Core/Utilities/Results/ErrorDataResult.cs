using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message) //data ve mesaj verdik
        {

        }

        public ErrorDataResult(T data) : base(data, false)//sadece data verdik
        {

        }


        public ErrorDataResult(string message) : base(default, false, message) //sadece messaj verdik
        {

        }

        public ErrorDataResult() : base(default, false) //burada da hiçbir şey vermedik.
        {

        }

    }
}
