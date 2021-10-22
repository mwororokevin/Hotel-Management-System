using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_PMS.Models
{
    public class HotelRoom
    {   
        [Key]
        public int Id { get; set; }

        public string RoomNumber { get; set; }

        public string OccupancyStatus { get; set; }

        public string SmokingStatus { get; set; }
    }
}
