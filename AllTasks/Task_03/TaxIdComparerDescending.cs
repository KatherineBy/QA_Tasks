namespace Task_03
{
    public class TaxIdComparerDescending: IComparer<UniversityEmployee>
    {
        public int Compare(UniversityEmployee x, UniversityEmployee y)
        {
            return x.GetNameLength().CompareTo(y.GetNameLength()) * -1;
        }
    }
}
