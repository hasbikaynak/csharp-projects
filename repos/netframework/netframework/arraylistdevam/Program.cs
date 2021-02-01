using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylistdevam
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullanicidangelendeger = null;
            ArrayList listem = new ArrayList();

            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1- Deger ekle");
                Console.WriteLine("2- Degerleri listele");
                Console.WriteLine("3- Deger ara ");
                Console.WriteLine("4- Deger duzenle ");
                Console.WriteLine("5- Deger sil");
                Console.WriteLine("6- Uygulama cikisi");
                Console.WriteLine("7- Bir degerin index numarasini ogren");
                Console.WriteLine("seciniz : ");
                kullanicidangelendeger = Console.ReadLine();


               

                switch (kullanicidangelendeger)
                {

                    case "1":
                        Console.Write("eklemek istediginiz degeri giriniz :");
                        string kullanicidangelen1 = Console.ReadLine();
                        listem.Add(kullanicidangelen1);
                        System.Threading.Thread.Sleep(2000);// kodu iki saniye bekletir ve devam eder


                        break;
                    case "2":
                        for (int i = 0; i < listem.Count; i++)
                        {
                            Console.WriteLine("{0}. Deger {1}  ", i , listem[i]);    
                        }
                        Console.WriteLine("devam etmek icin herhangibir tusa basiniz ");
                        Console.ReadKey();

                        break;
                    case "3":
                        
                        Console.Write("liste icinde aramak istediginiz degeri yaziniz : ");
                        string kullaniciaramadeger = Console.ReadLine();
                        bool kontrol = listem.Contains(kullaniciaramadeger);
                        if (kontrol)
                        {
                            int bulunanindex = listem.IndexOf(kullaniciaramadeger);
                            string bulunandeger = listem[bulunanindex].ToString();
                            Console.WriteLine("Degeriniz bulundu : index sirasi : {0} - Deger {1} ",bulunanindex , bulunandeger);
                            
                        }
                        else
                        {
                            Console.WriteLine("aradiginiz kriterlerde bir deger bulunamadi");
                        }


                        System.Threading.Thread.Sleep(2000);

                        break;
                    case "4":

                        Console.WriteLine("Duzenlemek istediginiz degeri giriniz : ");
                        string kullaniciduzenlenecekdeger = Console.ReadLine();
                        Console.WriteLine("{0} degerini hangi degerle guncellemek istiyorsunuz yaziniz", kullaniciduzenlenecekdeger);
                        string kullanicigunceldeger = Console.ReadLine();
                        if (listem.Contains(kullaniciduzenlenecekdeger))
                        {
                            int kullanicihedefindex = listem.IndexOf(kullaniciduzenlenecekdeger);
                            listem[kullanicihedefindex] = kullanicigunceldeger;
                            Console.WriteLine("degeriniz guncellendi");
                        }
                        else
                        {
                            Console.WriteLine("aradiginiz deger listede bulunamadi");
                            Console.WriteLine("aradiginiz deger listeye eklensin mi ? (E/H)");
                            string kullaniciabulunamayandeger = Console.ReadLine();
                            if (kullaniciabulunamayandeger.ToUpper()=="E" )
                            {
                                listem.Add(kullaniciduzenlenecekdeger);
                                Console.WriteLine("degeriniz listeye eklendi");
                            }
                            
                            

                            
                        }

                        System.Threading.Thread.Sleep(2000);


                        break;
                    case "5":

                        Console.Write("tum listeyi mi silmek istiyorsunuz? (E/H)  ");
                       string silinecekdeger = Console.ReadLine();
                        if (silinecekdeger.ToUpper() == "E")
                        {
                            listem.Clear();
                            Console.WriteLine("Listeniz silindi");
                        }
                        else
                        {
                            Console.WriteLine("silmek istediginiz degeri yaziniz ");
                            string kullanicisilinecekdeger = Console.ReadLine();
                            if (listem.Contains(kullanicisilinecekdeger))
                            {
                                listem.Remove(kullanicisilinecekdeger);
                                Console.WriteLine("deger silindi");
                            }
                            else
                            {
                                Console.WriteLine("silmek istediginiz deger listede mevcut degil ");
                            }
                        }
                        System.Threading.Thread.Sleep(2000);
                        break;


                   
                    default:

                        break;

                }

            } while (kullanicidangelendeger != "6");




        }      
    }
}
