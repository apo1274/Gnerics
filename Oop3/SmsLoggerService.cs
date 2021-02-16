using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class SmsLoggerService : IloggerService
    {
        public void log()
        {
            Console.WriteLine("Sms yollandı.");
        }
    }
}
