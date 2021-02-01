using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karisik_odev_2
{
   public static class sanaldata
    {
        private static ArrayList db = new ArrayList();
        public static void yeniurunekle(baseclass data)
        {
            if (data != null && !string.IsNullOrEmpty(data.barkod))
            {
                db.Add(data);
            }
        }
        public static bool dbbarkodkontrol(string barkod) 
        {
            bool kontrolislemi = false;
            if (db != null && db.Count > 0 )
            {
                for (int i = 0; i < db.Count; i++)
                {
                    baseclass bc = (baseclass)db[i];
                    if (bc.barkod == barkod)
                    {
                        // return true;
                        kontrolislemi = true;
                    }

                    

                }

            }
            // return false; 
            return kontrolislemi;
        }
    }
}
