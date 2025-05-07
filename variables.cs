// תרגול תנאים
// שאלה 1
//int num;
//Console.WriteLine("Enter num");
//num = Convert.ToInt32(Console.ReadLine());
//if (num > 0)
//{
//    Console.WriteLine("positiv");
//}
//else
//{
//    Console.WriteLine("negative");
//}

// שאלה 2
//Console.WriteLine("Enter num 1");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter num 2");
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(num1 > num2 ? num1 : num2);

// שאלה 3
//int num;
//Console.WriteLine("Write grade: ");
//num = Convert.ToInt32(Console.ReadLine());
//if (num >= 90)
//{
//    Console.WriteLine("Excellent");
//} else if (num >= 70)
//{
//    Console.WriteLine("Very good");
//} else
//{
//    Console.WriteLine("Needs to improve");
//}

// שאלה 4
//int day;
//Console.WriteLine("Write num day: ");
//day = Convert.ToInt32(Console.ReadLine());
//switch (day){
//    case 1:
//        Console.WriteLine("Sanday");
//        break;
//    case 2: Console.WriteLine("Munday");
//        break;
//    case 3: Console.WriteLine("Tuesday");
//        break;
//    case 4:
//        Console.WriteLine("Wednesday");
//        break;
//    case 5:
//        Console.WriteLine("Thursday");
//        break;
//    case 6:
//        Console.WriteLine("Friday");
//        break;
//    case 7:
//        Console.WriteLine("Saturday");
//        break;
//    default:
//        Console.WriteLine("The num is not true");
//        break;
//}

// שאלה 5
//int temperatura;
//Console.WriteLine("Enter tempetatura: ");
//temperatura = Convert.ToInt32(Console.ReadLine());
//if (temperatura >= 30)
//{
//    Console.WriteLine("hot");
//} else if (temperatura >= 20)
//{
//    Console.WriteLine("pleasant");
//} else
//{
//    Console.WriteLine("cold");
//}

// שאלה 6
//int age;
//Console.WriteLine("Enter age: ");
//age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(age >= 17 ? "Can issue a license" : "Not yet");

// שאלה 7
//int num;
//Console.WriteLine("Enter num: ");
//num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(num % 2 == 0 ? "even" : "odd");

// שאלה 8
//Console.WriteLine("Enter char: ");
//string chr = Console.ReadLine();
//char letter = chr[0];
//Console.WriteLine(char.IsUpper(letter) ? "Uppercase" : char.IsLower(letter) ? "Lowercase" : "Not a letter");

// שאלה 9
//int sum;
//Console.WriteLine("Enter sum shop: ");
//sum = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(sum <= 100 ? $"No discount, the price is {sum}" : (sum > 100 && sum < 500) ? $"5% discount, the price is {sum * 0.95}" : sum >= 500 ? $"10% discount, the price is {sum * 0.90}" : "You did not enter a valid character.");

// שאלה 10
//int num;
//Console.WriteLine("1. conect\n2. register\n3. exit");
//num = Convert.ToInt32(Console.ReadLine());
//switch (num) {
//    case 1:
//        Console.WriteLine("You have successfully logged in.");
//        break;
//    case 2:
//        Console.WriteLine("You have successfully registered.");
//        break;
//    case 3:
//        Console.WriteLine("You have successfully logged out.");
//        break;
//}

// שאלה 11
//int birth, age;
//Console.WriteLine("Enter your birth year: ");
//birth = Convert.ToInt32(Console.ReadLine());
//age = 2025 - birth;
//Console.WriteLine(age < 13 ? "Child" : age < 17 ? "Teenager" : "Adult");

// שאלה 12
//int num1, num2, num3;
//Console.WriteLine("Enter 3 numbers: ");
//num1 = Convert.ToInt32(Console.ReadLine());
//num2 = Convert.ToInt32(Console.ReadLine());
//num3 = Convert.ToInt32(Console.ReadLine());
//if (num1 > num2)
//{
//    if (num1 > num3)
//    {
//        Console.WriteLine(num1 + " is big");
//    }
//    else
//    {
//        Console.WriteLine(num3 + " is big");
//    }
//}
//else if (num2 > num1)
//{
//    if (num2 > num3)
//    {
//        Console.WriteLine(num2 + " is big");
//    }
//    else
//    {
//        Console.WriteLine(num3 + " is big");
//    }
//}

// שאלה 13
//double num;
//Console.WriteLine("Enter number: ");
//num = Convert.ToInt32(Console.ReadLine());
//if (((num / 3) == (int)(num / 3)) && ((num / 5) == (int)(num / 5)))
//{
//    Console.WriteLine("FizzBuzz");
//} else if ((num / 3) == (int)(num / 3))
//{
//    Console.WriteLine("Fizz");
//} else if ((num / 5) == (int)(num / 5))
//{
//    Console.WriteLine("Buzz");
//} 

// שאלה 14
//double hour;
//Console.WriteLine("Enter hour: ");
//hour = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine((hour >= 5 && hour <= 11) ? "Good morning" : (hour >= 12 && hour <= 15) ? "Good afternoon" : (hour >= 18 && hour <= 21) ? "Good evening" : (hour >= 22 && hour < 24) || (hour >= 0 && hour <= 4) ? "Good night" : "The time you entered is out of range.");

// שאלה 15
//int num;
//Console.WriteLine("Enter num: ");
//num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine((num >= 50 && num <= 100) ? "Yes" : "No");

// שאלה 16
//string color;
//Console.WriteLine("Enter color: ");
//color = Console.ReadLine();
//switch (color)
//{
//    case "red":
//        Console.WriteLine(color + " = red");
//        break;
//    case "blue":
//        Console.WriteLine(color + " = blue");
//        break;
//    case "green":
//        Console.WriteLine(color + " = green");
//        break;
//}

// שאלה 17
//string username, password, getUserName, getPassword;
//username = "david";
//password = "770";
//Console.WriteLine("Enter uesr name: ");
//getUserName = Console.ReadLine();
//Console.WriteLine("Enter password: ");
//getPassword = Console.ReadLine();
//Console.WriteLine((username == getUserName) && (password == getPassword) ? "welcome" : "Incorrect login details.");

// שאלה 18
//double num;
//Console.WriteLine("Enter num: ");
//num = Convert.ToDouble(Console.ReadLine());
//if (num % 1 == 0)
//{
//    if (num >= 0)
//    {
//        Console.WriteLine("num is positive");
//    }
//    else
//    {
//        Console.WriteLine("num is negative");
//    }
//}
//else
//{
//    Console.WriteLine("num is deciml");
//}

// שאלה 19
//string str;
//Console.WriteLine("Enter string:");
//str = Console.ReadLine().ToUpper();
//char firstchar = 'A';
//if (str[0] == firstchar)
//{
//    Console.WriteLine("The first letter is A");
//}
//else
//{
//    Console.WriteLine("The first letter is not A");
//}

// שאלה 20
//int num;
//Console.WriteLine("Enter num: ");
//num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(num >= 0 && num <= 300 ? "Beginner Level" : (num < 700) ? "Intermediate Level" : (num <= 700) ? "Advanced Level" : "Out of range");


