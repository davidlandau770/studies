Random random = new Random();

string[] weapons = { "Rocket", "Drone", "Tank" };
int start = 1;
int end = 10;
int[] houses = new int[random.Next(start, end)];
int numHouses;
int count = 0;
int numRandom;
int firstIndex;
bool firstBool = true;
int randTypeWeapons;

for (int i = 0; i < houses.Count(); i++)
{
    houses[i] = 1;
}

Console.WriteLine($"How many houses to destroy? (between {start} to {houses.Length})");
numHouses = Convert.ToInt32(Console.ReadLine());

while (count < numHouses)
{
    randTypeWeapons = random.Next(0, 3);
    numRandom = random.Next(houses.Length);
    if (numHouses > houses.Length || numHouses < start)
    {
        Console.WriteLine("You did not choose a valid number.");
        break;
    }
    else if (houses[numRandom] == 1)
    {
        if (firstBool == true)
        {
            firstIndex = numRandom;
            Console.WriteLine($"first Index: {firstIndex}");
            Console.WriteLine($"rand Type Weapons: {weapons[randTypeWeapons]}");
            firstBool = false;
        }
        houses[numRandom] = 0;
        count++;
    }
}
for (int i = 0; i < houses.Count(); i++)
{
    Console.WriteLine("all the houses: " + houses[i]);
}




Dictionary<string, string> dict = new Dictionary<string, string>();
Console.WriteLine("How many soldiers are there?");
int numSoldiers = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < numSoldiers; i++)
{
    Console.WriteLine("What is the soldier's name?");
    string name = Console.ReadLine();
    Console.WriteLine("What is the soldier's rank?");
    string rank = Console.ReadLine();
    if (name == "stop")
    {
        break;
    }
    else
    {
        dict[name] = rank;
    }
}
// לולאה על כל הפריטים במילון
foreach (KeyValuePair<string, string> pair in dict)
{
    Console.WriteLine("rank: " + pair.Value + ", name: " + pair.Key);
}
