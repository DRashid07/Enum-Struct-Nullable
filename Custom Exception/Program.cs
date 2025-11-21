using Custom_Exception.Models;

namespace Custom_Exception
{
    public class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room("Mahir",250,2);
            Console.WriteLine(room.ShowInfo());
            room.ToString();
            Hotel hotel = new Hotel("Rashid");
            hotel.AddRoom(room);
            hotel.Reserve(0);

        }
    }
}
