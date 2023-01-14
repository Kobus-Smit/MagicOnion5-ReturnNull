using Grpc.Net.Client;
using MagicOnion.Client;
using MyApp.Shared;

var channel = GrpcChannel.ForAddress("https://localhost:5001");
var client = MagicOnionClient.Create<IMyFirstService>(channel);

await Task.Delay(TimeSpan.FromSeconds(2));

var result = await client.SumAsync(123, 456);
Console.WriteLine($"Result: {result}");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();