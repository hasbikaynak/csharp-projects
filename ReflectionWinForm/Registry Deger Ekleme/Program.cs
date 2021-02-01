using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registry_Deger_Ekleme
{
    class Program
    {
        static void Main(string[] args)
        {//yeni bir deger olusturma islemi
           // Registry.CurrentUser.SetValue("Anahtar", "Merhaba Registry");
            

            //olusturmus oldugumuz degeri okuma islemi
           //string gelendeger = Registry.CurrentUser.GetValue("Anahtar").ToString();
           // Console.WriteLine($"Aramis olduguuz deger : {gelendeger} idir. ");

            //olusturmus oldugumuz degeri silme islemi
            // Registry.CurrentUser.DeleteValue("Anahtar");

            //subkey olusturma islemi
            //RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("XYZProjesi", true);
            //Registry.CurrentUser.CreateSubKey("XYZProjesi");
            ////subkey deger ekelem islemi
            //Registry.CurrentUser.SetValue("HardDiskSeriNumarasi", "12345678");


            ////subkey icinden deger okua islemi
            //string serinumarasi = registryKey.GetValue("HardDiskSeriNumarasi").ToString();
            //Console.WriteLine(serinumarasi);

           RegistryKey registry = Registry.CurrentUser.OpenSubKey("XYZProjesi", false);
            string[] keys = registry.GetValueNames();
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine($"Anahtar : {keys[i]} Value : {registry.GetValue(keys[i])}  " ) ;
            }

            Console.ReadLine();
        }
    }
}
