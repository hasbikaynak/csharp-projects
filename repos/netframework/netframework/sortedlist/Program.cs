using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortedList s1 = new SortedList();
            //s1.Add(1, "bir");
            //s1.Add(2, "iki");
            //s1.Add(3, "uc");


            //Stack s2 = new Stack(); // icerisindeki objeleri "last in , first out" metoduyla siralar
            //s2.Push("agzini kirarin");
            //s2.Push("hasan2salakosman4");
            //s2.Push("caresiz derdimin sebebi belli");
            //s2.Push("ihhhhh");



            //object o1 = s2.Pop(); // en son objeyi secer ve onu listeden cikarir
            //object o2 = s2.Peek(); // yine en son objecyi secer ama onu listeden cikarmaz

            Queue s3 = new Queue(); // objeleri bizim girdigimiz gibi ki idex numaralari ile dizer.
            s3.Enqueue("ANAN");
            s3.Enqueue("BABAN");
            s3.Enqueue("BACIN");
            s3.Enqueue("DEDEN");

            object o1 = s3.Peek(); // stackteki gibi ancak ilk objeyi baz alir ama onu listeden cikarmaz 
            object o2 = s3.Dequeue(); // ilk objeyi baz alir ve onu listeden cikarir.

        }
    }
}
