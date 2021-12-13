using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message):base(success, message)
        {
            Data = data; //base yaptığımız zaman 14.satırdakı kodu çalıştırabilmek için set etmemiz gerekir.
        }

        public DataResult(T data, bool success): base(success)
        {
            Data= data; //set ettik.      
        }
        public T Data { get; }
    }
}
