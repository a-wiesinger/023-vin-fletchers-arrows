/*
 * Vin Fletcher's Arrows
 * :: Classes ::
 */

using _023_vin_fletchers_arrows.Models;

// Starting stuff
Console.Title = "Vin Fletcher's Arrows";
Console.Clear();

// Create arrow
Arrow.Arrowhead arrowHead = ArrowheadSelect();
Arrow.Fletching fletching = FletchingSelect();
float shaftLength = ShaftLengthSelect();

Arrow arrow = new Arrow(arrowHead, fletching, shaftLength); // New instance of Arrow

// Arrowhead selection
Arrow.Arrowhead ArrowheadSelect()
{
    Console.WriteLine("Please select your arrowhead type: ");
    Console.WriteLine("Options: wood, steel, obsidian");
    string? userInputArrowhead = Console.ReadLine();

    if (userInputArrowhead == null) ArrowheadSelect();
    if (userInputArrowhead == Arrow.Arrowhead.Steel.ToString().ToLower())
    {
        Console.WriteLine("Steel arrowhead, got it!");
        return Arrow.Arrowhead.Steel;
    }
    if (userInputArrowhead == Arrow.Arrowhead.Wood.ToString().ToLower())
    {
        Console.WriteLine("Wood, eh? Your funeral.");
        return Arrow.Arrowhead.Wood;
    }
    if (userInputArrowhead == Arrow.Arrowhead.Obsidian.ToString().ToLower())
    {
        Console.WriteLine("Oooh, keepin' it old school.");
        return Arrow.Arrowhead.Obsidian;
    }
    Console.Write("Please enter a valid selection. Press a key to try again. ");
    Console.ReadLine();
    ArrowheadSelect();
    
    // Req return statement
    return Arrow.Arrowhead.Steel;
}

// Fletching selection
Arrow.Fletching FletchingSelect() 
{
    Console.WriteLine("Please select your fletching (feathery stuff at the end): ");
    Console.WriteLine("Options: goosefeathers, turkeyfeathers, plastic");
    string? userInputFletching = Console.ReadLine();

    if (userInputFletching == null) FletchingSelect();
    if (userInputFletching == Arrow.Fletching.Plastic.ToString().ToLower())
    {
        Console.WriteLine("Plastic, eh? Nice.");
        return Arrow.Fletching.Plastic;
    }
    if (userInputFletching == Arrow.Fletching.TurkeyFeathers.ToString().ToLower())
    {
        Console.WriteLine("Gobble gobble!");
        return Arrow.Fletching.TurkeyFeathers;
    }
    if (userInputFletching == Arrow.Fletching.GooseFeathers.ToString().ToLower())
    {
        Console.WriteLine("Mmmmm so soft.");
        return Arrow.Fletching.GooseFeathers;
    }
    Console.Write("Please enter a valid selection. Press a key to try again. ");
    Console.ReadLine();
    FletchingSelect();
    
    // Catch-all return
    return Arrow.Fletching.Plastic;
}

// Shaft length selection
float ShaftLengthSelect()
{
    // Get user input
    Console.Write("How long do you need the arrow shaft to be? (In centimeters, please!) ");
    string? userInputShaftLength = Console.ReadLine();
    
    // Bad state checks
    if (userInputShaftLength == null) ShaftLengthSelect();
    
    // Convert to float and check again
    float shaftLengthNum = Convert.ToSingle(userInputShaftLength);
    if (shaftLengthNum < 0 || shaftLengthNum > 100) ShaftLengthSelect();

    return (shaftLengthNum > 0) ? shaftLengthNum : ShaftLengthSelect();
}

// Get cost
float arrowCost = arrow.GetCost(arrow.GetArrowhead(), arrow.GetFletching(), arrow.GetArrowLength());

// Display final stats on created arrow
Console.WriteLine($"Well, here is your arrow with {arrow.GetArrowhead()} head, {arrow.GetFletching()} fletching, and it's {arrow.GetArrowLength()}cm long.");
Console.WriteLine($"That'll be {arrowCost.ToString("N2")} gold please!");