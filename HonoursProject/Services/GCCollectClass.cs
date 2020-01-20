using System;
namespace HonoursProject.Services
{
    public class GCCollectClass
    {

        public static long GetMemUsage()
        {
            var memUsage = GC.GetTotalMemory(false);

            Console.WriteLine(memUsage);

            return memUsage;
        }
    }
}
