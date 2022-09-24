namespace _023_vin_fletchers_arrows.Models
{
    public class Arrow
    {
        private readonly Arrowhead _aHead;
        private readonly Fletching _aFletching;
        private float _sLength;

        public Arrow()
        {
            
        }

        public Arrow(Arrowhead aHead, Fletching aFletching, float sLength)
        {
            _aHead = aHead;
            _aFletching = aFletching;
            _sLength = sLength;
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

        public Arrowhead GetArrowhead() => _aHead;
        public Fletching GetFletching() => _aFletching;
        public float GetArrowLength() => _sLength;

        public float GetCost(Arrowhead aHead, Fletching aFletching, float sLength)
        {
            float costPerCentimeter = 0.05f;
            float total = (int)aHead + (int)aFletching + (costPerCentimeter * sLength);

            return total;
        }
    }
}