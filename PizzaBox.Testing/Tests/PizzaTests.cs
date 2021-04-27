using Xunit;
using PizzaBox.Domain.Models.Pizzas;

namespace PizzaBox.Testing.Tests
{
    public class PizzaTests
    {
        [Fact]
        public void Test_CheesePizza()
        {
            //arrange
            var sut = new CheesePizza();

            //act
            var actual = sut.name;

            //assert
            Assert.True(actual == "Cheese Pizza");
        }


        [Fact]
        public void Test_CustomPizza()
        {
            //arrange
            var sut = new CustomPizza();

            //act

            //assert
            Assert.True(sut.name.Equals("Custom Pizza"));
        }

        [Fact]
        public void Test_MeatloversPizza()
        {
            //arrange
            var sut = new MeatloversPizza();

            //act

            //assert
            Assert.True(sut.name.Equals("Meat Lover's Pizza"));
        }
    }
}