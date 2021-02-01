using System;
using System.Collections.Generic;
using System.IO;

namespace Json_okuma
{
    class Program
    {
        static void Main(string[] args)
        {
           string jsonokunandata =  File.ReadAllText("C:\\JsonIslemlerim\\Personellerim.json");
            List<XObject> Data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<XObject>>(jsonokunandata);
            for (int i = 0; i < Data.Count; i++)
            {
                Console.WriteLine(Data[i]);
            }
            Console.ReadLine();
        }
    }
}
