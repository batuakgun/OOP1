using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediBaseManager krediBaseManager, ILoggerService loggerService)
        {
            //Basvuran bilgilerini değerlendirme
            krediBaseManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediBaseManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
