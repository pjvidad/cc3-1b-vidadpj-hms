using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public enum RoomStyles
    {
        TwinRoom,
        QueenRoom,
        KingRoom
    }
    public class HotelRoom
    {
        public int RoomNumber { get; set; }
        public RoomStyles Style { get; set; }
        public int Price { get; set; }

        public HotelRoom(int roomNumber, RoomStyles style, int price)
        {
            RoomNumber = roomNumber;
            Style = style;
            Price = price;
        }
    }
}
