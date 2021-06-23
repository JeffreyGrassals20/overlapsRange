using System;

namespace overlapsRange
{

    public class RangeC
    {
        private readonly int _realMin;
        private readonly int _realMax;
        private char[] remove = { '[', ']', '(', ')', ',' };

        public RangeC (string range)
        {
            (_realMin, _realMax) = LaMagiaDeJeffrey(range);
        }

        private (int _realMin, int _realMax) LaMagiaDeJeffrey(string range)
        {
            string [] arrRange = range.Split(remove, StringSplitOptions.RemoveEmptyEntries);

            int value = 0;
            int valuemax = 0;
            if(range[0] == '(')
            {
                value = int.Parse(arrRange[0]) + 1;
                arrRange[0] = value.ToString();

            }

            if (range[^1] == ')')
            {
                valuemax = int.Parse(arrRange[^1]) - 1;
                arrRange[^1] = valuemax.ToString();
            }

            return (int.Parse(arrRange[0]), int.Parse(arrRange[^1]));
        }

        public bool overlapsWith(RangeC range)
        {

            if (_realMax == range._realMax)
                return true;
            
            if (_realMin == range._realMin)
                return true;

            if (range._realMax > _realMin)
                return true;

            return false;
        }

    }
}

  