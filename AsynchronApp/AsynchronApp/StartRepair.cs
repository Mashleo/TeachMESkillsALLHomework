using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronApp
{
    public class StartRepair
    {
        public static async Task Start()
        {
            Console.WriteLine("Apartment renovation");
            CreateDesignProject();

            var wall = WallRepair();
            var floor = FloorRepair();
            Roof ceiling = CeilingRepair();
            Wall _wall = await wall;
            Floor _floor = await floor;
            var readyOrNot = EndRenovation(_wall, _floor, ceiling);
            var mebel = Furnishings(readyOrNot);

            await mebel;
            await wall;
            await floor;
        }
        public static bool EndRenovation(Wall wall, Floor floor, Roof roof)
        {
            Console.WriteLine("House ready for furniture installation");
            return true;
        }

        static void CreateDesignProject()
        {
            Console.WriteLine("Create gesign project");
            Console.WriteLine("Start buy furnishings");
        }

        static async Task Furnishings(bool trigger)
        {
            
            await Task.Run(() =>
            {
                if (trigger)
                {
                    Console.WriteLine("Put furnishings");
                    Console.WriteLine("!DONE!");
                }
            });
        }

        public static async Task<Wall> WallRepair()
        {
            Console.WriteLine("Removing old wallpaper");
            Console.WriteLine("Wall plaster");
            await Task.Delay(2000);
            Console.WriteLine("Put up new wallpaper");
            await Task.Delay(2000);
            return new Wall();

        }

        public static async Task<Floor> FloorRepair()
        {
            Console.WriteLine("Removing old wood floor");
            Console.WriteLine("Pour floor screed and wait for it to dry");
            await Task.Delay(5000);
            Console.WriteLine("Lay laminate");
            return new Floor();
        }

        public static Roof CeilingRepair()
        {
            Console.WriteLine("Removing old ceiling wallpaper");
            Console.WriteLine("Put up new stretch ceiling");
            return new Roof();

        }
    }
}
