using System.Security.Cryptography.X509Certificates;

namespace Custom_Exception.Models
{
    public class Hotel
    {
        public string Name { get; set; }
        public Room[] _rooms;
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
            Array.Resize(ref _rooms, _rooms.Length+1);
            _rooms[_rooms.Length-1] = room;
        }
        public void Reserve(int? roomId)
        {
            if (roomId == null) throw new ArgumentNullException();

            Room found = null;
            foreach (var room in _rooms)
                if (room.Id == roomId)
                    found = room;

            if (found == null)
                throw new NotFoundException($"Room {roomId} tapılmadı");

            if (!found.IsAvailable)
                throw new NotAvailableException($"Room {roomId} artıq rezerv olunub");

            found.IsAvailable = false;

        }
        public Room this[int index]
        {
            get => _rooms[index];
            set => _rooms[index] = value;
        }
    }
}
