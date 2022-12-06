using System;
using System.Threading;

namespace SynchronousApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Apartment renovation");
            CreateDesignProject();
            FloorRepair();
            WallRepair();
            CeilingRepair();
            Furnishings();

        }
        static void CreateDesignProject()
        {
            Console.WriteLine("Create gesign project");
        }

        static void FloorRepair()
        {
            Console.WriteLine("Removing old wood floor");
            Console.WriteLine("Pour floor screed and wait for it to dry");
            Thread.Sleep(5000);
            Console.WriteLine("Lay laminate");
        }
        static void WallRepair()
        {
            Console.WriteLine("Removing old wallpaper");
            Console.WriteLine("Wall plaster");
            Console.WriteLine("Put up new wallpaper");

        }
        static void CeilingRepair()
        {
            Console.WriteLine("Removing old ceiling wallpaper");
            Console.WriteLine("Put up new stretch ceiling");

        }
        static void Furnishings()
        {
            Console.WriteLine("Buy furnishings");
            Console.WriteLine("Put furnishings");
        }
    }
}
