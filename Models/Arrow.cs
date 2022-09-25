namespace _023_vin_fletchers_arrows.Models
{
    public class Arrow
    {
        public Arrowhead ArrowheadCore { get; set; }
        public Fletching FletchingCore { get; set; }
        public float SLengthCore { get; set; }

        public Arrow()
        {
            ArrowheadCore = ArrowheadSelect();
            FletchingCore = FletchingSelect();
            SLengthCore = ShaftLengthSelect();
        }
        
        public enum Arrowhead
        {
            // Numbers are the cost
            Steel = 10,
            Wood = 3,
            Obsidian = 5
        }
        
        public enum Fletching
        {
            // Numbers are the cost
            Plastic = 10,
            TurkeyFeathers = 5,
            GooseFeathers = 3
        }
        
        // Arrowhead selection
        private Arrowhead ArrowheadSelect()
        {
            Console.WriteLine("Please select your arrowhead type: ");
            Console.WriteLine("Options: wood, steel, obsidian");
            string? userInputArrowhead = Console.ReadLine();

            if (userInputArrowhead == null) ArrowheadSelect();
            if (userInputArrowhead == Arrowhead.Steel.ToString().ToLower())
            {
                Console.WriteLine("Steel arrowhead, got it!");
                return Arrowhead.Steel;
            }
            if (userInputArrowhead == Arrowhead.Wood.ToString().ToLower())
            {
                Console.WriteLine("Wood, eh? Your funeral.");
                return Arrowhead.Wood;
            }
            if (userInputArrowhead == Arrowhead.Obsidian.ToString().ToLower())
            {
                Console.WriteLine("Oooh, keepin' it old school.");
                return Arrowhead.Obsidian;
            }
            Console.Write("Please enter a valid selection. Press a key to try again. ");
            Console.ReadLine();
            ArrowheadSelect();
            
            // Req return statement
            return Arrowhead.Steel;
        }

        // Fletching selection
        private Fletching FletchingSelect() 
        {
            Console.WriteLine("Please select your fletching (feathery stuff at the end): ");
            Console.WriteLine("Options: goosefeathers, turkeyfeathers, plastic");
            string? userInputFletching = Console.ReadLine();

            if (userInputFletching == null) FletchingSelect();
            if (userInputFletching == Fletching.Plastic.ToString().ToLower())
            {
                Console.WriteLine("Plastic, eh? Nice.");
                return Fletching.Plastic;
            }
            if (userInputFletching == Fletching.TurkeyFeathers.ToString().ToLower())
            {
                Console.WriteLine("Gobble gobble!");
                return Fletching.TurkeyFeathers;
            }
            if (userInputFletching == Fletching.GooseFeathers.ToString().ToLower())
            {
                Console.WriteLine("Mmmmm so soft.");
                return Fletching.GooseFeathers;
            }
            Console.Write("Please enter a valid selection. Press a key to try again. ");
            Console.ReadLine();
            FletchingSelect();
            
            // Catch-all return
            return Fletching.Plastic;
        }

        // Shaft length selection
        private float ShaftLengthSelect()
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

        public float GetCost()
        {
            float costPerCentimeter = 0.05f;
            float total = (int)ArrowheadCore + (int)FletchingCore + (costPerCentimeter * SLengthCore);

            return total;
        }
    }
}