using System;

namespace Windows
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            


            Console.WriteLine("Hello User, what is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Thank you {name}. Can you tell me your favorite color?");
            var color = Console.ReadLine();
            Console.WriteLine($"Wow, {color} is my favorite color too! Now, tell me, what is your favorite animal?");
            var animal = Console.ReadLine();
            Console.WriteLine($"Oh no, a {animal} can scare me");
            Console.WriteLine($"Who is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Well {name}, I have an incredible story about what you just told me!");
            Console.WriteLine($"I was told that your favorite {animal} was {color} and that your {animal} used to travel with {band}'s everywhere they played.");
            
            




        }
    }
}
