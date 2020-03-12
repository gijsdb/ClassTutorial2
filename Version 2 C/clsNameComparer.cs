using System;
using System.Collections.Generic;

namespace Version_2_C
{
    public sealed partial class clsNameComparer : IComparer<clsWork>
    {
        private clsNameComparer() { }
        public static readonly clsNameComparer Instance = new clsNameComparer();

        public int Compare(clsWork x, clsWork y)
        {
            string lcNameX = x.Name;
            string lcNameY = y.Name;

            return lcNameX.CompareTo(lcNameY);
        }
    }
}
