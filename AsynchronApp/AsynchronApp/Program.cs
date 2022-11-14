using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronApp
{

    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Apartment renovation");
            CreateDesignProject();

            var furnishings = Furnishings();
            var floorRepair = FloorRepair();
            var wallRepair = WallRepair();
            
            CeilingRepair();

            await floorRepair;
            await furnishings;
            await wallRepair;

        }
        static void CreateDesignProject()
        {
            Console.WriteLine("Create gesign project");
        }

        static async Task FloorRepair()
        {
            Console.WriteLine("Removing old wood floor");
            Console.WriteLine("Pour floor screed and wait for it to dry");
            await Task.Delay(5000);
            Console.WriteLine("Lay laminate");
        }

        static async Task WallRepair()
        {
            Console.WriteLine("Removing old wallpaper");
            Console.WriteLine("Wall plaster");
            await Task.Delay(2000);
            Console.WriteLine("Put up new wallpaper");
            await Task.Delay(2000);

        }

        static void CeilingRepair()
        {
            Console.WriteLine("Removing old ceiling wallpaper");
            Console.WriteLine("Put up new stretch ceiling");

        }

        static async Task Furnishings()
        {
            Console.WriteLine("Buy furnishings");
            await Task.Delay(6000);
            Console.WriteLine("Put furnishings");
        }
    }
}

