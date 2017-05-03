using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vsrpp_3_julia
{
    public class Figure
    {
        public String Type;
        public String Triangle_Type;
        public int x;
        public int y;
        public int perimeter;
        public String s;
        public int flag;
        static public int MyClassCompareDate(Figure mf1, Figure mf2)
        {
            if (mf1.perimeter != mf2.perimeter) 
            {
                return mf1.perimeter.CompareTo(mf2.perimeter);
            }
            else
            {
                if (mf1.x + mf1.y > mf2.x + mf2.y)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
