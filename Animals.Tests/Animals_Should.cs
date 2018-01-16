using System;
using Xunit;

namespace Animals.Tests
{
    public class AnimalsTest
    {
        Animal ducky = new Animal("mallard", "anas", "platyrhynchos");

        [Fact]
        public void AnimalShould()
        {
            //Given the above instance of Animal - ducky
            //The following implementations should be equivalent
            Assert.Equal(ducky.Name, "mallard");
            Assert.Equal(ducky.Species, "platyrhynchos");
        }

        public void AnimalSpeedShould()
        {
            //given the following implementaiton of Walks()
            ducky.Walks(5);
            //the following should be equivalent
            Assert.Equal(expected: ducky.Speed, actual: 5);
        }

        private Dog doggy = new Dog("Spot", "Canis", "Canis Lupus");

        [Fact]
        public void DogShould()
        {
            //Given the instance of doggy above, the following implementation should be equal
            Assert.Equal(doggy.Name, "Spot");
        }

        public void DogSpeedShould()
        {
            //given the following implementaiton of Walks()
            doggy.Walks(30);
            //the following should be equivalent
            Assert.Equal(doggy.Speed, 30);
        }
    }
}
