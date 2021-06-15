using NUnit.Framework;
using overlapsRange;
namespace tests
{
    public class Tests
    {


        [Test]
        public void Range1_doesnt_overlaps_with_Range2 ()
        {
            overlapRange program = new overlapRange();
            range p = new range("[2,5)");
            Assert.IsFalse(program.overlapsRange(p, "[10,20)"));

        }

        [Test]
        public void Range2_doesnt_overlaps_with_Range1()
        {
            overlapRange program = new overlapRange();
            range p = new range("[1,3)");
            Assert.IsFalse(program.overlapsRange(p, "[5,8)"));

        }

        [Test]
        public void Range1_Is_The_Same_As_Range2()
        {
            overlapRange program = new overlapRange();
            range p = new range("[3,5)");
            Assert.IsTrue(program.overlapsRange(p, "[3,5)"));

        }

        [Test]
        public void Range1_Overlaps_With_Range2 ()
        {
            overlapRange program = new overlapRange();
            range p = new range("[6,10)");
            Assert.IsTrue(program.overlapsRange(p, "[7,9)"));
        }

    }
}