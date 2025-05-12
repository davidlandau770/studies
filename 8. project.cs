using System;

class Project
{
    /*
     * בדיקה שיש לי רשימה של 3 מספרים חיוביים לפחות
     * פונקציה - החלפת הסדרה הנוכחית בסדה חדשה
     * פונקציה - הדפסת הסדרה לפי הסדר
     * פוקנציה - הדפסת הסדרה בסדר הפוך
     * פונקציה - הדפסה ממויינת מהנמוך לגבוה
     * פונקציה - הדפסת הערך הגבוה
     * פונקציה - הדפסת הערך הנמוך
     * פונקציה - הדפסת הממוצע של הסדרה
     * פונקציה - הדפסת מספר הערכים שבסדרה
     * פונקציה - הדפסת סכום הסדרה
     * פונקציה - יציאה
     */
    static List<int> ints = new List<int>();
    static List<int> temporaryInt = new List<int>();
    static bool stop = true;

    // פונקציה שרצה עוד לפני שהמשתמש מתחיל.
    // מקבלת את הרשימה הראשונית מתוך הדיבאג ועובדת עליו
    static void checkArr(string[] args)
    {
        int count = 0;
        Console.WriteLine("The numbers you entered are: ");
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine(args[i]);
            bool typeInt = checkNum(args[i]);
            if (typeInt)
            {
                addNum(args[i]);
            }
            else
            {
                Console.WriteLine("Only numbers can be entered! The system will check if you have entered at least 3 numbers.");
            }
        }
        bool checkLength = checkLengthList();
        if (checkLength)
        {
            ReplaceList();
        }
        else
        {
            Console.WriteLine("You entered less than 3 positive numbers. Please enter again.");
        }
        Console.WriteLine("");
    }

    // 1. פונקציה שמאפשרת למשתמש להחליף את סדרת המספרים
    static void changeList()
    {
        bool quit = true;
        bool checkLength = false;
        Console.WriteLine("\nTo confirm the list, press Q.");
        while (quit)
        {
            Console.WriteLine("\nEnter num: ");
            string enterNum = Console.ReadLine();
            if (enterNum == "q" || enterNum == "Q")
            {
                checkLength = checkLengthList();
                if (checkLength)
                {
                    ReplaceList();
                    print();
                } else
                {
                    Console.WriteLine("You entered less than 3 positive numbers. Please enter again.\n");
                    break;
                }
                quit = false;
                break;
            }
            else
            {
                bool resultCheckNum = checkNum(enterNum);
                if (resultCheckNum)
                {
                    addNum(enterNum);
                }
                else
                {
                    Console.WriteLine("Please enter a valid value (number)");
                }
            }
        }
    }

    // פונקציות עזר:
    // בדיקת ערך אם הוא מספר
    static bool checkNum(string enterNum)
    {
        bool checkNum = int.TryParse(enterNum, out int num);
        return checkNum;
    }

    // הוספת המספר לרשימה זמנית
    static void addNum(string enterNum)
    {
        int convertNum = Convert.ToInt32(enterNum);
        temporaryInt.Add(convertNum);
    }

    // בדיקה אם בפונקציה הזמנית יש מעל 3 ערכים
    static bool checkLengthList()
    {
        return temporaryInt.Count >= 3 ? true : false;
    }

    // החלפת הפונקציה המקורית בפונקציה הזמנית
    static void ReplaceList()
    {
        ints = new List<int>(temporaryInt);
        temporaryInt.Clear();
    }

    // 2. הדפסת הסדרה
    static void print()
    {
        Console.WriteLine("\n***");
        foreach (var i in ints)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("***\n");
    }

    // 3. הדפסת הסדרה בסדר הפוך
    static void printReverce()
    {
        Console.WriteLine("\n***");
        for (int i = ints.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(ints[i]);
        }
        Console.WriteLine("***\n");
    }

    // 4. מיון הסדרה
    static void sort()
    {
        ints.Sort();
        print();
    }

    // 5. הדפסת המספר הגבוה
    static void highest()
    {
        int highest = ints[0];
        for (int i = 0; i < ints.Count; i++)
        {
            if (ints[i] > highest)
            {
                highest = ints[i];
            }
        }
        Console.WriteLine(highest);
    }
    
    // 6. הדפסת המספר הנמוך
    static void lowest()
    {
        int lowest = ints[0];
        for (int i = 0; i < ints.Count; i++)
        {
            if (ints[i] < lowest)
            {
                lowest = ints[i];
            }
        }
        Console.WriteLine(lowest);
    }
    // 7. הדפסת הממוצע של הסדרה
    static void average()
    {
        Console.WriteLine((double)sumOfSeries() / ints.Count);
    }

    // פונקציית עזר:
    // חישוב סכום הסדרה
    static int sumOfSeries()
    {
        int sum = 0;
        for (int i = 0; i < ints.Count; i++)
        {
            sum += ints[i];
        }
        return sum;
    }

    // 8. כמות האיברים שבסדרה
    static void count()
    {
        Console.WriteLine(ints.Count);
    }

    // 9. סכום האיברים בסדרה
    static void sum()
    {
        Console.WriteLine(sumOfSeries());
    }

    // 10. יציאה מהתכנית
    static void exit()
    {
        stop = false;
    }

    // פונקציית תפריט
    static void menu(string[] args)
    {
        checkArr(args);
        while (stop)
        {

            Console.WriteLine("Select using a number from the menu what you want:\n1. Replace the series.\n2. Print the series.\n3. Print the series in reverse order.\n4. Print sorted from low to high.\n5. Print the highest value.\n6. Print the lowest value.\n7. Print the average of the series.\n8. Print the number of values in the series.\n9. Print the sum of the series.\n10. Exit");
            int chooseNum = Convert.ToInt32(Console.ReadLine());
            switch (chooseNum)
            {
                case 1:
                    changeList();
                    break;
                case 2:
                    print();
                    break;
                case 3:
                    printReverce();
                    break;
                case 4:
                    sort();
                    break;
                case 5:
                    highest();
                    break;
                case 6:
                    lowest();
                    break;
                case 7:
                    average();
                    break;
                case 8:
                    count();
                    break;
                case 9:
                    sum();
                    break;
                case 10:
                    exit();
                    break;
            }
        }
    }
    static void Main(string[] args)
    {
        menu(args);
    }
}