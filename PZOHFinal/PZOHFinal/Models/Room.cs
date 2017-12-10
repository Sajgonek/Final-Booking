using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PZOHFinal.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int NumOfBeds { get; set; }
        public RoomType RoomType { get; set; }
        public byte RoomTypeId { get; set; }
    }
}