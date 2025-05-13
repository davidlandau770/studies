//using System;
//using System.Media;

//class functions
//{
//    // שאלות מהמצגת
//    // שאלה 1    
//    //    static int getAge()
//    //    {
//    //        Console.WriteLine("Enter birth date: ");
//    //        int birthDate = Convert.ToInt32(Console.ReadLine());
//    //        return 2025 - birthDate;
//    //    }

//    //    static string getName()
//    //    {
//    //        Console.WriteLine("Enter your name");
//    //        string name = Console.ReadLine();
//    //        return ($"Hi {name}, welcome");
//    //    }

//    //    static int getRandom()
//    //    {
//    //        Random random = new Random();
//    //        return random.Next(1, 100);
//    //    }

//    //    static void getMenu()
//    //    {
//    //        Console.WriteLine("Enter num :\n1. Calculator age (ask for birth year)\n2. Ask for name (greet)\n3. Give a random number");
//    //        int num = Convert.ToInt32(Console.ReadLine());
//    //        if (num > 0 || num < 4)
//    //        {
//    //            if (num == 1)
//    //            {
//    //                Console.WriteLine(getAge());
//    //            }
//    //            else if (num == 2)
//    //            {
//    //                Console.WriteLine(getName());
//    //            } else if (num == 3)
//    //            {
//    //                Console.WriteLine(getRandom());
//    //            }
//    //        }
//    //        else
//    //        {
//    //            Console.WriteLine("You did not enter a valid number.");
//    //        }
//    //    }


//    // שאלה 2
//    static List<string> names = new List<string>();
//    static bool stop = true;
//    static bool isEmpty(string checkName)
//    {
//        if (names.Contains(checkName))
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }

//    static void entry()
//    {
//        Console.WriteLine("Write the ID number of the person who wants to enter.");
//        string nameEntry = Console.ReadLine();
//        bool result = isEmpty(nameEntry);
//        if (result)
//        {
//            //try
//            //{
//            //    SoundPlayer player = new SoundPlayer("error voice.wav");
//            //    player.Play(); // ניגון פעם אחת

//            //    Console.WriteLine("אזעקה הופעלה פעם אחת. לחץ על מקש כלשהו כדי לצאת...");
//            //    Console.ReadKey(); // מחכה ללחיצה לפני סיום התוכנית
//            //}
//            //catch (Exception ex)
//            //{
//            //    Console.WriteLine("שגיאה בהפעלת הקובץ: " + ex.Message);
//            //}
//            try
//            {
//                SoundPlayer player = new SoundPlayer("alarm.wav");
//                player.Play(); // או player.PlaySync(); לניגון עם המתנה

//                Console.WriteLine("אזעקה הופעלה (פעם אחת). לחץ מקש כדי לצאת...");
//                Console.ReadKey();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("שגיאה בהפעלת האזעקה: " + ex.Message);
//            }

//            Console.WriteLine("The name already exists in the list.");
//        }
//        else
//        {
//            Console.WriteLine("welcome!");
//            names.Add(nameEntry);
//        }
//    }
//    static void exit()
//    {
//        Console.WriteLine("Enter the ID number of the person who wants to leave.");
//        string nameExit = Console.ReadLine();
//        bool result = isEmpty(nameExit);
//        if (result)
//        {
//            Console.WriteLine("bye!");
//            names.Remove(nameExit);
//        }
//        else
//        {
//            Console.WriteLine("The name does not exist in the list.");
//        }
//    }

//    static void close()
//    {
//        stop = false;
//    }

//    static void print()
//    {
//        Console.WriteLine("\n*******\nThe all names in list:");
//        for (int i = 0; i < names.Count; i++)
//        {
//            Console.WriteLine(names[i]);
//        }
//        Console.WriteLine("*******\n");
//    }


//    static void definition()
//    {
//        while (stop)
//        {
//            Console.WriteLine("Choose num\n1. entry\n2. exit.\n3. close the system");
//            int choose = Convert.ToInt32(Console.ReadLine());
//            switch (choose)
//            {
//                case 1:
//                    entry();
//                    print();
//                    continue;
//                case 2:
//                    exit();
//                    print();
//                    continue;
//                case 3:
//                    close();
//                    continue;
//                default:
//                    Console.WriteLine("Enter a valid value.");
//                    continue;
//            }
//        }

//    }
//    static void Main()
//    {
//        //getMenu();
//        definition();
//    }
//}
