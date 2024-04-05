﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class HotelManagementSystem
    {
        
        private List<Hotel> hotels;
        private List<Users> users;

        public HotelManagementSystem()
        {
            hotels = new List<Hotel>();
            users = new List<Users>();
        }

        public void AddHotel(Hotel hotel)
        {
            hotels.Add(hotel);
        }
        public void DisplayHotels()
        {
            Console.WriteLine("List of Hotels:");
            foreach (var hotel in hotels)
            {
                Console.WriteLine($" {hotel.HotelName}, {hotel.Location}");
            }
        }
        public void Register(Users user)
        {
            users.Add(user);
        }
        private static int s_ReservationIDseed = 0123456;

        public void DisplayReservationDetails()
        {
            foreach (var user in users)
            {
                if (user is Guest guest)
                {
                    foreach (var reservation in guest.Reservations)
                    {
                        int ReservationID = s_ReservationIDseed++;
                    }
                }
            }
        }
    }
}
