/*
 * Vin Fletcher's Arrows
 * :: Classes ::
 */

using System.Globalization;
using _023_vin_fletchers_arrows.Models;

// Starting stuff
Console.Title = "Vin Fletcher's Arrows";
Console.Clear();

// Create arrow
Arrow.Arrowhead arrowHead = ArrowheadSelect();
Arrow.Fletching fletching = FletchingSelect();
float shaftLength = ShaftLengthSelect();
Arrow arrow = new Arrow(); // New instance of Arrow

// Get cost of arrow
float arrowCost = GetCost(arrowHead, fletching, shaftLength);

Arrow.Arrowhead ArrowheadSelect()
{
    Console.Write("Please select your arrowhead type: "); 
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

Arrow.Fletching FletchingSelect() 
{
    Console.WriteLine("Please select your fletching (feathery stuff at the end): ");
    string? userInputFletching = Console.ReadLine();

    if (userInputFletching == null) FletchingSelect();
    if (userInputFletching == Arrow.Fletching.Plastic.ToString().ToLower())
    {
        Console.WriteLine("Plastic, eh? Keepin' it cheap is an option.");
        return Arrow.Fletching.Plastic;
    }
    if (userInputFletching == Arrow.Fletching.TurkeyFeathers.ToString().ToLower())
    {
        Console.WriteLine("Nice! Steppin' it up to the turkey feathers.");
        return Arrow.Fletching.TurkeyFeathers;
    }
    if (userInputFletching == Arrow.Fletching.GooseFeathers.ToString().ToLower())
    {
        Console.WriteLine("Look at money bags over here with the goose feathers.");
        return Arrow.Fletching.GooseFeathers;
    }
    Console.Write("Please enter a valid selection. Press a key to try again. ");
    Console.ReadLine();
    FletchingSelect();
    
    // Catch-all return
    return Arrow.Fletching.Plastic;
}

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

float GetCost(Arrow.Arrowhead aHead, Arrow.Fletching aFletching, float sLength)
{
    float costPerCentimeter = 0.05f;
    float total = (int)aHead + (int)aFletching + (costPerCentimeter * sLength); // TODO - load this expression into the Arrow constructor

    Console.WriteLine($"That'll be {total} gold please. :)");
    return total;
}

// TODO : Take earlier selections to create instance of Arrow class

// TODO : Display the calculated arrow cost to the user
