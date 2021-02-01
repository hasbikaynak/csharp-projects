using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_collections_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable htlist = new Hashtable(); // hashtable default collections classindandir. add using
            //system.collections;

            htlist.Add(1, "bir"); // hashtable list (key,value) degerlerinde calisir. 
            htlist.Add(2, "iki");
            htlist.Add(3, true);
            // htlist.Add(1, "test");//1 numarali key zaten atandigi icin hata alirim

            Dictionary<int, string> dictionarylistem = new Dictionary<int, string>();
            //dictionary listem ise generic collections classimda yer alir ve <Tkey , Tvalue > degerleri alir.
            dictionarylistem.Add(1, "bir");
            dictionarylistem.Add(2, "iki");
            dictionarylistem.Add(3, "uc");
           // dictionarylistem.Add(1, "test");// ayni default hashtable metodumda oldugu gibi hata alacagim.

            bool silmesonuc = dictionarylistem.Remove(2);
            if (silmesonuc)
            {
                Console.WriteLine("2. keye sahip deger silindi");
            }
            else
            {
                Console.WriteLine("aradiginiz key numarasi listede yoktur.");
            }
            bool aranandeger = dictionarylistem.ContainsKey(3);// containskey() yazilan key degerini arar ve
            // varsa  true , yoksa false degerini atar.
            if (aranandeger)
            {
                Console.WriteLine("aranan deger bulundu");
            }
            else
            {
                Console.WriteLine("aranan deger bulunamadi");
            }
            foreach (KeyValuePair<int,string> item in dictionarylistem)
            {
                Console.WriteLine("Key  : {0} || Value : {1}  ", item.Key,item.Value   );
            }
            dictionarylistem.Clear();

            SortedList<int, string> sortedlistem = new SortedList<int, string>(); // sortedlist<tkey, tvalue>
            //sorted edilmis bir sekilde listemizi bize sunar. 
            sortedlistem.Add(100, "yuz");
            sortedlistem.Add(5, "bes");
            sortedlistem.Add(10, "on");
            sortedlistem.Add(50, "elli");
        }
    }
}
