// שאלות מהמצגת
//Random random = new Random();

//string[] weapons = { "Rocket", "Drone", "Tank" };
//int start = 1;
//int end = 10;
//int[] houses = new int[random.Next(start, end)];
//int numHouses;
//int count = 0;
//int numRandom;
//int firstIndex;
//bool firstBool = true;
//int randTypeWeapons;

//for (int i = 0; i < houses.Count(); i++)
//{
//    houses[i] = 1;
//}

//Console.WriteLine($"How many houses to destroy? (between {start} to {houses.Length})");
//numHouses = Convert.ToInt32(Console.ReadLine());

//while (count < numHouses)
//{
//    randTypeWeapons = random.Next(0, 3);
//    numRandom = random.Next(houses.Length);
//    if (numHouses > houses.Length || numHouses < start)
//    {
//        Console.WriteLine("You did not choose a valid number.");
//        break;
//    }
//    else if (houses[numRandom] == 1)
//    {
//        if (firstBool == true)
//        {
//            firstIndex = numRandom;
//            Console.WriteLine($"first Index: {firstIndex}");
//            Console.WriteLine($"rand Type Weapons: {weapons[randTypeWeapons]}");
//            firstBool = false;
//        }
//        houses[numRandom] = 0;
//        count++;
//    }
//}
//for (int i = 0; i < houses.Count(); i++)
//{
//    Console.WriteLine("all the houses: " + houses[i]);
//}

// בדיקת חיילים
//Dictionary<string, string> dict = new Dictionary<string, string>();
//Console.WriteLine("How many soldiers are there?");
//int numSoldiers = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < numSoldiers; i++)
//{
//    Console.WriteLine("What is the soldier's name?");
//    string name = Console.ReadLine();
//    Console.WriteLine("What is the soldier's rank?");
//    string rank = Console.ReadLine();
//    if (name == "stop")
//    {
//        break;
//    }
//    else
//    {
//        dict[name] = rank;
//    }
//}
//// לולאה על כל הפריטים במילון
//foreach (KeyValuePair<string, string> pair in dict)
//{
//    Console.WriteLine("rank: " + pair.Value + ", name: " + pair.Key);
//}



// תרגילים
// שאלה 1
//List<string> name = new List<string> { "aaa", "bbb", "ccc", "ddd", "eee"};
//name.Add("fff");
//name.Add("ggg");
//name.RemoveAt(1);
//for (int i = 0; i < name.Count; i++)
//{
//    Console.WriteLine(i + ". " + name[i]);
//}

// שאלה 2
//Dictionary<string, int> name = new Dictionary<string, int> { { "one", 1 }, { "tow", 2}, { "three", 3} };
//name["one"] = 5;
//foreach (KeyValuePair<string, int> kvp in name)
//{
//    Console.WriteLine(kvp.Key + ": " + kvp.Value);
//}

// שאלה 3
//Dictionary<string, string> person1 = new Dictionary<string, string>();
//person1.Add("name", "david");
//person1.Add("email", "aaa@gmail.com");
//person1.Add("status", "true");
//Dictionary<string, string> person2 = new Dictionary<string, string>();
//person2.Add("name", "avishay");
//person2.Add("email", "bbb@gmail.com");
//person2.Add("status", "False");

//List<Dictionary<string, string>> persons = new List<Dictionary<string,string>> { person1, person2 };
//for (int i = 0; i < persons.Count; i++)
//{
//    foreach (KeyValuePair<string, string> kvp in persons[i])
//    {
//        Console.WriteLine(kvp.Key == "email" ? kvp.Value : "");
//    }
//}

// שאלה 4
//List<string> strings = new List<string> { "aaa", "bbb", "ccc", "ddd", "eee" };
//Console.WriteLine("Enter user name: ");
//string inputName = Console.ReadLine();
//bool exists = false;
//int index = 0;
//for (int i = 0; i < strings.Count; i++)
//{
//    if (strings[i] == inputName)
//    {
//        exists = true;
//        index = i;
//        break;
//    }
//}
//if (exists)
//{
//    Console.WriteLine(index);
//}
//else
//{
//    Console.WriteLine("Username not registered");
//}

// שאלה 5
//string[] tools = { "recorder", "map", "notebook" };
//Dictionary<string, Array> soldiers = new Dictionary<string, Array>();
//soldiers["david"] = new string[] { tools[0], tools[1] };
//soldiers["avi"] = new string[] { tools[1], tools[2] };
//soldiers["shay"] = new string[] { tools[0], tools[2] };
//soldiers["land"] = new string[] { tools[0], tools[1], tools[2] };

//foreach (KeyValuePair<string, Array> pair in soldiers)
//{
//    Console.Write("key: " + pair.Key + ", values: ");
//    foreach (var item in pair.Value)
//    {
//        Console.Write(item + " ");
//    }
//    Console.WriteLine();
//    if (pair.Value.Length == 3)
//    {
//        Console.WriteLine(pair.Key + " is ready for intel work.");
//    } else
//    {
//        Console.WriteLine(pair.Key + " is missing tools.");
//    }
//}
