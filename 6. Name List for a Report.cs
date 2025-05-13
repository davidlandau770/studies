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



