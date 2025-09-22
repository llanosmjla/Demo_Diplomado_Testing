using LubricantesAyrthonAPI.Controllers;

namespace LubricantesAyrthonAPI.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var controller = new WeatherForecastController(null);
            //Act
            var result = controller.Get();
            //Assert
            Assert.NotNull(result);
            Assert.IsType<WeatherForecast[]>(result);

        }

        [Fact]
        public void Test2()
        {
            //Arrange
            var controller = new WeatherForecastController(null);
            //Act
            var result = controller.Get();
            //Assert
            Assert.NotNull(result);
            Assert.IsType<WeatherForecast[]>(result);
        }
    }
}