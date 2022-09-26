/*
 * Vin Fletcher's Arrows
 * :: Classes ::
 */

using _023_vin_fletchers_arrows.Models;

// Starting stuff
Console.Title = "Vin Fletcher's Arrows";
Console.Clear();

Arrow arrow = new Arrow(56); // TODO - It's working!! But this is a dumb workaround. Fix it. :)

// Check to see if user wants a pre-defined arrow or a custom one
Console.WriteLine("Here are your options for creating an arrow today: ");
Console.WriteLine("1. Beginner Arrow");
Console.WriteLine("2. Marksman Arrow");
Console.WriteLine("3. Elite Arrow");
Console.WriteLine("4. Custom Arrow - You will be guided through steps to create your perfect arrow.");
Console.WriteLine("--------------------------------------------------------------------------------");
Console.Write("Please enter your selection by typing the number of your desired arrow choice: ");
string? userChoice = Console.ReadLine();

if (userChoice is not null)
{
    switch (userChoice)
    {
        case "1": // TODO - Able to force through property changes, but need to change through static methods
            arrow = Arrow.CreateBeginnerArrow();
            break;
        case "2":
            arrow = Arrow.CreateMarksmanArrow();
            break;
        case "3":
            arrow = Arrow.CreateEliteArrow();
            break;
        case "4":
            arrow = new Arrow();
            break;
    }
}
else
{
    arrow = new Arrow();
}




// Display final stats on custom-created arrow
    Console.WriteLine($"Well, here is your arrow with {Convert.ToString(arrow.ArrowheadCore).ToLower()} head, {Convert.ToString(arrow.FletchingCore).ToLower()} fletching, and it's {arrow.SLengthCore}cm long.");
    Console.WriteLine($"That'll be {arrow.GetCost()} gold please!");