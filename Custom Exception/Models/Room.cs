namespace Custom_Exception.Models
{
    public class Room
    {
        private static int _idcounter=0;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; }

        public Room(string name, double price, int personcapacity)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("ad bosh ola bilmez",nameof (name));
            if (price <= 0)
                throw new ArgumentException("menfi ola bilmez", nameof(price));
            if (personcapacity <= 0)
                throw new ArgumentException("menfi ola bilmez", nameof (personcapacity));

            Id=_idcounter++;
            Name = name;
            Price = price;
            PersonCapacity = personcapacity;
            IsAvailable = true;

        }
        public string ShowInfo()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}, " +
                   $"PersonCapacity: {PersonCapacity}, IsAvailable: {IsAvailable}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }

    }
}
