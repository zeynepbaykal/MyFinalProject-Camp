using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //temel voidler için başlangıç
    public interface IResult
    {
        bool Succes { get; }// get sadece okunabilir demektir. set yazsaydı oda yazılabılır anlamına gelecekti.
        string Message { get; }
    }
}
