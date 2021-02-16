using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class TasitKredimanager : IKrediManager //İnheritance
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }
    }
}
