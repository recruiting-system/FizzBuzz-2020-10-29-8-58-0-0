using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class HelloWorldTest
    {
        [Fact]
        public void Hello_world_test()
        {
            //given
            Dependency dependency = new Dependency();
            HelloWorld helloWorld = new HelloWorld(dependency);

            //when
            string actual = helloWorld.BeenCalled();

            //then
            Assert.Equal("Leave me alone.", actual);
        }

        [Fact]
        public void Should_be_mocked()
        {
            //given
            var mockDependencu = new Mock<Dependency>();
            mockDependencu.Setup(m => m.Say()).Returns("Hello World");
            HelloWorld helloWorld = new HelloWorld(mockDependencu.Object);

            //when
            string actual = helloWorld.BeenCalled();

            //then
            Assert.Equal("Hello World", actual);
        }
    }
}