using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Udemy.System.IO
{
    class Program
    {
        static void Main(string[] args)
        {

            //YeniKlasorOlustur("c://Udemy"); // this is what our file name is gonna be.
            //klasorkontroletme("c://Udemy"); // this is how we can chceck our files if it exists.
            //klasorsilme("c://Udemy"); // this is how we can delete our existing files
            //Console.WriteLine("Please type name of file which you want to research on this computer.");
            //klasorkontroletme(Console.ReadLine());
            //Console.WriteLine("For closing this app please press any button on keyboard");
            //Console.ReadKey();
            klasortasima("c://Udemy", "c://Klasortasima//Udemy");//with this we could move our source file to destination
            //file.


        }
        static void YeniKlasorOlustur(string path)
        {
            DirectoryInfo D1 = Directory.CreateDirectory(path); // with this method we can create a new file on our computer

        }
        static void klasorkontroletme(string path)
        {
            bool kontrol = Directory.Exists(path);
        }



        static void klasorsilme(string path)
        {
            Directory.Delete(path); // if you add ", coma" next to path value, method of delete is going to request from us
            // true or false. Thus we can delete our whole files if it has extra files in it. 
        }
        static void odev1(string path)
        {
            bool kontrol = Directory.Exists(path);
            if (kontrol == true)
            {

                Console.WriteLine("The file which you  researching already exists, do you want to delete it permanently? (Y/N)");
                string kullanicicevap = Console.ReadLine();
                if (kullanicicevap.ToUpper() == "Y")
                {
                    klasorsilme(path);
                    Console.WriteLine("The file has been deleted permanently");
                }
                else if (kullanicicevap.ToUpper() == "N")
                {

                }
                else
                {
                    Console.WriteLine("You typed wrong character");


                }




            }
            else
            {
                Console.WriteLine("The file which you reaserching not found, do you want to create it? (Y/N)");
                string kullanicicevap2 = Console.ReadLine();
                if (kullanicicevap2.ToUpper() == "Y")
                {
                    YeniKlasorOlustur(path);
                    Console.WriteLine("The file has been created successfully !!! ");
                }
                else if (kullanicicevap2.ToUpper() == "N")
                {

                }
                else
                {
                    Console.WriteLine("You typed wrong character");


                }
            }
        }

        static void klasortasima(string kaynak, string hedef)
        {
            Directory.Move(kaynak, hedef);
        }

    }
}



