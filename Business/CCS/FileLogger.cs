using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CCS
{
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("dosya loglandı");
        }
    }
}
