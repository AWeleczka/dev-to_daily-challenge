using de.aweleczka.to.dev.dailychallenge195.lib;
using NUnit.Framework;

namespace de.aweleczka.to.dev.dailychallenge195.tests
{
    class C195reference
    {

        [Test]
        public void Ref1450()
        {
            int expected = 145;
            int number = 1450;

            Assert.AreEqual(expected, number.StripTrailingZeros());
        }

        [Test]
        public void Ref960000()
        {
            int expected = 96;
            int number = 960000;

            Assert.AreEqual(expected, number.StripTrailingZeros());
        }

        [Test]
        public void Ref1050()
        {
            int expected = 105;
            int number = 1050;

            Assert.AreEqual(expected, number.StripTrailingZeros());
        }

        [Test]
        public void Refn1050()
        {
            int expected = -105;
            int number = -1050;

            Assert.AreEqual(expected, number.StripTrailingZeros());
        }

        [Test]
        public void Check123()
        {
            int expected = 123;
            int number = 123;

            Assert.AreEqual(expected, number.StripTrailingZeros());
        }

    }
}
