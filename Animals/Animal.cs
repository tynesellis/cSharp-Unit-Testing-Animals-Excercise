namespace Animals
{
    public class Animal : IAmbulatory
    {
        private string _name;
        private string _genus;
        private string _species;

        private int _speed;

        public Animal(string name, string genus, string species)
        {
            _name = name;
            _genus = genus;
            _species = species;
        }

        public string Name => _name;
        public string Genus => _genus;
        public string Species => _species;
        public int Speed => _speed;

        public void Walks(int speed)
        {
            _speed = speed;
        }
    }
}