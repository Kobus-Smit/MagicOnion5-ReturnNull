using Grpc.Net.Client;
using MagicOnion.Client;
using MyApp.Shared;

var channel = GrpcChannel.ForAddress("https://localhost:5001");
var client = MagicOnionClient.Create<IMyFirstService>(channel);
var result = await client.SumAsync(123, 456);
Console.WriteLine($"Result: {result}");