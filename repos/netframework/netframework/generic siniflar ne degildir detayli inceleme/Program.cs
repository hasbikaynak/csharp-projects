using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_siniflar_ne_degildir_detayli_inceleme
{
    class Program
    {
        static void Main(string[] args)
        {
            genericrepository<musteri> repositorymusteri = new genericrepository<musteri>();
            List<musteri> musterilerim = repositorymusteri.Getir();
            repositorymusteri.yenikayitekle(null);
            genericrepository<urun> repositoryurun = new genericrepository<urun>();
            repositoryurun.Getir();
            repositoryurun.yenikayitekle(null);
            
        }
    }
}
