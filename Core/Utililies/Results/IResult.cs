using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utililies.Results
{
    public interface IResult
    {
        //temel voidler için
        bool Success { get; } //get okumak için set yazmak için //get demek bir şeyi return etmek demek
        string Message { get; }

    }
}
