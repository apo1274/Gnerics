﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class EsnafKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void hesapla()
        {
            Console.WriteLine("Esnaf kredisi ödeme planı hesaplandı.");
        }
    }
}