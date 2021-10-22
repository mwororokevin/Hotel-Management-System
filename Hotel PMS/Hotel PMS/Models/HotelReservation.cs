using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_PMS.Models
{
    public class HotelReservation
    {
        [Key]
        public int Id { get; set; }

        public string RoomNumber { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int NumberOfAdults { get; set; }

        public int NumberOfChildren { get; set; }

        public string SpecialRequirements { get; set; }

        public string GuestOtherNames { get; set; }

        public string GuestSurname { get; set; }

        public string GuestSalutation { get; set; }

        public string GuestGender { get; set; }

        public DateTime GuestDOB { get; set; }

        public string GuestNationality { get; set; }

        public string GuestPassportNumber { get; set; }

        public string GuestNationalIdNumber { get; set; }

        public string GuestAddress { get; set; }

        public string GuestZIPCode { get; set; }

        public string GuestCity { get; set; }

        public string GuestCountry { get; set; }

        public string GuestEmail { get; set; }
    }
}
