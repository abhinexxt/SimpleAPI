using System;
using Xunit;
using SimpleAPI.Controllers;
namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetReturnsAll()
        {
            var returnValue = controller.Get();
            Assert.Equal(1,1);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
