namespace HotelManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<HotelRoom> yananRooms = new List<HotelRoom>();
            HotelRoom room1 = new HotelRoom(101, RoomStyles.TwinRoom, 1500);
            HotelRoom room2 = new HotelRoom(102, RoomStyles.KingRoom, 3000);
            yananRooms.Add(room1);
            yananRooms.Add(room2);

            Hotel hotelYanan = new Hotel("Yanan", "123 Street", yananRooms);
            hotelYanan.DisplayAvailableRooms();

            HotelManagementSystem hms = new HotelManagementSystem();
            hms.AddHotel(hotelYanan);
            hms.DisplayHotels();

            Guest pj = new Guest("Pj", "BGC", "pj@email.com", "6389201");
            hms.Register(pj);

            pj.BookReservation(hotelYanan, room1, DateTime.Now, new DateTime(2024, 04, 16));
            hotelYanan.DisplayBookedRooms();

            hms.DisplayReservationDetails(1234567890) ;
            pj.DisplayReservations();
        }
    }
}
