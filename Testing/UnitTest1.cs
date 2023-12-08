using LibProjectConvertt;
namespace Testing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.That(Converter.Metod(105.5), Is.EqualTo(1000));
        }

        [Test]
        public void Test2()
        {
            Assert.That(Converter.Metod(65.7), Is.EqualTo(65));
        }

        [Test]
        public void Test3()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Converter.Metod(0);
            });
        }

        [Test]
        public void Test4()
        {
            Assert.That(Converter.Metod(-10.3), Is.EqualTo(-15));
        }

        [Test]
        public void Test5()
        {
            Assert.That(Converter.Metod(-40.2), Is.EqualTo(-2000));
        }
    }
}