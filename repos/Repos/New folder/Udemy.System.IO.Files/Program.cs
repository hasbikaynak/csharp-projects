using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.System.IO.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            // FileCreate("c://Udemy//merabatelevole.txt"); // we created our .txt in the file of udemy.  
            //bool kontrol = FileControl("c://Udemy//merabatelevole.txt "); // we checked our file if it`s already exists or not.
            // if (kontrol)
            // {
            //     Console.WriteLine("The file that you researching is already exists.");
            // }
            // else
            // {
            //     FileCreate("c://Udemy//merabatelevole.txt");
            // }

            // FileDelete("c://Udemy//merabatelevole.txt");
            //FileMove("c://Udemy//merabatelevole.txt", "c://Udemy//Klasortasima//merabatelevole.txt");
            //FileCopy("c://Udemy//Klasortasima//merabatelevole.txt", "c://Udemy//merabatelevole.txt");
            //FileAppendText("c://Udemy//merabatelevole.txt","Meraba Televole !!!"); 
            Console.WriteLine( FileReadAllTexts("c://Udemy//merabatelevole.txt"));
            Console.ReadKey();

        }

        static   void  FileCreate(string path)
        {
           FileStream myfile =  File.Create(path); // with the method of file we created our file and than we could this 
            // value assignment on myfile 
            myfile.Close(); // this is important because if we do not close our program, than it can give us some errors.
        }
        static bool FileControl(string path)
        {
           return  File.Exists(path);
        }

        static void FileDelete(string path)
        {
            File.Delete(path);
        }
        static void FileMove(string source, string destination)
        {
            File.Move(source,destination);
        }
        static void FileCopy(string source, string destination)
        {
            File.Copy(source, destination);
        }
        static void FileAppendText(string path, string value) //method requirements is path for destanation file and the values
            //for the typing inside of it
        {
            File.AppendAllText(path,value);
        }
        static string FileReadAllTexts(string path)
        {
          string metindegeri =   File.ReadAllText(path);
            return metindegeri;
        }
    }
}
