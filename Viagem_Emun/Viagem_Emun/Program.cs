using System;
using Viagem_Emun.Entities;
using System.Globalization;

namespace Viagem_Emun
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c11 = new Comment("Have a nice trip!");
            Comment c12 = new Comment("Wow that's awesomw!");

            Post p1 = new Post(
                DateTime.Now,
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);

            p1.AddComment(c11);
            p1.AddComment(c12);

            Console.WriteLine(p1);
        }
    }
}
