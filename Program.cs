// See https://aka.ms/new-console-template for more information

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        
        Console.Write("Please enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter your eye color: ");
        string eye_color = Console.ReadLine();

        Console.Write("Please enter your hair color: ");
        string hair_color = Console.ReadLine();

        Console.Write("Please enter your shoe size: ");
        int shoe_size = int.Parse(Console.ReadLine());

        Console.Write("Please enter your favorite color: ");
        string color = Console.ReadLine();

        Console.Write("Enter your favorite tv show or movie: ");
        string fav_film = Console.ReadLine();

        Console.Write("Enter your favorite teacher: ");
        string fav_teacher = Console.ReadLine();

        Console.Write("Enter your favorite class: ");
        string fav_class = Console.ReadLine();

        Console.Write("Enter your favorite holiday: ");
        string fav_holiday = Console.ReadLine();

        Console.Write("Enter your favorite season: ");
        string fav_season = Console.ReadLine();

        Console.Write("Enter your dream job: ");
        string job = Console.ReadLine();

        int future_age = age + 5;

        Console.Write ("How many siblings do you have?: ");
        int siblings = Convert.ToInt32(Console.ReadLine());
        // Two ways to get ints as a variable, either .Parse() or Convert.ToInt32() 



        Console.WriteLine("My friend's name is " + name + ". " + name + " is " + age + " years old. " + name + "'s eye color is " + eye_color + ". " + name + "'s hair color is "
        + hair_color + ". " + name + "'s shoe size is " + shoe_size + ". " + name + "'s favorite color is " + color + ". " + name + "'s favorite tv show or movie is " + fav_film + 
        ". " + name + "'s favorite teacher is " + fav_teacher + ". " + "Their favorite class is also " + fav_class + ". " + name + "'s favorite holiday is " + fav_holiday + " and their favorite season is " + fav_season + ". " + name + "'s dream job in the future is to work as a " + job + ". " + name + " will be " + future_age + " in 5 years. Finally, " + name + " has " + siblings + " siblings."); 


    }
}