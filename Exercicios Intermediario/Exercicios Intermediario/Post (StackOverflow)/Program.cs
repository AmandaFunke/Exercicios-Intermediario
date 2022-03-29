using System;

namespace Post__StackOverflow_
{
    /* Design a class called Post. 
     * This class models a StackOverflow post. 
     * It should have properties for title, description and the date/time it was created. 
     * We should be able to up-vote or down-vote a post. 
     * We should also be able to see the current vote value. 
     * In the main method, create a post, up-vote and down-vote it a few times and then display the the current vote value. 
     * In this exercise, you will learn that a StackOverflow post should provide methods for up-voting and down-voting. 
     * You should not give the ability to set the Vote property from the outside, because otherwise, 
     * you may accidentally change the votes of a class to 0 or to a random number. 
     * And this is how we create bugs in our programs. 
     * The class should always protect its state and hide its implementation detail. 
     * Educational tip: 
     * The aim of this exercise is to help you understand that classes should encapsulate data AND behaviour around that data. 
     * Many developers (even those with years of experience) tend to create classes that are purely data containers, 
     * and other classes that are purely behaviour (methods) providers. 
     * This is not object-oriented programming. This is procedural programming. Such programs are very fragile. 
     * Making a change breaks many parts of the code.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            var newPost = true;

            while (newPost)
            {
                Console.Clear();
                Console.Write("Creating a new post!\nInsert here the Title: ");
                var title = Console.ReadLine();

                Console.Write("Insert here the Description: ");
                var description = Console.ReadLine();

                var post = new Post(title, description);

                var voting = true;

                while (voting)
                {
                    Console.Clear();
                    Console.WriteLine("Here is your post:\n");

                    Console.WriteLine($"Title: {post.Title}\n" +
                        $"Description: {post.Description}\n" +
                        $"Creation: {post.Creation}");

                    Console.WriteLine("Votes: " + post.Votes);
                    Console.WriteLine("\nPress U to Up-Vote\n" +
                        "Press D to Down-Vote\n" +
                        "Press N to create a New Post\n" +
                        "Press Q to Quit\n");

                    var vote = Console.ReadLine().ToLower();

                    switch (vote)
                    {
                        case "u":
                            post.UpVote();
                            
                            break;
                        case "d":
                            post.DownVote();

                            break;
                        case "n":
                            voting = false;

                            break;
                        case "q":
                            voting = false; 
                            newPost = false;

                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            Console.ReadKey();

                            break;
                    }                    
                }                
            }                       
        }
    }

    public class Post
    {
        public string Title;
        public string Description;
        public string Creation;
        private int _vote = 0;

        public int Votes
        {
            get
            {
                return _vote;
            }
        }

        public Post(string title, string description)
        {            
            Title = title;
            Description = description;
            Creation = DateTime.Now.ToString();
        }

        public int UpVote()
        {
            _vote++;
            return _vote;
        }

        public int DownVote()
        {
            _vote--;
            return _vote;
        }        
    }
}
