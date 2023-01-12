namespace Task_03
{
    internal class Building: Asset
    {
        public string InventoryNumber { get; set; }
        public Address Adress { get; set; }
        public Room[] Rooms { get; set; }

        public Building(string title, string inventoryNumber, Address adress, Room[] rooms)
            : base(title)
        {
            InventoryNumber = inventoryNumber;
            Adress = adress;
            Rooms = rooms;
        }
    }
}
