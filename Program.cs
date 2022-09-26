/*
 * Vin Fletcher's Arrows
 * :: Classes ::
 */

using _023_vin_fletchers_arrows.Models;

// Starting stuff
Console.Title = "Vin Fletcher's Arrows";
Console.Clear();

// Initialize Arrow
Arrow arrow = new Arrow();
string userArrowType = arrow.ArrowType[3];

// Check to see if user wants a pre-defined arrow or a custom one
Console.WriteLine("Here are your options for creating an arrow today: ");
Console.WriteLine("1. Beginner Arrow");
Console.WriteLine("2. Marksman Arrow");
Console.WriteLine("3. Elite Arrow");
Console.WriteLine("4. Custom Arrow - You will be guided through steps to create your perfect arrow.");
Console.WriteLine("--------------------------------------------------------------------------------");
Console.Write("Please enter your selection by typing the number of your desired arrow choice: ");
string? userChoice = Console.ReadLine();

if (userChoice is not null && Convert.ToInt16(userChoice) > 0 && Convert.ToInt16(userChoice) < 5)
{
    switch (userChoice)
    {
        case "1":
            arrow = Arrow.CreateBeginnerArrow();
            userArrowType = arrow.ArrowType[0];
            break;
        case "2":
            arrow = Arrow.CreateMarksmanArrow();
            userArrowType = arrow.ArrowType[1];
            break;
        case "3":
            arrow = Arrow.CreateEliteArrow();
            userArrowType = arrow.ArrowType[2];
            break;
        case "4":
            arrow = new Arrow("custom");
            userArrowType = arrow.ArrowType[3];
            break;
    }
}

// Display final stats on custom-created arrow
string arrowHeadResult = arrow.ArrowheadCore.ToString().ToLower();
string arrowFletchingResult = arrow.FletchingCore.ToString().ToLower();
string arrowLengthResult = arrow.SLengthCore.ToString("N2");

Console.WriteLine($"Well, here is your {userArrowType} arrow with {arrowHeadResult} head, {arrowFletchingResult} fletching, and it's {arrowLengthResult}cm long.");
Console.WriteLine($"That'll be {arrow.GetCost()} gold please!");