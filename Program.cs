using System;

namespace CURSOCSHARP.PostandComments.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
               DateTime.Parse("21/06/2018 13:05:48"),
               "Travel to Tocantins!",
               "I'm going  to visit the wonderful state!",
               12
                );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Nice Family, good momments!");
            Comment c4 = new Comment("Hey, this dog is so big and cute!");
            Post p2 = new Post(
               DateTime.Parse("28/08/2018 08:08:18"),
               "My family and my dogs!",
               "Picture of my family!",
               40
                );
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
