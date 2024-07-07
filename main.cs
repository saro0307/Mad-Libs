using System;

class Program
{
    static void Main()
    {
        // Display a welcome message
        Console.WriteLine("Welcome to the Mad Libs game with 'Something in the Way' by Nirvana!");

        // Ask the user for inputs
        Console.Write("Enter a noun: ");
        string noun1 = Console.ReadLine();

        Console.Write("Enter a place: ");
        string place1 = Console.ReadLine();

        Console.Write("Enter an adjective: ");
        string adjective1 = Console.ReadLine();

        Console.Write("Enter a verb ending in -ing: ");
        string verb1 = Console.ReadLine();

        Console.Write("Enter another noun: ");
        string noun2 = Console.ReadLine();

        Console.Write("Enter another adjective: ");
        string adjective2 = Console.ReadLine();

        // Mad Libs lyrics with placeholders
        string lyrics = $@"
{noun1} in the {place1}
{noun1} in the {place1}, yeah
It's okay to eat {adjective1} fish
'Cause they don't have any {verb1}
Something in the {noun2}, mmm
Something in the {noun2}, yeah
Something in the {noun2}, mmm
Something in the {noun2}, yeah

{adjective2} {noun1} in the {place1}
{adjective2} {noun1} in the {place1}, yeah
It's okay to eat {adjective1} fish
'Cause they don't have any {verb1}
Something in the {noun2}, mmm
Something in the {noun2}, yeah
Something in the {noun2}, mmm
Something in the {noun2}, yeah";

        // Display the Mad Libs lyrics
        Console.WriteLine("\nHere are your Mad Libs lyrics:");
        Console.WriteLine(lyrics);
    }
}
