using System;
using System.Collections.Generic;
using System.Linq;



class Program
{
    static void Main()
    {
        var socialMedia = new Dictionary<string, Dictionary<string, List<string>>>();

        var input = Console.ReadLine();

        while (input != "drop the media")
        {
            var tokens = input.Split(' ').ToArray();
            var command = tokens[0];
            var postName = tokens[1];

            if (!socialMedia.ContainsKey(postName))
            {
                socialMedia[postName] = new Dictionary<string, List<string>>();
            }

            if (command == "like")
            {
                if (!socialMedia[postName].ContainsKey("like"))
                {
                    socialMedia[postName]["like"] = new List<string>();
                }

                socialMedia[postName]["like"].Add(command);
            }
            else if (command == "dislike")
            {
                if (!socialMedia[postName].ContainsKey(command))
                {
                    socialMedia[postName][command] = new List<string>();
                }

                socialMedia[postName][command].Add(command);
            }
            else if (command == "comment")
            {
                var writer = tokens[2];
                int length = command.Length + postName.Length + writer.Length + 3;
                var comment = input.Substring(length);

                if (!socialMedia[postName].ContainsKey(writer))
                {
                    socialMedia[postName][writer] = new List<string>();
                }

                socialMedia[postName][writer].Add(comment);
            }

            input = Console.ReadLine();
        }

        foreach (var post in socialMedia)
        {
            var likes = 0;
            var dislikes = 0;
            var wrieters = post.Value;

            foreach (var item in post.Value)
            {
                if (item.Key == "like")
                {
                    likes = item.Value.Count;
                }
                else if (item.Key == "dislike")
                {
                    dislikes = item.Value.Count;
                }
            }

            Console.WriteLine($"Post: {post.Key} | Likes: {likes} | Dislikes: {dislikes}");
            Console.WriteLine("Comments:");

            bool noComment = true;
            foreach (var kvp in post.Value)
            {
                if (kvp.Key != "like" && kvp.Key != "dislike")
                {
                    noComment = false;
                    foreach (var element in kvp.Value)
                    {
                        Console.WriteLine($"*  {kvp.Key}: {element}");
                    }
                }
            }

            if (noComment)
            {
                Console.WriteLine("None");
            }
        }

    }

}

