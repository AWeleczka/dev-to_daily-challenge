using de.aweleczka.to.dev.dailychallenge195.lib;
using NUnit.Framework;

namespace de.aweleczka.to.dev.dailychallenge195.tests
{
    class C195tests
    {

        [Test]
        public void Test9070()
        {
            int expected = 907;
            int number = 9070;

            Assert.AreEqual(expected, number.StripTrailingZeros());
        }

        [Test]
        public void Test210000()
        {
            int expected = 21;
            int number = 210000;

            Assert.AreEqual(expected, number.StripTrailingZeros());
        }

        [Test]
        public void Test10210()
        {
            int expected = 1021;
            int number = 10210;

            Assert.AreEqual(expected, number.StripTrailingZeros());
        }

        [Test]
        public void Test0()
        {
            int expected = 0;
            int number = 0;

            Assert.AreEqual(expected, number.StripTrailingZeros());
        }

    }
}
