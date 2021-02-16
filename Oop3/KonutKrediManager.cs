using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class KonutKrediManager : IKrediManager //İnheritance
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }
    }
}
