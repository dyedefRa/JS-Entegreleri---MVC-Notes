
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL : TryCatchBase
    {
        //Burada Data işlemleri yapacagız ve try catch blogları olması gerekıyordu .
        //try catchi tek bir yerden kontrol edicez.

        public int UrunEkle(string asf)
        {
            //Urun ekleme olayi oldugunu dusuneli ve 
            //savechange anında try cathblogu olmalı burada;

            int x = 0;

            //BASE SINIFIMIN ICINDEKI UPPERTRYCATCH METODUNA ACTION OLARAK TRY CATCHTE OLMASINI ISTEDIGIM METODLARI ATACAGIM

            UpperTRYCATCH(() =>
            {
                int a = 5 / x;
            });
            return 3;

        }
    }
}
