//string fullName;
//Console.WriteLine("Enret your name:");
//fullName = Console.ReadLine();
//Console.WriteLine("Hello " + fullName);

//int num1, num2;
//Console.WriteLine("\n\nEnret number 1:");
//num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enret number 2:");
//num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("The multiplication is: " + (num1 * num2));


//Console.WriteLine("Enret num 1: ");
//int x = int.Parse(Console.ReadLine()); // אם X שווה NULL יחזיר שגיאה
//Console.WriteLine("Enret num 2: ");
//int y = Convert.ToInt32(Console.ReadLine()); // אם Y שווה NULL יחזיר 0
//Console.WriteLine("The division is: " + (double)x / (double)y + ". The modulu is: " + (double)x % (double)y); // אם Y שווה NULL יחזיר 


//bool a = int.TryParse(Console.ReadLine(), out int d);
//Console.WriteLine(a);
//int c = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(c);
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine(b);




// שאלה 1
// כדי שהמהדר ידע באיזה טיפוס נתונים מדובר ויצרוך פחות זיכרון ומהירות יותר גבוהה. אם לא תצהיר תקבל שגיאה.

// שאלה 2
// מספר שלם ומחרוזת. לכל אחד מהם מוקצה גודל אחר בזיכרון.

// שאלה 3
// שגיאה.

// שאלה 4
// כך ניתן לתקן טעויות בזמן ולא אחרי שהמשתמש מקבל את התוכנית.

// שאלה 5
// INT = מספר שלם, FLOAT = מספר עשרוני בזיכרון של 32 ביטים, DOUBLE = מספר עשרוני בזיכרון של 64 ביטים, וdecimal = מספר עשרוני בזיכרון של 128 ביטים.

// שאלה 6
// שהוא יודע לתת שטח תואם מדוייק בזיכרון בבירור שלא ישנו לו את המשתנה לאחר מכן.

// שאלה 7
// באם נותנים ערך מספרי למשתנה בפייתון, ואחר כך מוסיפים לו מספר, בפייתון זה יציג שגיאה וב-C# השגיאה תגיע מראש בזמן הכתיבה.

// שאלה 8
//int num1, num2;
//Console.WriteLine("Enter number 1:");
//num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter number 2:");
//num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("The multiplication is: " + (num1 * num2));

// שאלה 9
//תצטרך להוסיף:
//ageNum = Convert.ToInt32(age);

// שאלה 10
// באם אני רוצה לשנות טיפוס נתונים אז הוא נותן לי את האפשרות מבלי שתהיה שגיאה. מצד שני בריבוי שינויי טיפוסים הקוד נעשה מאוד לא ברור.

// שאלה 11
//כי פעולות מתמטיות ניתן לעשות על מספרים בלבד וסטרינג (גם אם הוא מכיל מספרים בלבד) הוא לא נחשב כספרה אלא כ'תו כלשהו'.

// שאלה 12
//אם נרצה לחלק מספרים שהמשתמש מביא נרצה לדייק אותם ולהשתמש בFLOAT. ואם נתבלבל ביניהם אנחנו עלולים לקבל תוצאה שונה מהמצופה.

// שאלה 13
//שלא ניתן להתבלבל ביניהם כי אי אפשר לשנות אותם ולכן זה קצת יותר מסודר.

// שאלה 14
//דבר ראשון שהשפה בנויה על OOP, דבר שני שהיא mid level וא"כ קצת יותר מאובטחת ומהירה. דבר שלישי הוא שטיפוסי המשתנים הקבועים והמרובעים עוזרים להמעיט בבאגים מסוג מאוד קריטי במערכת בנקאית.

// שאלה 15
//כן, אם אני מעביר לחשבון בנק באמצעות האפליקציה סכום של "GEHRBDJ" שקלים והבנק לא ערוך לסינון סכומים כאלה המערכת עלולה לקרוס.

// שאלה 26
//int x = 5;

// שאלה 27
//string a;
//Console.WriteLine("Enter your name: ");
//a = Console.ReadLine();
//Console.WriteLine("Hello " + a);

// שאלה 28
//int a, b;
//Console.WriteLine("Enter num 1: ");
//a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter num 2: ");
//b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(a + b);

// שאלה 29
//double a, b;
//Console.WriteLine("Enter num 1: ");
//a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter num 2: ");
//b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine((a + b) / 2);

// שאלה 30
//string greeting;
//Console.WriteLine("Insert a birthday greeting: ");
//greeting = Console.ReadLine();
//Console.WriteLine(greeting.Length);

// שאלה 31
//string name;
//int age;
//Console.Write("Enter your name: ");
//name = Console.ReadLine();
//Console.Write("Enter your age: ");
//age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Hello " + name + ", in 5 years you will be " + (age + 5));

// שאלה 32
//string str;
//int num;
//Console.Write("Enter str: ");
//str = Console.ReadLine();
//Console.Write("Enter num: ");
//num = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < num; i++)
//{
//    Console.WriteLine(str);
//}

// שאלה 33
//double num1, num2, num3;
//Console.WriteLine("Enter num 1: ");
//num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter num 2: ");
//num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter num 3: ");
//num3 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine((num1 + num2 + num3) / 3);

// שאלה 34
//string str;
//Console.WriteLine("Enter text lower: ");
//str = Console.ReadLine();
//Console.WriteLine(str.ToUpper());

// שאלה 35
//int age;
//Console.WriteLine("Enter your age: ");
//age = Convert.ToInt32(Console.ReadLine());
//if (age < 18)
//{
//    Console.WriteLine("False");
//}
//else { Console.WriteLine("True"); }

// שאלה 36
//string numstr = "12";
//int num = Convert.ToInt32(numstr);
//Console.WriteLine(num);
//Console.WriteLine(num + 5);

// שאלה 37
//string str1;
//string str2;
//Console.WriteLine("Enter str 1");
//str1 = Console.ReadLine();
//Console.WriteLine("Enter str 2");
//str2 = Console.ReadLine();
//if (str1 == str2)
//{
//    Console.WriteLine("The str's is equal");
//} else
//{
//    Console.WriteLine("The str's is not equal");
//}

// שאלה 38
//int num;
//Console.WriteLine("Enter num: ");
//num = Convert.ToInt32(Console.ReadLine());
//if (num % 2 == 0)
//{
//    Console.WriteLine("The num is even");
//} else
//{
//    Console.WriteLine("The num is odd");
//}

// שאלה 39
//string name;
//Console.WriteLine("Enter yuor name:");
//name = Console.ReadLine().ToUpper();
//char firstchar = 'A';
//if (name[0] == firstchar)
//{
//    Console.WriteLine("The first letter is equal");
//}
//else
//{
//    Console.WriteLine("The first letter is not equal");
//}

// שאלה 40
//int num;
//Console.WriteLine("Enter num: ");
//num = Convert.ToInt32(Console.ReadLine());
//num = num * num;
//Console.WriteLine(num);

// שאלה 41
//double cm, inch;
//Console.WriteLine("Enter the height: ");
//cm = Convert.ToInt32(Console.ReadLine());
//inch = cm * 2.54;
//Console.WriteLine(inch);

// שאלה 42
//bool check;
//Console.WriteLine("Enter sumthing: ");
//check = int.TryParse(Console.ReadLine(), out int a);
//Console.WriteLine(check);

// שאלה 43
//int num1, num2;
//string shape;
//Console.WriteLine("Enter num 1: ");
//num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter num 2: ");
//num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Insert shape");
//shape = Console.ReadLine();
//Console.WriteLine("Insert shape");
//if (shape == "rectangle")
//{
//    Console.WriteLine(num1 * num2);
//} else if (shape == "triangular") {
//    Console.WriteLine(num1 * num2 / 2);
//}

// שאלה 44
//string fullname, lastname;
//int index;
//Console.WriteLine("Enter fullname: ");
//fullname = Console.ReadLine();
//index = fullname.IndexOf(' ');
//lastname = fullname.Substring(index + 1);
//Console.WriteLine(lastname);

// שאלה 45
//double num;
//Console.WriteLine("Enter number: ");
//num = Convert.ToInt32(Console.ReadLine());
//double result = Math.Sqrt(num);
//if (result == (int)result)
//{
//    Console.WriteLine("True");
//}
//else { Console.WriteLine("False"); }




// פונקציות בנויות
// שאלה 1
//string str;
//Console.WriteLine("Enter string: ");
//str = Console.ReadLine();
//Console.WriteLine(str.Length);




// תנאים
// שאלה 1
//int age;
//string color;
//int hight;
//string job;
//for (int i = 1; i < 4; i++)
//{
//    Console.WriteLine($"\tperson {i}\n");
//    Console.WriteLine("Here are some questions for you.\n");
//    Console.WriteLine("What is your age?");
//    age = Convert.ToInt32(Console.ReadLine());
//    if (age < 25 || age > 50) { continue; }

//    Console.WriteLine("What color is your hair?");
//    color = Console.ReadLine();
//    if (color != "black" && color != "brown") { continue; }

//    Console.WriteLine("What is your height?");
//    hight = Convert.ToInt32(Console.ReadLine());
//    if (hight < 170 || hight > 185) { continue; }

//    Console.WriteLine("What is your profession?");
//    job = Console.ReadLine();

//    if ((age >= 25 && age <= 50) && (color == "black" || color == "brown") && (hight >= 170 && hight <= 185) && (job == "doctor" || job == "hospital manager"))
//    {
//        Console.WriteLine($"Person number {i} is suspected of being an Iranian spy.");
//        break;
//    }
//}

// שאלה 2
//string path = "C:\\Users\\avishay\\IDF\\Step 2\\CMD\\creds.txt";
//string text = File.ReadAllText(path);
//Console.WriteLine(text);





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
//num = Convert.ToInt32(Console.ReadLine());
//if (num % 1 != 1)
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
//for (int i = 1; i < 11; i++)
//{

//}