using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        private static int cnt = 0;
        public static readonly object obj = new object();
        private static readonly Lazy<Singleton> abc = new Lazy<Singleton>(()=> new Singleton());
        public static Singleton GetSingleton
        {
            get
            {
                return abc.Value;
            }
        }
        private Singleton()
        {
            cnt++;
            Console.WriteLine("Count: " + cnt);
        }
        public void PrintIt(string message)
        {
            Console.WriteLine(message);
        }
    }
}
