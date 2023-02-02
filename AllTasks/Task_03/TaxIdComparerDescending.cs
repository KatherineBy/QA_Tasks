namespace Task_03
{
    internal class TaxIdComparerDescending: IComparer<UniversityEmployee>
    {
        public int Compare(UniversityEmployee x, UniversityEmployee y)
        {
            return x.GetNameLength().CompareTo(y.GetNameLength()) * -1;
        }
    }
}
