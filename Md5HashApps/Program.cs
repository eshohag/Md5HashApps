using System;

namespace Md5HashApps
{
    class Program
    {
        static void Main(string[] args)
        {
            string encriptPassword = Md5Hash.Md5HashEncription("shohag");
            Console.WriteLine(encriptPassword);
            Console.ReadKey();
        }
    }
}
