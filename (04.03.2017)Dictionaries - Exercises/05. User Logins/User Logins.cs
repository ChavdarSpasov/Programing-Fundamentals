using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.User_Logins
{
    class Program
    {
        static void Main(string[] args)
        {
            var userPassDict = new Dictionary<string, string>();

            var line = Console.ReadLine();

            while (line != "login")
            {
                var currLine = line.Split();
                var username = currLine[0];
                var password = currLine[2];

                if (!userPassDict.ContainsKey(username))
                {
                    userPassDict[username] = string.Empty;
                }

                userPassDict[username] = password;

                line = Console.ReadLine();
            }

            line = Console.ReadLine();
            var unsuccessfulAttempts = 0;

            while (line != "end")
            {
                var currLine = line.Split();
                var username = currLine[0];
                var password = currLine[2];

                if (userPassDict.ContainsKey(username) && userPassDict.ContainsValue(password))
                {
                    Console.WriteLine($"{username}: logged in successfully");
                }
                else
                {
                    Console.WriteLine($"{username}: login failed");
                    unsuccessfulAttempts++;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine($"unsuccessful login attempts: { unsuccessfulAttempts}");
        }
    }
}
