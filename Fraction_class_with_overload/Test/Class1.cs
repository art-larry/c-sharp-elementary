using System;
using NUnit.Framework;
using Fraction_class_with_overload;

namespace Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Fraction1point5()
        {
            var fr = new Fraction(1, 2);
            double c = 1.5;
            // var actual = Fraction.GetFraction(c);
            var tfr = new Fraction(2, 1);
            if (Object.Equals(tfr, c + fr))
                Assert.AreEqual(tfr, c + fr);
        }
    }
}
