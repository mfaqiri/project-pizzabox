using Xunit;
using PizzaBox.Domain.Models;

namespace PizzaBox.Testing.Tests
{
    public class StoreTests
    {
        [Fact]
        public void Test_ChicagoStore()
        {
            //arrange
            var sut = new ChicagoStore();

            //act
            var actual = sut.name;

            //assert
            Assert.True(actual == "ChicagoStore");
        }


        [Fact]
        public void Test_NewYorkStore()
        {
            //arrange
            var sut = new NewYorkStore();

            //act
            var actual = sut.name;

            //assert
            Assert.True(actual == "NewYorkStore");
        }
    }
}