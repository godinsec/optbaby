using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ServiceStack.Redis;
using ServiceStack.Redis.Generic;
using ServiceStack.Text;
using Newtonsoft.Json;

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

            Console.WriteLine("receiveMessage 2 pop ....");

            while (true)
            {
                byte[][] value = redisCli.BLPop(list, 200);
                string alist = Encoding.Default.GetString(value[0]);
                string avalue = Encoding.Default.GetString(value[1]);
                //Console.WriteLine(alist + " : " + avalue);
                JsonReader reader = new JsonTextReader(new StringReader(avalue));
                while (reader.Read())
                {
                    Console.WriteLine(reader.Value);
                }
            }

        }
    }


}
