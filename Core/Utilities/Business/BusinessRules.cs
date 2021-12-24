using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics) //Iresult türünde virgül ile ayırarak istediğimiz kadar method atayabılırız params bu işe yarar. aynı şeyi list ile de yapabılırdık. ama bu şekilde direk olarak methodun içerisine yazabılırız.
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
