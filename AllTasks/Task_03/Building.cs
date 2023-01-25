namespace Task_03
{
    internal class Building: Asset
    {
        public string InventoryNumber { get; set; }
        public Address Address { get; set; }
        public List<Room> Rooms { get; set; }

        public Building(string title, string inventoryNumber, Address address, List<Room> rooms)
            : base(title)
        {
            InventoryNumber = inventoryNumber;
            Address = address;
            Rooms = rooms;
        }

        public override string ToString()
        {
            return $"{this.Title}, {this.InventoryNumber}, {this.Address}";
        }

        public override bool Equals(object item)
        {
            if (item == null || item.GetType() != typeof(Building)) return false;
            
            Building check = (Building)item;

            return check.InventoryNumber == this.InventoryNumber;
        }
    }
}
