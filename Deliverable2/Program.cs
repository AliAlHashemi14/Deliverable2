int totalDrinks = 0;

Console.WriteLine("Welcome to the buffet! The cost is $9.99 per person, and $2.00 for a sprite! \n How many people are dining in? Parties of 6 or lower, please.");
int customerCount = Int32.Parse(Console.ReadLine());

if (customerCount <= 6)
{
    Console.WriteLine($"Okay, seating for {customerCount}! \n let's get started with drinks. We have water or sprite.");

    for (int i = 1; i <= customerCount;)
    {
        Console.WriteLine($"Customer number {i}, would you like water or a sprite?");
        string response = Console.ReadLine();
        if (response == "sprite")
        {
            totalDrinks++;
            i++;
            Console.WriteLine("Okay, a sprite it is!");
        }
        else if (response == "water")
        {
            i++;
            Console.WriteLine("Okay, a water it is!");
        }
        else
        {
            Console.WriteLine("Sorry, I did not catch that.");
        }

    }

    double total = (customerCount * 9.99) + (totalDrinks * 2);
    Console.WriteLine($"Okay, so that's a total of {totalDrinks} soft drinks, and the rest will have water. \n So, your total is ${total}. Enjoy!");
    Console.Read();

}
else
{
    Console.WriteLine("Sorry, we can only seat groups of 6 or lower. Have a wonderful day!");
    Console.Read();
    
}
