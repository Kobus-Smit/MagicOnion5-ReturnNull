using Grpc.Net.Client;
using MagicOnion.Client;
using MyApp.Shared;

var channel = GrpcChannel.ForAddress("https://localhost:5001");
var client = MagicOnionClient.Create<IMyFirstService>(channel);

await Task.Delay(TimeSpan.FromSeconds(2));

var result = await client.SumAsync(123, 456);
Console.WriteLine($"Result: {result}");

try
{
    var result2 = await client.ReturnNull();
    Console.WriteLine($"Result2: {result2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

try
{
    var result3 = await client.HasNullParameter(null);
    Console.WriteLine($"Result3: {result3}");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();