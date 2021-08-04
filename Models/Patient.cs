using System;
using System.Collections.Generic;


#nullable disable

namespace Salud.Web.App.Models
{
    public partial class Patient
    {
        public Patient()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Dni { get; set; }
        public DateTime DateBirth { get; set; }
        public string NumberPhone { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HealthInsurance { get; set; }
        public string Disease { get; set; }
        public string AllergicMedicine { get; set; }
        public bool? SendEmailConfirmed { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
