using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Guest : Users
    {
        public List<Reservation> Reservations { get; set; }

        public Guest(string name, string address, string email, string phoneNumber) : base(name,address, email, phoneNumber)
        {
            Reservations = new List<Reservation>();
        }
        public void BookReservation(Hotel hotel, HotelRoom room, DateTime startTime, DateTime endTime)
        {
            Reservation reservation = new Reservation(startTime, endTime, room);
            hotel.Reservations.Add(reservation);
            Reservations.Add(reservation);
        }
        public void DisplayReservations()
        {
            Console.WriteLine($"List of Reservations of {Name}: ");
            foreach (var reservation in Reservations)
            {
                Console.WriteLine($" {reservation}");
            }
        }
    }
}   
