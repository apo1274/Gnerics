using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class IhtiyacKrediManager : IKrediManager //İheritance 
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }
    }
}
