using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utililies.Results
{
    //mesajla işlem sonucunu IResult içerdiğinden ekstra T türünde bir data olmalı
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
