/*
 * Vin Fletcher's Arrows
 * :: Classes ::
 */

using _023_vin_fletchers_arrows.Models;

// Starting stuff
Console.Title = "Vin Fletcher's Arrows";
Console.Clear();

// Create arrow
Arrow arrow = new Arrow(); // New instance of Arrow

// Display final stats on created arrow
Console.WriteLine($"Well, here is your arrow with {Convert.ToString(arrow.ArrowheadCore).ToLower()} head, {Convert.ToString(arrow.FletchingCore).ToLower()} fletching, and it's {arrow.SLengthCore}cm long.");
Console.WriteLine($"That'll be {arrow.GetCost()} gold please!");