using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                ()=> PrintFromEmployee(),
                ()=> PrinFromStudent()
                );

            Console.ReadLine();
        }

        private static void PrinFromStudent()
        {
            Singleton fromStd = Singleton.GetSingleton;
            fromStd.PrintIt("msg2");
        }

        private static void PrintFromEmployee()
        {
            Singleton fromEmployee = Singleton.GetSingleton;
            fromEmployee.PrintIt("msg1");
        }
    }
}
