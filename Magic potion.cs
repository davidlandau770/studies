int temperature = 78;      // טמפרטורה של השיקוי
int toxicity = 40;         // רמת רעילות בין 0 ל־100
int colorCode = 5;         // מספר צבע (0-10)
int glowLevel = 6;         // רמת זוהר בין 0 ל־10

// שאלה 1
int baseScore;
baseScore = (100 - toxicity) + glowLevel * 3 - Math.Abs(colorCode - 7) * 2;
Console.WriteLine(baseScore);

// שאלה 2
if (baseScore >= 80)
{
    Console.WriteLine("The potion is successful.");
} else if (baseScore < 80)
{
    Console.WriteLine("The potion is unsuccessful.");
}

// שאלה 3
Console.WriteLine((temperature > 90 || toxicity > 70) ? "The potion is dangerous." : "The potion is not dangerous.");

// שאלה 4
Console.WriteLine((colorCode == 7 && glowLevel > 7) ? "The potion is rare." : "The potion is not uncommon.");

// שאלה 5
Console.WriteLine((baseScore > 80 && (temperature < 90 && toxicity < 70)) ? "Approved for public use." : "Not approved for public use.");

// שאלה 6
int bonus = 0;
Console.WriteLine((colorCode == 7 && glowLevel > 7 && baseScore > 80 && temperature < 90 && toxicity < 70) ? "bonus = " + (bonus += 10) + "total baseScore is " + (baseScore + bonus) : "");

// שאלה 7
Console.WriteLine((temperature - toxicity) > 50 || (toxicity - temperature) > 50 ? "bonus = " + (bonus -= 10) + "total baseScore is " + (baseScore + bonus) : "");

// שאלה 8
Console.WriteLine(glowLevel == colorCode ? "bonus = " + (bonus += 7) + "total baseScore is " + (baseScore + bonus) : "");

// שאלה 9
Console.WriteLine(temperature > 100 ? "bonus = " + (bonus -= 15) + "total baseScore is " + (baseScore + bonus) : "");

// שאלה 10
Console.WriteLine(toxicity < 30 && glowLevel >= 8 && temperature > 65 && temperature < 85 ? "bonus = " + (bonus += 12) + "total baseScore is " + (baseScore + bonus) : "");

Console.WriteLine(baseScore + bonus);



