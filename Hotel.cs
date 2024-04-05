using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Hotel
    {
        public string HotelName { get; set; }
        public string Location { get; set; }
        public List<HotelRoom> Rooms { get; set; }
        public List<Reservation> Reservations { get; set; } 
        public Hotel(string hotelName, string location, List<HotelRoom> rooms)
        {
            HotelName = hotelName;
            Location = location;
            Rooms = rooms;
            Reservations = new List<Reservation>();
        }

        public void DisplayBookedRooms()
        {
            Console.WriteLine($"Booked Rooms at {HotelName}, {Location}: ");
            foreach (var reservation in Reservations)
            {
                Console.WriteLine($"Room {reservation.Room.RoomNumber}, Style: {reservation.Room.Style}, Price: {reservation.Room.Price}");
            }
        }

        public void DisplayAvailableRooms()
        {
            Console.WriteLine($"Available Rooms at {HotelName}, {Location}: ");
            foreach (var room in Rooms)
            {
                Console.WriteLine($"Room {room.RoomNumber}, Style: {room.Style}, Price: {room.Price}");
            }

        }
    }
}
