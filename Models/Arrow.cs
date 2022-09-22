namespace _023_vin_fletchers_arrows.Models
{
    public class Arrow
    {
        public Arrow()
        {
            
        }

        public Arrow(float length)
        {
            _length = length;
        }
        
        // Numbers are the cost
        public enum Arrowhead
        {
            Steel = 10,
            Wood = 3,
            Obsidian = 5
        }
        
        // Numbers are the cost
        public enum Fletching
        {
            Plastic = 10,
            TurkeyFeathers = 5,
            GooseFeathers = 3
        }
        public float _length;
        
        // TODO - Create function which pulls cost from the materials selected
        
    }
}