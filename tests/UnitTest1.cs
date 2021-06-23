using NUnit.Framework;
using overlapsRange;

namespace tests
{
    public class Tests
    {

        [Test]
        public void Range2to5_Overlaps_With_Range3to6()
        {
            RangeC r = new RangeC("[2,5)");
            RangeC x = new RangeC("[3,6)");
            Assert.IsTrue(r.overlapsWith(x));
            
        }
 
    }
}