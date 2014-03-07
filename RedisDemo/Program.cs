using System;
using ServiceStack.Redis;

namespace RedisDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RedisClient("127.0.0.1", 6379);
            //var s = client.AddItemToSortedSet("12", "baidu", 400);
            //client.AddItemToSortedSet("12", "google", 300);
            //client.AddItemToSortedSet("12", "alibaba", 200);
            //client.AddItemToSortedSet("12", "sina", 100);
            //client.AddItemToSortedSet("12", "renren", 500);
            //client.AddItemToSortedSet("12", "tencent", 150);

            var list = client.GetRangeFromSortedSet("12", 0, 0);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //descending
            list = client.GetRangeFromSortedSetDesc("12", 0, 0);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
