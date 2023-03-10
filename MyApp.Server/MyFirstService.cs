using MagicOnion;
using MagicOnion.Server;
using MyApp.Shared;

namespace MyApp.Services
{
    public class MyFirstService : ServiceBase<IMyFirstService>, IMyFirstService
    {
        public async UnaryResult<int> SumAsync(int x, int y)
        {
            Console.WriteLine($"Received:{x}, {y}");
            return x + y;
        }

        public async UnaryResult<MyObject?> ReturnNull()
        {
            MyObject? result = null;
            return result;
        }

        public async UnaryResult<int> HasNullParameter(string x)
        {
            return 1;
        }
    }
}