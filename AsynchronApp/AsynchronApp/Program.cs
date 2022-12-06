using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronApp
{

    class Program
    {
        static async Task Main(string[] args)
        {

            await StartRepair.Start();

        }

    }

}

