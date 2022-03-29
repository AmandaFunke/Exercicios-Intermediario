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
                Console.WriteLine("Creating a new post!\nType the Title: ");
                var title = Console.ReadLine();

                Console.WriteLine("Type the Description: ");
                var description = Console.ReadLine();

                var post = new Post(title, description);

                Console.WriteLine("Votes: " + post.Votes);
                Console.WriteLine("Press U to Up-Vote or D to Down-Vote this post, or press N to create a New Post");
                
                var voting = true;

                while (voting)
                {   
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
                        default:
                            Console.WriteLine("Invalid option");

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

        public Post(string title, string description)
        {            
            Title = title;
            Description = description;
            Creation = DateTime.Now.ToString();

            Console.WriteLine($"Title: {Title}\nDescription: {Description}\nCreation: {Creation}");
        }

        public int UpVote()
        {
            _vote++;
            Console.WriteLine("Votes:" + _vote);
            return _vote;
        }

        public int DownVote()
        {
            _vote--;
            Console.WriteLine("Votes:" + _vote);
            return _vote;
        }

        public int Votes
        {
            get { return _vote; }
        }
    }
}
