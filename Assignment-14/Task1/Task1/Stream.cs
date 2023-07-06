using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.WebRequestMethods;

namespace Task1
{
    //var Stream = new Task1.Stream();
    //FileStream file = new FileStream(@"C:\\Users\\IrmTabatadze\\Desktop\\Irma\\Assignment-02\\ttt2.txt", FileMode.Open, FileAccess.Read);

    //string result = Stream.PeekStream();
    //Console.WriteLine(result);
    public class Stream
    {
        public Stream() 
        { 
        }

       public static string PeekStream()
        {   
            var File1 = new FileStream(@"C:\\Users\\IrmTabatadze\\Desktop\\Irma\\Assignment-02\\ttt2.txt", FileMode.Open, FileAccess.Read);
            if (File1.CanSeek)
            {
                return "Can Seek";
            }
            else
            {
                return "Can't Seek";
            }

            File1.Close();
        }
    }
}
