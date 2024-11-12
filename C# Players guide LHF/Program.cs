// See https://aka.ms/new-console-template for more information

// Knowledge Check: 1
// Question: 1
// TRUE/FALSE: True
// What is the name of the fremwork that C# is built on?: .NET

//Challenge Instal Visual Studio 


//Challenge: Hello World
//Console.WriteLine("Hello, World!");

//Challenge: What comes next?
//Console.WriteLine("Ladida bla bla blaa");


//Challenge: The makings of a programmer
//Console.WriteLine("I'm a programmer now!");
//Console.WriteLine("Answer: There can be as many statements as you want to build in it"); 


//Challenge: Consolas and Telim
//Console.WriteLine("Bread is ready");
//Console.WriteLine("Who is the bread ready for?");
//string person = Console.ReadLine();
//Console.WriteLine("Noted " + person + " got bread");

//Challenge: The thing namer 3000
//Console.WriteLine("What kind of thing are we talking about");
//string a = Console.ReadLine();
//Console.WriteLine("How would you describe it? ex. Big, Blue, Tattered?");
//string b = Console.ReadLine();
//string c = "Doom";
//string d = "3000";
//Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");

//Knowledge Check: 2
//Question: 1: name, 2: type, 3: value
//Question: 2: True
//Question: 3: No
//Question: 4: answer, value1, delete-me, PI

//Challenge: The The variable shop
//Declaration and then initialization

//int a = 3;
//uint b= 3;
//short c = 3;
//ushort d = 3;
//long e = 3;
//ulong f = 3;
//byte g = 3;
//sbyte h = 3;
//char i = '3';
//string j = "3";
//bool k = true;
//float l = 3.0f;
//double m = 3.0;
//decimal n = 3.0m;

//Display
//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);
//Console.WriteLine(d);
//Console.WriteLine(e);
//Console.WriteLine(f);
//Console.WriteLine(g);
//Console.WriteLine(h);
//Console.WriteLine(i);
//Console.WriteLine(j);
//Console.WriteLine(k);
//Console.WriteLine(l);
//Console.WriteLine(m);

//Challenge: The The variable shop returns
//Declaration and then initialization
//int a = 3;
//uint b = 3;
//short c = 3;
//ushort d = 3;
//long e = 3;
//ulong f = 3;
//byte g = 3;
//sbyte h = 3;
//char i = '3';
//string j = "3";
//bool k = true;
//float l = 3.0f;
//double m = 3.0;
//decimal n = 3.0m;

//updates
//a= 4;
//b = 4;
//c = 4;
//d = 4;
//e = 4;
//f = 4;
//g = 4;
//h = 4;
//i = '4';
//j = "4";
//k = false;
//l = 4.0f;
//m = 4.0;
//n = 4.0m;

//Display
//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);
//Console.WriteLine(d);
//Console.WriteLine(e);
//Console.WriteLine(f);
//Console.WriteLine(g);
//Console.WriteLine(h);
//Console.WriteLine(i);
//Console.WriteLine(j);
//Console.WriteLine(k);
//Console.WriteLine(l);
//Console.WriteLine(m);


//Knowledge Check: 3
//1: False
//2: byte, short, int long
//3: False  
//4: Uint
//5: float, double, decimal
//6: double
//7: decimal
//8: String
//9: bool

//Challenge: The Triangle Farmer
//Console.WriteLine("Hvad er trianglens bredde?");
//string bText = Console.ReadLine();
//float bredde = Convert.ToSingle(bText);

//Console.WriteLine("Hvad er trianglens højde?");
//string hText = Console.ReadLine();
//float højde = Convert.ToSingle(hText);

//float areal = (bredde * højde) / 2;
//Console.WriteLine("Arealet af trianglen er " + areal);

//Challenge: The four sisters and the duckbear
//Console.WriteLine("Hvor mange æg blev der samlet i dag?");

//int eggCount = Convert.ToInt32(Console.ReadLine());

//int fourSisters = eggCount / 4;
//int duckBear = eggCount % 4;

//Console.WriteLine("Hver af de fire søstre fik " + fourSisters + " æg");
//Console.WriteLine("Andebaren fik " + duckBear + " æg");

//Challenge: The Dominion Kings
//Console.WriteLine("How many provinces do you have ?");
//int provinces = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("How many duchies do you have?");
//int duchies = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("How many estates do you have?");
//int estates = Convert.ToInt32(Console.ReadLine());

//provinces = provinces * 6;
//duchies = duchies * 3;
//estates = estates * 1;

//Console.WriteLine("Your total score is " + (provinces + duchies + estates));

//Challenge: The defense of consolas
//Console.WriteLine("Where do you want to put your target?");

//Console.WriteLine("Choose a target row");
//int row = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Choose a target column");
//int column = Convert.ToInt32(Console.ReadLine());

//Console.ForegroundColor = ConsoleColor.Red;

//Console.WriteLine($"({row}, {column -1})");
//Console.WriteLine($"({row -1}, {column})");
//Console.WriteLine($"({row}, {column +1})");
//Console.WriteLine($"({row + 1}, {column})");

//Console.Beep();

//Challenge: Reparing the Clocktower
//Console.WriteLine("What time is it?");

//int time = Convert.ToInt32(Console.ReadLine());
//    //Tick if the number is even
//    if (time % 2 == 0)

//    {
//    Console.WriteLine("Tick");
//    }
//    else //Tock if the number is odd
//    {
//        Console.WriteLine("Tock");
//    }

//Challenge: Watchtower
//Console.WriteLine("To find the enemies location help and give the coordinates of x and y");

//Console.WriteLine("Type the x coordinate");
//int x = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Type the y coordinate");
//int y = Convert.ToInt32(Console.ReadLine());

//if (x < 0 && y > 0) Console.WriteLine("The enemy is to the north west");
//if (x == 0 && y > 0) Console.WriteLine("The enemy is to the north");
//if (x > 0 && y > 0) Console.WriteLine("The enemy is to the north east");
//if (x < 0 && y == 0) Console.WriteLine("The enemy is to the west");
//if (x == 0 && y == 0) Console.WriteLine("The enemy is here");
//if (x > 0 && y == 0) Console.WriteLine("The enemy is to the east");
//if (x < 0 && y < 0) Console.WriteLine("The enemy is to the south west");
//if (x == 0 && y < 0) Console.WriteLine("The enemy is to the south");
//if (x > 0 && y < 0) Console.WriteLine("The enemy is to the south east");


//Challenge: Buying inventory
//Console.WriteLine("Welcome to the Inventory Shop");
//Console.WriteLine("These are available items");
//Console.WriteLine("1. Rope");
//Console.WriteLine("2. Torches");
//Console.WriteLine("3. Climbing Equipment");
//Console.WriteLine("4. Clean Water");
//Console.WriteLine("5. Machete");
//Console.WriteLine("6. Canoe");
//Console.WriteLine("7. Food Supplies");

//Console.WriteLine("What would you like to see the price of? Type a number from above");
//int itemNumber = Convert.ToInt32(Console.ReadLine());

//string item = itemNumber switch
//{
//    1 => "Rope",
//    2 => "Torches",
//    3 => "Climbing Equipment",
//    4 => "Clean Water",
//    5 => "Machete",
//    6 => "Canoe",
//    7 => "Food Supplies",
//    _ => "Invalid"
//};

//int price = item switch
//{
//    "Rope"                  => 10,
//    "Torches"               => 15,
//    "Climbing Equipment"    => 25,
//    "Clean Water"           => 0,
//    "Machete"               => 20,
//    "Canoe"                 => 200,
//    "Food Supplies"         => 1,
//    _                       => 0
//};

//Console.WriteLine($"The price of {item} is {price} gold");

//Challenge: The Inventory Shop - friends price edition
Console.WriteLine("Welcome to the Inventory Shop");
Console.WriteLine("These are available items");
Console.WriteLine("1. Rope");
Console.WriteLine("2. Torches");
Console.WriteLine("3. Climbing Equipment");
Console.WriteLine("4. Clean Water");
Console.WriteLine("5. Machete");
Console.WriteLine("6. Canoe");
Console.WriteLine("7. Food Supplies");

Console.WriteLine("What would you like to see the price of? Type a number from above");
int itemNumber = Convert.ToInt32(Console.ReadLine());

string item = itemNumber switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies",
    _ => "Invalid"
};

int price = item switch
{
    "Rope" => 10,
    "Torches" => 15,
    "Climbing Equipment" => 25,
    "Clean Water" => 0,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supplies" => 1,
    _ => 0
};


Console.WriteLine("What is your name? Maybe there is a friends price");
string name = Console.ReadLine();

if (name == "Mikkel") price /= 2;

Console.WriteLine($"The price of {item} is {price} gold");
