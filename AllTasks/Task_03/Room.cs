namespace Task_03
{
    internal class Room
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
    }
}
