// שאלות מהמצגת של לולאות

// שאלה 1
//for (int i = 1; i < 11; i++)
//{
//    Console.WriteLine(i);
//}

// שאלה 2
//int sum = 0; 
//for (int i = 0; i < 101; i += 2)
//{   
//    sum += i;
//}
//Console.WriteLine(sum);

// שאלה 3
//string[] arr = { "aaaa", "bbbb", "cccc", "abcd"};
//foreach (string s in arr)
//{
//    if (s.StartsWith("a")) {
//        Console.WriteLine(s);
//    }
//}



// שאלות מהדף שאלות
// שאלה 1
//for (int i = 1; i < 6; i++)
//{
//    Console.WriteLine(i);
//}

// שאלה 2
//int i = 2;
//while (i < 11)
//{
//    Console.WriteLine(i);
//    i += 2;
//}

// שאלה 3
//int num;
//Console.WriteLine("Enter num");
//num = Convert.ToInt32(Console.ReadLine());
//if (num > 0) Console.WriteLine("The num is positive");

// שאלה 4
//bool stop = true;
//string sium;
//while (stop)
//{
//    sium = Console.ReadLine();
//    if (sium == "sium")
//    {
//        stop = false;
//    }
//}

// שאלה 5
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Authorized access");
//}

// שאלה 6
//for (int i = 1; i < 21; i++)
//{
//    if (i % 3 != 0) Console.WriteLine(i);
//}

// שאלה 7
//int i = 5;
//while (i > 0) {
//    Console.WriteLine(i);
//    i--;
//}

// שאלה 8
//for (int i = 1; i < 11; i++)
//{
//    if (i % 2 == 0) Console.WriteLine(i + " even");
//    if (i % 2 == 1) Console.WriteLine(i + " odd");
//}

// שאלה 9
//int num;
//Console.WriteLine("Enter num");
//num = Convert.ToInt32(Console.ReadLine());
//if (num == 8200) Console.WriteLine("insurance");

// שאלה 10
//string userName;
//Console.WriteLine("Enter name");
//while (true)
//{
//    userName = Console.ReadLine();
//    if (userName == "admin")
//    {
//        break;
//    }
//}

// שאלה 11
//int count = 0;
//for (int i = 0; i < 101; i++)
//{
//    if (i % 7 !=0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

// שאלה 12
//string password;
//Console.WriteLine("Enter password: ");
//password = Console.ReadLine();
//if (password.Length == 8)
//{
//    Console.WriteLine("Yes");
//} else
//{
//    Console.WriteLine("No");
//}

// שאלה 13
//string str;
//Console.WriteLine("Enter string: ");
//str = Console.ReadLine();
//for (int i = 0; i < str.Length; i++)
//{
//    char c = str[i];
//    if (Char.IsLetter(c)) Console.WriteLine(str[i]);
//}

// שאלה 14
//bool stop = true;
//string password;
//while (stop)
//{
//    password = Console.ReadLine();
//    if (password.Length >= 8) stop = false;
//}

// שאלה 15
//for (int i = 1; i < 11; i++)
//{
//    if ((i > 0 && i < 3) || i == 5 || i == 7 || i ==8) Console.WriteLine(i + " is a prime number.");
//}

// שאלה 16
//string myPassword = "1234";
//int i = 0;
//string password;
//Console.WriteLine("Enter password: ");
//while (i < 3)
//{
//    password = Console.ReadLine();
//    if (myPassword == password) break;
//    i++;
//}

// שאלה 17
//string str;
//Console.WriteLine("Enter string: ");
//str = Console.ReadLine();
//int count = 0;
//for (int i = 0; i < str.Length; i++)
//{
//    char c = str[i];
//    if (Char.IsDigit(c)) count += 1;
//}
//Console.WriteLine(count);

// שאלה 18
//for (int i = 1; i < 51; i++)
//{
//    if (i % 10 == 0) Console.WriteLine(i);
//}

// שאלה 19
//bool stop = true;
//int num;
//int sum = 0;

//while (stop)
//{
//    num = Convert.ToInt32(Console.ReadLine());
//    if (num >= 0)
//    {
//        sum += num;
//    } else
//    {
//        stop = false;
//    }
//}
//Console.WriteLine(sum);

// שאלה 20
//string password;
//string astrics = "";
//Console.WriteLine("Enter password: ");
//password = Console.ReadLine();
//for (int i = 0; i < password.Length; i++)
//{
//    astrics += "*";
//}
//Console.WriteLine(astrics);

// שאלה 21
bool result;
bool stop = true;

do
{
    Console.WriteLine("Dear Officer, please select one of the options.\n1. Second Lieutenant\n2. Lieutenant\n3. Captain\n4. Major\n5. Lieutenant Colonel\n6. Exit");
    result = int.TryParse(Console.ReadLine(), out int num);
    if (result)
    {
        Convert.ToInt32(num);
        switch (num)
        {
            case 1:
                Console.WriteLine("\n***\n\nCongratulations to the \"Second Lieutenant\", in 8 ranks you will be Chief of Staff\n\n***\n");
                return;
            case 2:
                Console.WriteLine("\n***\n\nCongratulations to the \"Second Lieutenant\", in 7 ranks you will be Chief of Staff\n\n***\n");
                return;
            case 3:
                Console.WriteLine("\n***\n\nCongratulations to the \"Second Lieutenant\", in 6 ranks you will be Chief of Staff\n\n***\n");
                return;
            case 4:
                Console.WriteLine("\n***\n\nCongratulations to the \"Second Lieutenant\", in 5 ranks you will be Chief of Staff\n\n***\n");
                return;
            case 5:
                Console.WriteLine("\n***\n\nCongratulations to the \"Second Lieutenant\", in 4 ranks you will be Chief of Staff\n\n***\n");
                return;
            case 6:
                Console.WriteLine("\n***\n\nThank you and goodbye, bye\n\n***\n");
                stop = false;
                return;
            default:
                Console.WriteLine("\n***\n\nEnter a valid number (between 1 and 6)\n\n***\n");
                return;
        }
    }
    else
    {
        Console.WriteLine("\n***\n\nEnter a valid number (between 1 and 6)\n\n***\n");
    }
}
while (stop);

// שאלה 22
//bool stop = true;
//string myUserName = "abc";
//string myPassword = "123";
//string userName, password;
//while (stop)
//{
//    Console.WriteLine("Enter user name");
//    userName = Console.ReadLine();
//    Console.WriteLine("Enter password");
//    password = Console.ReadLine();
//    if (userName == myUserName && password == myPassword)
//    {
//        Console.WriteLine("Connection successful!");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Try again");
//    }
//}

// שאלה 23
//int password = new Random().Next(100000,1000000);
//Console.WriteLine(password);

// שאלה 24
//string password;
//bool letter = false;
//bool numbers = false;
//Console.WriteLine("Enter password: ");
//password = Console.ReadLine();
//for (int i = 0; i < password.Length; i++)
//{
//    char c = password[i];
//    if (char.IsLetter(c)) letter = true;
//    if (char.IsDigit(c)) numbers = true;
//}
//if (letter && numbers) Console.WriteLine("The password contains both letters and numbers.");

// שאלה 25
//string str;
//Console.WriteLine("Enter str: ");
//str = Console.ReadLine();
//for (int i = 0; i < str.Length; i++)
//{
//    char c = str[i];
//    if (char.IsDigit(c))
//    {
//        Console.Write("number");
//    }
//    else
//    {
//        Console.Write(c);
//    }
//}

// שאלה 26
//string password;
//Console.WriteLine("Enter password: ");
//password = Console.ReadLine();
//for (int i = 0; i < password.Length; i++)
//{
//    if (password[i] == '8' || password[i] == '2' || password[i] == '0')
//    {
//        Console.Write("This string contains one of the characters '8200'.");
//    }
//    else
//    {
//        Console.Write("This string does not contain any of the characters '8200'.");
//    }
//}

// שאלה 27
//int count = 0;
//Console.WriteLine("Enter string");
//string str = Console.ReadLine().ToUpper();
//for (int i = 0; i < str.Length; i++)
//{
//    char c = str[i];
//    if (c == 'A')
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

// שאלה 28
//bool stop = true;
//while (stop) {
//    Console.WriteLine("Enter password");
//    string input = Console.ReadLine();
//    if (input.Length == 4 && input[0] == '8')
//    {
//        Console.WriteLine("You have successfully connected!");    
//        stop = false;
//    }
//}

// שאלה 29
//Console.WriteLine("Enter user name");
//string userName = Console.ReadLine();
//Console.WriteLine("Enter password");
//string password = Console.ReadLine();
//for (int i = 0; i < password.Length; i++)
//{
//    char c = password[i];
//    if (!char.IsLetterOrDigit(c))
//    {
//        Console.WriteLine("The password contains a special character.");
//        break;
//    }
//}

// שאלה 30
//string passwordEncryption = "";
//for (int i = 1; i < 6; i++)
//{
//    Console.WriteLine($"Enter password {i}");
//    string password = Console.ReadLine();
//    for (int j = 0; j < password.Length; j++)
//    {
//        passwordEncryption += "*";
//    }
//    passwordEncryption += "\n";
//}
//Console.WriteLine(passwordEncryption);

// שאלה 31
//string password;
//bool num = false;
//bool str = false;
//bool special = false;
//bool len = false;
//Console.WriteLine($"Enter password: ");
//password = Console.ReadLine();
//for (int i = 1; i < password.Length; i++)
//{
//    char c = password[i];
//    if (char.IsLetter(c)) str = true;
//    if (char.IsDigit(c)) num = true;
//    if (!char.IsLetterOrDigit(c)) special = true;
//}
//if (password == null || password.Length <= 8)
//{
//    Console.WriteLine("The password is too short.");
//}
//else if (str && num && special)
//{
//    Console.WriteLine($"The password: {password} is extremely strong.");
//} else
//{
//    Console.WriteLine($"The password: {password} is not strong enough. Use letters, numbers, and special characters.");
//}

