using System;
using System.Collections.Generic;

namespace overlapsRange
{

    public class overlapRange
    {
        private string [] delete = {"[","(",",",")","]"};

        public  string [] checkRange(string range)
        {
            string[] arrRange = range.Split(delete, StringSplitOptions.RemoveEmptyEntries);

            if (range[0] == '(')
            {
                int value = int.Parse(arrRange[0]) + 1;
                arrRange[0] = value.ToString();
            }

            if (range[1] == ')')
            {
                int value = int.Parse(arrRange[1]) - 1;
                arrRange[1] = value.ToString();
            }

            return arrRange;

        }

        public bool overlapsRange (range range1,string range2)
        {
            string[] arrRange1 = checkRange(range1.ran);
            string[] arrRange2 = checkRange(range2);

            int from1 = int.Parse(arrRange1[0]);
            int from2 = int.Parse(arrRange2[0]);
            int to1 = int.Parse(arrRange1[1]);
            int to2 = int.Parse(arrRange2[1]);

            if (from1 == from2)
                return true;

            if (to1 == to2)
                return true;

            if (from2 < to1)
                return true;

            return false;
        }
    }
}

