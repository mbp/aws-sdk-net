using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var config = new AmazonDynamoDBConfig
            {
                ServiceURL = "http://httpstat.us/200?sleep=5000",
            };
            var client = new Amazon.DynamoDBv2.AmazonDynamoDBClient("a", "b", config);
            using (var cts = new CancellationTokenSource(TimeSpan.FromSeconds(0.7)))
            {
                var response = await client.UpdateItemAsync("foo", new Dictionary<string, AttributeValue>(), new Dictionary<string, AttributeValueUpdate>(), cts.Token);
            }
        }
    }
}
