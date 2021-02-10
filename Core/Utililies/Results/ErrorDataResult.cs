using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utililies.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        //programcıya seçenek sunuyorsun istersen sadece data istersen data ve mesaj istersen mesaj ve istersen verme 
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
