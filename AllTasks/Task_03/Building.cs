using System.Net.Sockets;

namespace Task_03
{
    internal class Building: Asset
    {
        public string InventoryNumber { get; set; }
        public Address Adress { get; set; }
        public Room[] Rooms { get; set; }

        public Building(string inventoryNumber, string title, Address adress, Room[] rooms)
        {
            InventoryNumber = inventoryNumber;
            Title = title;
            Adress = adress;
            Rooms = rooms;
        }
    }
}
