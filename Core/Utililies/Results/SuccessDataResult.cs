using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utililies.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        //programcıya seçenek sunuyorsun istersen sadece data istersen data ve mesaj istersen mesaj ve istersen verme 
        public SuccessDataResult(T data,string message):base(data,true,message)
        {

        }
        public SuccessDataResult(T data):base(data,true)
        {

        }
        public SuccessDataResult(string message):base(default,true,message)
        {

        }
        public SuccessDataResult():base(default,true)
        {

        }
    }
}
