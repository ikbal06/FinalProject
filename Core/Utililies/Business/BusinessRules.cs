using Core.Utililies.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utililies.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics) //parametre ile göderdiğim iş kuralları. birden fazla gönderebilirsin
        {
            foreach (var logic in logics)
            {
                if (!logic.Success) //başarılı değilse
                {
                    return logic; //direkt mevcut hatayı döndürür
                }           
            }
            return null;
        }
    }
}
