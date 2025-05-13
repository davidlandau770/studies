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
    static bool stop = true, continuation = true;
    static int countIntPositive = 0;
    // פונקציה שרצה עוד לפני שהמשתמש מתחיל.
    // מקבלת את הרשימה הראשונית מתוך הדיבאג ועובדת עליו
    static void checkArr(string[] args)
    {
        //Console.WriteLine("The numbers you entered are: ");
        for (int i = 0; i < args.Length; i++)
        {
            //Console.WriteLine(args[i]);
            bool typeIfInt = checkNum(args[i]);
            if (typeIfInt)
            {
                int convertToInt = Convert.ToInt32(args[i]);
                addNum(convertToInt);
                checkPositive(convertToInt);
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
            temporaryInt.Clear();
            Console.WriteLine("You entered less than 3 positive numbers. Please enter again.");
        }
    }

    // 1. פונקציה שמאפשרת למשתמש להחליף את סדרת המספרים
    static void changeList()
    {
        bool quit = true;
        countIntPositive = 0;
        Console.WriteLine("\nTo confirm the list, press Q.");
        while (quit)
        {
            Console.WriteLine("\nEnter num: ");
            string enterNum = Console.ReadLine();
            if (enterNum == "q" || enterNum == "Q")
            {
                bool checkLength = checkLengthList();
                if (checkLength)
                {
                    ReplaceList();
                    print();
                } else
                {
                    temporaryInt.Clear();
                    countIntPositive = 0;
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
                    int convertToInt = Convert.ToInt32(enterNum);
                    addNum(convertToInt);
                    checkPositive(convertToInt);
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
    static void addNum(int enterNum)
    {
        temporaryInt.Add(enterNum);
    }

    // בדיקת המספר אם הוא חיובי
    static bool checkPositive(int num)
    {
        if (num > 0)
        {
            countIntPositive++;
            return true;
        } else
        {
            return false;
        }
    }

    // בדיקה אם בפונקציה הזמנית יש מעל 3 ערכים חיוביים
    static bool checkLengthList()
    {
        return countIntPositive >= 3 ? true : false;
    }

    // החלפת הפונקציה המקורית בפונקציה הזמנית
    static void ReplaceList()
    {
        ints = new List<int>(temporaryInt);
        temporaryInt.Clear();
        continuation = false;
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
        Console.WriteLine("The number highest is: " + highest);
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
        Console.WriteLine("The number lowest is: " + lowest);
    }
    // 7. הדפסת הממוצע של הסדרה
    static void average()
    {
        Console.WriteLine("The average is: " + (double)sumOfSeries() / ints.Count);
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
        Console.WriteLine("The total number of terms in the series is: " + ints.Count);
    }

    // 9. סכום האיברים בסדרה
    static void sum()
    {
        Console.WriteLine("Sum the series is: " + sumOfSeries());
    }

    // 10. יציאה מהתכנית
    static void exit()
    {
        stop = false;
        Console.WriteLine("Bye");
    }

    static void checkSerios(string[] args)
    {
        checkArr(args);
        if (ints.Count == 0)
        {
            temporaryInt.Clear();
            for (int i = 0; i < temporaryInt.Count; i++)
            {
                Console.WriteLine(temporaryInt[i]);
            }
            Console.WriteLine("You have no values in ARGS, please enter a series manually.");
            changeList();
        }
    }
    // פונקציית תפריט
    static void menu(string[] args)
    {
        while (stop)
        {
            while (continuation)
            {
                checkSerios(args);
            }
            Console.WriteLine("|\t\t\t    menu:\t\t\t\t|\n|----------------------—-––—–-----------------------------------|\n|\tSelect using a number from the menu what you want:\t|\n|\t1. Replace the series.\t\t\t\t\t|\n|\t2. Print the series.\t\t\t\t\t|\n|\t3. Print the series in reverse order.\t\t\t|\n|\t4. Print sorted from low to high.\t\t\t|\n|\t5. Print the highest value.\t\t\t\t|\n|\t6. Print the lowest value.\t\t\t\t|\n|\t7. Print the average of the series.\t\t\t|\n|\t8. Print the number of values in the series.\t\t|\n|\t9. Print the sum of the series.\t\t\t\t|\n|\t10. Exit\t\t\t\t\t\t|\n|_______________________________________________________________|");
            bool intOrString = int.TryParse(Console.ReadLine(), out int chooseNum);
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