using System;

namespace AdultMadLibs
{

    class Program
    {

        static void Main(string[] args)
        {
            int age = 0;

            // Set console title
            Console.Title = " ***Let's Play Adult Mad Libs!***";
            Console.WriteLine(Console.Title);

            Console.WriteLine("With this game, we will need certian things from you. But since this is an adult game, you will need to be 18 or older to play. Please tell me your age.");
            age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("Sorry, you can not play.");
                return;
            }

            // Info From User //
            Console.WriteLine("Alright first, tell me your Crush's name. Promise I won't tell...");
            string crush = Console.ReadLine();
            Console.WriteLine("Give me a verb.");
            string verb = Console.ReadLine();
            Console.WriteLine("What room is your favorite?");
            string room = Console.ReadLine();
            Console.WriteLine("Now give me a plural noun.");
            string pluralNoun = Console.ReadLine();
            Console.WriteLine("Body part, you can go as nasty or G rated as you want..");
            string bodyPart = Console.ReadLine();
            Console.WriteLine("Piece of furniture?");
            string pieceOfFurniture = Console.ReadLine();
            Console.WriteLine("An adjective?");
            string adjective = Console.ReadLine();
            Console.WriteLine("How about an adverb?");
            string adverb = Console.ReadLine();
            Console.WriteLine("I know it's alot, we're almost done. Give me a number.");
            int randomNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Can you give me the time?");
            string time = Console.ReadLine();
            Console.WriteLine("Now give me some multiple body parts.");
            string bodyParts = Console.ReadLine();
            Console.WriteLine("Favorite musician?");
            string musician = Console.ReadLine();
            Console.WriteLine("What's your favorite food? We should date after all this, with all the questions I'm asking you. ;) ");
            string food = Console.ReadLine();
            Console.WriteLine("Favorite shoe brand (plural).");
            string shoeBrand = Console.ReadLine();
            Console.WriteLine("Lastly, give me a number. Now we can see what you made for a story.");
            int number01 = int.Parse(Console.ReadLine());


            Console.WriteLine($"You were suddenly feeling frisky so you asked {crush} if he/she wanted to {verb} in the {room} with you.\nNormally, you use this room to store your vast collection of {pluralNoun}, but this time you felt like switching things up.\nYou just knew he was ready to go when he propped his {bodyPart} up on the {pieceOfFurniture} and gave you his {adjective} bedroom eyes.\nAfter {adverb} going at it for {randomNumber} minutes, you both climaxed at the exact same time {time}!\nBut then you looked deep into each other's {bodyParts} and knew exactly what the other one wanted, one more round.\nYou put on {musician} greatest hits, lit a few {food} scented candles and knocked {shoeBrand} for {number01} more hours!");













            
        }
    }
}

