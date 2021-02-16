using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class DatabaseLoggerService : IloggerService
    {
        

        public void log()
        {
            Console.WriteLine("Veritabanına loglandı!");
        }
    }
}


