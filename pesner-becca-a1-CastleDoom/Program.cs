//Step 1: Get player's name


using System;

Console.WriteLine("Greetings traveler, what is your name?");
string name = Console.ReadLine();
Console.WriteLine($"Welcome, {name}!");

//Step 2: Introduce player to setting and weapons


Console.WriteLine("You have entered the castle of the great Rattlesnake Gizzard!");
Console.WriteLine("You have heard they hold many treasures deep in this castle.");
Console.WriteLine("There is an axe to your [left] and a sword to your [right].");
Console.WriteLine("Choose one to help you get through this castle of DOOM!");


//Step 3: Check player's response, axe or sword

string input = Console.ReadLine();

//Step 3a: Player chooses left

if (input == "left")
{
    Console.WriteLine("You have chosen the axe. A wise choice!");
}

//Step 3b: Player chooses right

else if (input == "right")
{
    Console.WriteLine("You have chosen the sword. A wise choice!");
}


//Step 4: Introduce player to hallway with a door with a star or a door with a moon


Console.WriteLine("You continue down the hallway wearily holding your weapon.");
Console.WriteLine("You pass by many portraits of lords and ladies.");
Console.WriteLine("You approach two doors at the end of the hall, one with a [star] crest and the other with a [moon] crest.");
Console.WriteLine("Which door do you dare to open?");

string input2 = Console.ReadLine();


//Step 5: Check player's response, star or moon door
 

if (input2 == "star")
{
    Console.WriteLine("You gain the courage to open the door with the star crest. *creaaaaak* There is a skeleton wielding a sword!");
    Console.WriteLine("You must defend yourself, [attack]!");
    string input3 = Console.ReadLine();
    if (input3 == "attack")
    {
        Console.WriteLine("You attack the skeleton and they die.");
        Console.WriteLine("You may continue through the next hallway.");
    }
}
else if (input2 == "moon")
{
    Console.WriteLine("You gain the courage to open the door with the moon crest.*creaaaaak*");
    Console.WriteLine("This room seems to be safe. You may continue through to the next hallway.");
}


//Step 6: Introduce player to the next hallway with the treasure room


Console.WriteLine("There is a big door with the letters 'RG' on it. This must be where the treasure is!");
Console.WriteLine("You gain the courage to [open] the door!");
string input4 = Console.ReadLine();

int myGold = 5000;

if (input4 == "open")
{
    Console.WriteLine("There it is!!!");
    Console.WriteLine("THE TREASURE! LOOK AT ALL THIS GOLD!");
    Console.WriteLine($"{name} has obtained {myGold} gold!");
    Console.WriteLine("Leave the castle with your treasure!");
}

//Step 7: Introduce the player to the two exit doors


Console.WriteLine("There are two doors that lead to the exit of the castle.");
Console.WriteLine("One door has a [gold pouch] crest on it and the other one has a [gold bar] crest on it. Could this lead to more gold?!");
Console.WriteLine("Which door do you dare to open?");

//Step 8: Check player's response, axe or sword

string input5 = Console.ReadLine();

//Step 3a: Player chooses gold pouch

if (input5 == "gold pouch")
{
    Console.WriteLine($"You open the door and are free to exit the castle! Well done, {name}!!!");
}

//Step 3b: Player chooses gold bar

else if (input5 == "gold bar")
{
    Console.WriteLine("You go to open the door with the gold bar and a GOBLIN appears!");
    Console.WriteLine("The goblin won't let you pass unless you give them half your gold!");
    myGold -= 2500;
    Console.WriteLine($"You now have {myGold} gold!");
    Console.WriteLine($"The goblin allows you to leave the castle. Well done, {name}!!!");
}

bool foundTheTreasure = false;
Console.WriteLine($"Did you find the treasure {!foundTheTreasure}");