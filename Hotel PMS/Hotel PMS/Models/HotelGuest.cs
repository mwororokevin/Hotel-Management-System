using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Hotel_PMS.Models
{
    public class HotelGuest
    {   
        [Key]
        public int Id { get; set; }

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

        public int NumberOfAdults { get; set; }

        public int NumberOfChildren { get; set; }

        public DateTime GuestArrivalDate { get; set; }

        public DateTime GuestDepartureDate { get; set; }
    }
}
