using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using TweetSharp;

namespace TwitterAPITest
{
    class Program
    {
        private static string customer_key = "E0PEEBZ5Lc9I7UUJYrjCpJREY";
        private static string customer_key_secret = "gzoElfbzkWqbzIgwASF7CNpVDlOdAhPpYbFpcXdAqPXVPHUSiS";
        private static string access_token = "21425165-dZfigXCYZNz0pHaPD6MQgA407fqb7pYGpHZb8xBeF";
        private static string access_token_secret = "TNrbCkQ7rPzM3uBjrPVFWrjt8WRhRl9kNSfzYrsdwJ8gL";

        private static TwitterService service = new TwitterService(customer_key, customer_key_secret, access_token, access_token_secret);

        static void Main(string[] args)
        {
            Console.WriteLine($"<{DateTime.Now}>");

        }

        private static void SendTweet(string _status)
        {

        }
    }
}
