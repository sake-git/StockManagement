
Console.WriteLine("Welcome to the restocking tool.\n");
int sodaInStock = 100;
int chipsInStock = 40;
int candyInStock = 60;
int sodaRestockValue = 40;
int chipsRestockValue = 20;
int candyRestockValue = 40;

//Check the Soda stock
Console.WriteLine("\nHow many Sodas have been sold today? " + sodaInStock +" are in stock");
int noOfSodaSold = int.Parse(Console.ReadLine());
if(noOfSodaSold <= sodaInStock)
{
    sodaInStock -= noOfSodaSold;
    Console.WriteLine("There are " + sodaInStock + " Sodas left");
}
else
{
    Console.WriteLine("That value is too high. Stock not adjusted");
}

//Check the Chips stock 
Console.WriteLine("\nHow many Chips have been sold today? "+ chipsInStock +" are in stock");
int noOfChipsSold = int.Parse(Console.ReadLine());
if(noOfChipsSold <= chipsInStock)
{
    chipsInStock -= noOfChipsSold;
    Console.WriteLine("There are " + chipsInStock + " Chips left");
}
else
{
    Console.WriteLine("That value is too high. Stock not adjusted");
}

//Check the Candy stock
Console.WriteLine("\nHow many Candy have been sold today? " + candyInStock +" are in stock");
int noOfCandySold = int.Parse(Console.ReadLine());
if(noOfCandySold <= candyInStock)
{
    candyInStock -= noOfCandySold;
    Console.WriteLine("There are " + candyInStock + " Candies left");
}
else
{
    Console.WriteLine("That value is too high. Stock not adjusted");
}

//Check if any item needs refilling
Console.WriteLine("\n\nThank you for filling out the values. Here’s what needs to be restocked.\n");
if(sodaInStock <= sodaRestockValue)
{
    Console.WriteLine("Soda needs to be restocked");
}
if (chipsInStock <= chipsRestockValue)
{
    Console.WriteLine("Chips needs to be restocked");
}
if (candyInStock <= candyRestockValue)
{
    Console.WriteLine("Candy needs to be restocked");
}

Console.WriteLine("\nGoodBye!");
Console.ReadLine();
