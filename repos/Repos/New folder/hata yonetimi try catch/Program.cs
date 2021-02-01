using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hata_yonetimi_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            hatamesaji();
            //Console.WriteLine("lutfen bir sayi degeri giriniz");
            //int sayi = int.Parse(Console.ReadLine());
        }

        static void hatamesaji()
        {
            try
            {
                Console.WriteLine("Lutfen bir sayi giriniz");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi == 1)
                {
                    throw new ozelgata(); // kendi olusturdugum hata classini ilk once exception classindan kalittim
                    // sonra throw ile new deyip if statementinin icine attim
                }
            }

                catch (ozelgata dx) // daha sonra catch ile yakaladim
            {
                Console.WriteLine("hatami yakaladim");
            
            }
            catch (FormatException fx)
            {
                Console.WriteLine("ERROR !!! You entered a word, please enter the value as a number ");
                Console.WriteLine(fx.Message);
                Console.ReadKey();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); // let`s assume user typed a word instead of typing numbers, the program would
                // have been gaved us an error. We took this error and assignment on message to show user.
                Console.ReadKey();

            }
            finally
            {
                Console.WriteLine("finally blogu calisti"); // this method alwyas works. Even if we did not get any error 
                //by app, eventually prog. comes here. (if app give an error still it comes here right after it.)
            }
        }
    }
}
