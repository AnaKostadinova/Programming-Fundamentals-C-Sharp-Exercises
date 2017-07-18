using System;
using System.Collections.Generic;
using System.Linq;

public class SocialMediaPosts
{
    public static void Main()
    {
        Dictionary<string, int> postLikes = new Dictionary<string, int>();
        Dictionary<string, int> postDislikes = new Dictionary<string, int>();
        Dictionary<string, Dictionary<string, string>> comments = new Dictionary<string, Dictionary<string, string>>();
        string input = Console.ReadLine();

        while (input != "drop the media")
        {
            string commentContent = string.Empty;

            string[] elements = input.Split();
            if (!postLikes.ContainsKey(elements[1]))
            {
                if (!comments.ContainsKey(elements[1]))
                {
                    if (!postDislikes.ContainsKey(elements[1]))
                    {
                        postLikes.Add(elements[1], 0);
                        postDislikes.Add(elements[1], 0);
                        comments.Add(elements[1], new Dictionary<string, string>());
                    }
                }
            }
            if (elements[0] == "like")
            {
                postLikes[elements[1]]++;
            }
            else if (elements[0] == "dislike")
            {
                postDislikes[elements[1]]++;
            }
            else if (elements[0] == "comment")
            {
                comments[elements[1]][elements[2]] = String.Empty;

                for (int i = 3; i < elements.Length; i++)
                {
                    commentContent += elements[i] + " ";
                }
                comments[elements[1]][elements[2]] = commentContent;
            }

            input = Console.ReadLine();
        }

        foreach (var like in postLikes)
        {
            foreach (var dislike in postDislikes)
            {
                if (like.Key == dislike.Key)
                {
                    Console.WriteLine($"Post: {like.Key} | Likes: {like.Value} | Dislikes: {dislike.Value}");
                }
            }

            foreach (var kvp in comments)
            {
                if (kvp.Key == like.Key)
                {
                    Console.WriteLine("Comments: ");
                }
                else
                {
                    continue;
                }

                if (kvp.Value.Count == 0)
                {
                    Console.WriteLine("None");
                    break;
                }

                foreach (var comment in kvp.Value)
                {
                    Console.WriteLine($"*  {comment.Key}: {comment.Value}");
                }
            }
        }
    }
}