using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ServiceStack.Redis;
using ServiceStack.Redis.Generic;
using ServiceStack.Text;

namespace ConsoleApplication1
{
    

    public class Program
    {
        private static RedisClient redisCli = null;
        private static string list = "job";

        public static void connectRedis()
        {
            if (redisCli == null)
            {
                redisCli = new RedisClient("127.0.0.1", 6379);
            }
        }


        static void Main(string[] args)
        {
            //testConnect();
            connectRedis();
            //string[] strs = { "a", "b", "c", "d", "e", "f", "g" };
            string[] strs = { @"{""a"" : ""a1"", ""b"" : ""b1""}", @"{""c"" : ""c1"", ""d"" : ""d1""}" };
            if (strs.Length != 0)//from args
            {
                foreach (string ss in strs)
                {
                    Console.WriteLine(ss);
                    redisCli.LPush(list, Encoding.Default.GetBytes(ss));//push into the head of list
                }
            }//if


        }
    }


}
