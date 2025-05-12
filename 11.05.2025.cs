//int[] num = new int[1000];
//int[] hige = new int[5];
//for (int i = 0; i < num.Length; i++)
//{
//    num[i] = i + 1;
//    Console.WriteLine(num[i]);
//}
//for (int i = 0;i < hige.Length; i++)
//{
//    hige[i] = num.Max();
//    Console.WriteLine(hige[i]);
//}

//List<int> name = new List<int>();
//List<int> name2 = new List<int> {1,2,3};
//name.Add(1);
//name.Insert(1,2);
//name.Remove(1);
//name.Count();
////name.Clear();
//name.Contains(1);
//name.Add(23);
//Console.WriteLine();
//Console.WriteLine(name);
//Console.WriteLine(name2);
//for (int i = 0; i < name.Count; i++)
//{
//    Console.WriteLine(name[i]);
//}

//Dictionary<string, string> name = new Dictionary<string, string>();








//Random random = new Random();

//string[] weapons = { "Rocket", "Drone", "Tank" };
//int start = 1;
//int end = 50;
//int[] houses = new int [random.Next(start,end)];
//int numHouses;
//int count = 0;
//int numRandom;
//int firstIndex;
//bool firstBool = true;
//int randTypeWeapons;

//for (int i = 0; i < houses.Count(); i++)
//{
//    houses[i] = 1;
//    //Console.WriteLine(houses[i]);
//}

//Console.WriteLine($"How many houses to destroy? (between {start} to {houses.Length})");
//numHouses = Convert.ToInt32(Console.ReadLine());

//while (count < numHouses)
//{
//    randTypeWeapons = random.Next(0,3);
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
