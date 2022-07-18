// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

double buffetPrice = 9.99;
int winePrice = 4;
int beerPrice = 2;
int partySize = 0;
int totalWinePrice = 0;
int totalBeerPrice = 0;
double totalBuffetPrice = 0;
double totalCost = 0;
int numWineOrdered = 0;
int numBeerOrdered = 0;

Console.WriteLine("How big is your party?");
partySize = int.Parse(Console.ReadLine());

if (partySize <= 6)
{
    Console.WriteLine($"Great, a table for {partySize}.");
    Console.WriteLine("Your choice of drinks today are either Wine or Beer.");
    for (int seatNumber = 1; seatNumber < partySize + 1; seatNumber++)
    {

        Console.WriteLine($"For you in seat {seatNumber}, what would you like to drink?");
        Console.WriteLine();
        string drinkOrder = Console.ReadLine();
        if (drinkOrder.ToLower() == "wine")
        {
            Console.WriteLine("Great a wine for you"); numWineOrdered++;
            Console.WriteLine();
        }
        else if (drinkOrder.ToLower() == "beer")
        {
            Console.WriteLine("Great a beer for you"); numBeerOrdered++;
            Console.WriteLine();
        }
        else if (drinkOrder.ToLower() != "wine" && drinkOrder.ToLower() != "beer")
        {
            Console.WriteLine("Sorry but that item is not on our menu today");
        }


    }
    Console.WriteLine($"you have ordered {numWineOrdered} wine(s) and {numBeerOrdered} beer(s).");
    totalWinePrice = (numWineOrdered * winePrice);
    totalBeerPrice = (numBeerOrdered * beerPrice);
    totalBuffetPrice = (partySize * buffetPrice);
    totalCost = (totalWinePrice + totalBeerPrice + totalBuffetPrice);
    Console.WriteLine($"Your total for tonight is ${totalCost}. Thanks for coming!");
    Console.WriteLine();
}
else Console.WriteLine("Sorry your group is too big.");


