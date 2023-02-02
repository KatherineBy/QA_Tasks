namespace Task_03
{
    public class Room
    {
        private int _number;
        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value > 0)
                {
                    _number = value;
                }
            }
        }
        private int _floor;
        public int Floor
        {
            get
            {
                return _floor;
            }
            set
            {
                if (value > 0)
                {
                    _floor = value;
                }
            }
        }
        public string Purpose { get; set; }

        public Room(int number, int floor, string purpose)
        {
            Number = number;
            Floor = floor;
            Purpose = purpose;
        }

        public override bool Equals(object item)
        {
            if (item == null || item is not Room) return false;
            
            Room check = (Room)item;
            
            return check.Number == this.Number;     
        }
    }
}
