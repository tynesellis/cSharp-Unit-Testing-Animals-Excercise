using System;
namespace Animals
{
    public class Dog : Animal
    {
        private string _name;
        private string _genus;
        private string _species;
        public bool _bites;
        public Dog(string name, string genus, string species) : base(name, genus, species)
        {
            _name = name;
            _genus = genus;
            _species = species;
        }
    }
}