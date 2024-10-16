// See https://aka.ms/new-console-template for more information

using System;

public class Program
{
    public static string name;
    public static string age;
    public static string eyeColor;
    public static string hairColor;
    public static string shoeSize;
    public static string favoriteColor;
    public static string favoriteTVorMovie;
    public static string favoriteTeacher;
    public static string favoriteClass;
    public static string favoriteHoliday;
    public static string favoriteSeason;
    public static string dreamJob;
    public static string numberOfSiblings;
    public static int ageIn5Years;


    public static void Main(string[] args)
    {
        AskName();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteTvShow();
        AskFavoriteTeacher();
        AskFavoriteClass();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskDreamJob();
        CalculateAgeIn5Years(age);
        AskNumberOfSiblings();
        DisplaySummaryMessage();
    }



    public static void AskName(){
        Console.WriteLine("Please enter your name: ");
        name = Console.ReadLine();
    }
    public static void AskAge(){
        Console.Write("Please enter your age: ");
        age = Console.ReadLine();
    }

    public static void AskEyeColor(){
        Console.Write("Please enter your eye color: ");
        eyeColor = Console.ReadLine();
    }

    public static void AskHairColor(){
        Console.Write("Please enter your hair color: ");
        hairColor = Console.ReadLine();
    }

    public static void AskShoeSize(){
        Console.Write("Please enter your shoe size: ");
        shoeSize = Console.ReadLine();
    }

    public static void AskFavoriteColor(){
        Console.Write("Please enter your favorite color: ");
        favoriteColor = Console.ReadLine();
    }

    public static void AskFavoriteTvShow(){
        Console.Write("Enter your favorite tv show or movie: ");
        favoriteTVorMovie = Console.ReadLine();
    }

    public static void AskFavoriteTeacher(){
        Console.Write("Enter your favorite teacher: ");
        favoriteTeacher = Console.ReadLine();
    }
    public static void AskFavoriteClass(){
        Console.Write("Enter your favorite class: ");
        favoriteClass = Console.ReadLine();
    }

    public static void AskFavoriteHoliday(){
        Console.Write("Enter your favorite holiday: ");
        favoriteHoliday = Console.ReadLine();
    }

    public static void AskFavoriteSeason(){
        Console.Write("Enter your favorite season: ");
        favoriteSeason = Console.ReadLine();
    }

    public static void AskDreamJob(){
        Console.Write("Enter your dream job: ");
        dreamJob = Console.ReadLine();
    }

    public static void CalculateAgeIn5Years(string age){
        // local age variable
        int ageInt = int.Parse(age); // New variable here as a placeholder int age variable, for conversion.
        ageIn5Years = ageInt + 5;
    }

    public static void AskNumberOfSiblings(){
        Console.Write ("How many siblings do you have?: ");
        numberOfSiblings = Console.ReadLine();
        // Two ways to get ints as a variable, either .Parse() or Convert.ToInt32() 
    }

    public static void DisplaySummaryMessage(){
        Console.WriteLine("My friend's name is " + name + ". " + name + " is " + age + " years old. " + name + "'s eye color is " + eyeColor + ". " + name + "'s hair color is "
        + hairColor + ". " + name + "'s shoe size is " + shoeSize + ". " + name + "'s favorite color is " + favoriteColor + ". " + name + "'s favorite tv show or movie is " + favoriteTVorMovie + 
        ". " + name + "'s favorite teacher is " + favoriteTeacher + ". " + "Their favorite class is also " + favoriteClass + ". " + name + "'s favorite holiday is " + favoriteHoliday + " and their favorite season is " 
        + favoriteSeason + ". " + name + "'s dream job in the future is to work as a " + dreamJob + ". " + name + " will be " + ageIn5Years + " in 5 years. Finally, " + name + " has " + numberOfSiblings + " siblings."); 
    }
}