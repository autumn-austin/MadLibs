using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            This is a short Mad Libs program
            that was created by
            Autumn Austin
            */

            // The Mad Libs will be starting now

            // Give the Mad Lib a title:
            string title = "Wake UP";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your first adjective: ");
            string adj1 = Console.ReadLine();

            Console.Write("Enter your second adjective: ");
            string adj2 = Console.ReadLine();

            Console.Write("Enter your third adjective: ");
            string adj3 = Console.ReadLine();

            Console.Write("Enter a verb: ");
            string verb1 = Console.ReadLine();

            Console.Write("Enter your first noun: ");
            string noun1 = Console.ReadLine();

            Console.Write("Enter your second noun: ");
            string noun2 = Console.ReadLine();

            Console.Write("How about an animal? ");
            string anim = Console.ReadLine();

            Console.Write("And now a food? ");
            string food = Console.ReadLine();

            Console.Write("And now a fruit! ");
            string fruit = Console.ReadLine();

            Console.Write("Who is your favorite Superhero? ");
            string hero = Console.ReadLine();

            Console.Write("Give me a random country! ");
            string country = Console.ReadLine();

            Console.Write("What is your favorite dessert? ");
            string dess = Console.ReadLine();

            Console.Write("What year were you born? ");
            string year = Console.ReadLine();

            // The template for the story:

            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a " +
                $"bunch of {anim}s were protesting to keep {food} in stores. They began to {verb1} to the rhythm of " +
                $"the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {hero}, who flew " +
                $"{name} to {country} and dropped {name} in a puddle of frozen {dess}. {name} woke up in the year " +
                $"{year}, in a world where {noun2}s ruled the world.";


            // Print the story:

            Console.WriteLine(story);

        }
    }
}
