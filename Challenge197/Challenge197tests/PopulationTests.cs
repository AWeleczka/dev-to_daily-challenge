using NUnit.Framework;
using de.aweleczka.to.dev.dailychallenge197.lib;

namespace de.aweleczka.to.dev.dailychallenge197.tests
{
    public class PopulationTests
    {

        [Test]
        public void NbYearTestZero()
        {
            int years = Population.NbYear(1000, 2, 50, 1200);

            Assert.AreEqual(3, years);
        }

        [Test]
        public void NbYearTestOne()
        {
            int years = Population.NbYear(1500, 5, 100, 5000);

            Assert.AreEqual(15, years);
        }

        [Test]
        public void NbYearTestTwo()
        {
            int years = Population.NbYear(1500000, 2.5, 10000, 2000000);

            Assert.AreEqual(10, years);
        }

        [Test]
        public void NbYearTestThree()
        {
            int years = Population.NbYear(1500000, 0.25, 1000, 2000000);

            Assert.AreEqual(94, years);
        }

    }
}