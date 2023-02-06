using System;

namespace Task_03
{
    public abstract class UniversityEmployee: IComparable
    {
        private string _taxId;
        private string _firstName;
        private string _lastName;
        public string TaxId
        {
            get
            {
                return _taxId;
            }
            set
            {
                CheckTaxId(value);
                _taxId = value;
            }
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                CheckNameLength(value, _lastName);
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                CheckNameLength(_firstName, value);
                _lastName = value;
            }
        }
        private void CheckNameLength(string fname, string lname)
        {
            if (lname == null) { lname = ""; }
            if (fname.Length + lname.Length > 15)
            {       
                throw new ArgumentException("Name length should be less than 15");
            }
        }

        private void CheckTaxId(string id)
        {
            if (id.Substring(0, 1) != "N")
            {
                throw new ArgumentException("ID must strat with 'N' ");
            }
        }

        public UniversityEmployee (string taxId, string firstName, string lastName)
        {
            TaxId = taxId;
            FirstName = firstName;
            LastName = lastName;
        }

        public abstract string GetOfficialDuties();

        //Personnel Number is unique throughout the university for each employee,
        //however each employee may have several roles (e.g. a Teacher and a Rector);
        //In that case these objects are NOT regarded as Equal.
        
        public override bool Equals(object item)
        {
            if (item == null || item.GetType() != GetType()) return false;
            
            UniversityEmployee check = (UniversityEmployee)item;

            return check.TaxId == TaxId;
        }
        public int GetNameLength()
        {
            return (this.FirstName.Length + this.LastName.Length);
        }
        

        public int CompareTo(object? obj)
        {
            return this.GetNameLength().CompareTo((obj as UniversityEmployee)?.GetNameLength());
        }


    }
}
