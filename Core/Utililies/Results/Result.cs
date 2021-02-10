using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utililies.Results
{
    public class Result : IResult
    {
      //iki parametreli conc çalışacak ya iki kere yazmasın üsteki ve alttaki bir çalışsın diye
        public Result(bool succes, string message):this(succes)
        {
            Message = message;
        }
        //mesaj yollamak istemiyorsam
        public Result(bool succes)
        {
            Success = succes;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
