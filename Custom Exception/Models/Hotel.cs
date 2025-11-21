using System.Security.Cryptography.X509Certificates;

namespace Custom_Exception.Models
{
    public class Hotel
    {
        public string Name { get; set; }
        private Room[] _rooms;
        public Hotel(string name) 
        {
            if (name == null)                     
                throw new ArgumentNullException("Ad bosh ola bilmez", nameof(name));

            Name = name;
            _rooms = new Room[0];

        }
        public void AddRoom(Room room)
        {
            if (room == null)
            {
                throw new ArgumentNullException("bosh ola bilmez", nameof(room));
            }
            _rooms[0] = room;
        }

    }
}
