namespace _023_vin_fletchers_arrows.Models
{
    public class Arrow
    {
        // private readonly Arrowhead _aHead;
        // private readonly Fletching _aFletching;
        // private float _sLength;

        public Arrowhead ArrowheadCore { get; set; }
        public Fletching FletchingCore { get; set; }
        public float SLengthCore { get; set; }

        public Arrow(Arrowhead aHead, Fletching aFletching, float sLength)
        {
            ArrowheadCore = aHead;
            FletchingCore = aFletching;
            SLengthCore = sLength;
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

        public float GetCost(Arrowhead aHead, Fletching aFletching, float sLength)
        {
            float costPerCentimeter = 0.05f;
            float total = (int)aHead + (int)aFletching + (costPerCentimeter * sLength);

            return total;
        }
    }
}