using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruManager
    {
        //METHOT İNJECTİON
        public void BasvuruYap(IKrediManager kredimanager,List<IloggerService> loggerServices) //İstediğim kredi çeşidini yollayabilirim. Zaten referansını bu tutuyor.
        {
            //Başvuran kişinin bilgilerini değerlendirme bölümü
            //
            kredimanager.hesapla();
            foreach (var logger in loggerServices) {
                logger.log();
            }
            //İstediğimiz herhangibir kredi türü olabilir.
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach(var kredi in krediler)
            {
                kredi.hesapla();
            }
        }

    }
}
