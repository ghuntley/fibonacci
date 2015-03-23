using System;
using System.Numerics;
using FluentAssertions;
using NUnit.Framework;

namespace Fibonacci.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        [Test]
        public void FastDoubleShouldBeExpected()
        {
            Fibonaci.Nth(-46).Should().Be(-1836311903);
            Fibonaci.Nth(-8).Should().Be(-21);
            Fibonaci.Nth(-3).Should().Be(2);
            Fibonaci.Nth(-2).Should().Be(-1);
            Fibonaci.Nth(-1).Should().Be(1);
            Fibonaci.Nth(0).Should().Be(1);
            Fibonaci.Nth(1).Should().Be(1);
            Fibonaci.Nth(2).Should().Be(1);
            Fibonaci.Nth(3).Should().Be(2);
            Fibonaci.Nth(8).Should().Be(21);
            Fibonaci.Nth(46).Should().Be(1836311903);
            Fibonaci.Nth(91).Should().Be(4660046610375530309);
            Fibonaci.Nth(new BigInteger(92)).Should().Be(7540113804746346429);
            Fibonaci.Nth(new BigInteger(100)).Should().Be(BigInteger.Parse("354224848179261915075"));
            Fibonaci.Nth(new BigInteger(1000))
                .Should()
                .Be(
                    BigInteger.Parse(
                        "43466557686937456435688527675040625802564660517371780402481729089536555417949051890403879840079255169295922593080322634775209689623239873322471161642996440906533187938298969649928516003704476137795166849228875"));
        }

        [Test, MaxTime(10000)]
        public void Fibonacci1000000000ChallengeCompletesWithin10Seconds()
        {
            Fibonaci.Nth(new BigInteger(1000000));
        }

        [Test]
        public void NthShouldBeExpected()
        {
            Fibonaci.Nth(-1).Should().Be(1);
            Fibonaci.Nth(0).Should().Be(1);
            Fibonaci.Nth(1).Should().Be(1);
            Fibonaci.Nth(2).Should().Be(1);
            Fibonaci.Nth(3).Should().Be(2);
            Fibonaci.Nth(8).Should().Be(21);
            Fibonaci.Nth(46).Should().Be(1836311903);
            Fibonaci.Nth(91).Should().Be(4660046610375530309);
            Fibonaci.Nth(new BigInteger(92)).Should().Be(7540113804746346429);
            Fibonaci.Nth(new BigInteger(100)).Should().Be(BigInteger.Parse("354224848179261915075"));
            Fibonaci.Nth(new BigInteger(1000))
                .Should()
                .Be(
                    BigInteger.Parse(
                        "43466557686937456435688527675040625802564660517371780402481729089536555417949051890403879840079255169295922593080322634775209689623239873322471161642996440906533187938298969649928516003704476137795166849228875"));
        }
        [Test]
        public void NthShouldThrowOutOfRangeException()
        {
            Action longMinValue = () => Fibonaci.Nth(-92);
            longMinValue.ShouldThrow<ArgumentOutOfRangeException>();

            Action longMaxValue = () => Fibonaci.Nth(92);
            longMaxValue.ShouldThrow<ArgumentOutOfRangeException>();
        }
    }
}