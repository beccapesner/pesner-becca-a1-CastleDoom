//Step 0: Get player's name
Console.WriteLine("Greetings traveler, what is your name?");
string name = Console.ReadLine();
Console.WriteLine($"Welcome, {name}!");

//Step 1: Introduce player to setting and weapons
Console.WriteLine("You have entered the castle of the great Rattlesnake Gizzard!");
Console.WriteLine("You have heard they hold many treasures deep in this castle.");
Console.WriteLine("There is an axe to your [left] and a sword to your [right].");
Console.WriteLine("Choose one to help you get through this castle of DOOM!");

string input = Console.ReadLine();
//Step 2: Check player's response, axe or sword
if (input == "left")
{
    Console.WriteLine("You have chosen the axe. A wise choice!");
}
else if (input == "right")
{
    Console.WriteLine("You have chosen the sword. A wise choice!");
}
//Step 3: Introduce player to hallway with a door with a star or a door with a moon
Console.WriteLine("You continue down the hallway wearily holding your weapon.");
Console.WriteLine("You pass by many portraits of lords and ladies.");
Console.WriteLine("You approach two doors at the end of the hall, one with a [star] crest and the other with a [moon] crest.");
Console.WriteLine("Which door do you dare to open?");

string input2 = Console.ReadLine();
//Step 4: Check player's response, star or moon door
if (input2 == "star")
{
    Console.WriteLine("You gain the courage to open the door with the star crest. *creaaaaak* There is a skeleton wielding a sword!");
    Console.WriteLine("You must defend yourself, [attack]!");
}
string input3 = Console.ReadLine();
if (input3 == "attack")
{
    Console.WriteLine("You attack the skeleton and they die.");
    Console.WriteLine("You may continue through the next hallway.");
}
else if (input2 == "moon")
{
    Console.WriteLine("You gain the courage to open the door with the moon crest.*creaaaaak*");
    Console.WriteLine("This room seems to be safe. You may continue through to the next hallway.");
}
//Step 5: Introduce player to the next hallway with the treasure room
Console.WriteLine("There is a big door with the letters 'RG' on it. This must be where the treasure is!");
Console.WriteLine("You gain the courage to [open] the door!");
string input4 = Console.ReadLine();

if (input4 == "open")
{
    Console.WriteLine("There it is!");
    Console.WriteLine("THE TREASURE!");