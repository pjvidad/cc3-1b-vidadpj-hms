using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Reservation
    {

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public HotelRoom Room { get; set; }

        public Reservation(DateTime startTime, DateTime endTime, HotelRoom room)
        {
            StartTime = startTime;
            EndTime = endTime;
            Room = room;
        }

        public int DurationDays()
        {
            return (EndTime - StartTime).Days;
        }
        public int TotalPrice()
        {
            int duration = DurationDays();
            return duration * Room.Price;
        }
        public override string ToString()
        {
            return $"Start Time: {StartTime}, End Time: {EndTime}, Duration: {DurationDays}, Total: {TotalPrice()}";
        }
    }
}