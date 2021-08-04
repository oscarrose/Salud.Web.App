using System;
using System.Collections.Generic;

#nullable disable

namespace Salud.Web.App.Models
{
    public partial class Appointment
    {
        public Appointment()
        {
            TranckingAppointments = new HashSet<TranckingAppointment>();
        }

        public int AppointmentId { get; set; }
        public string AccountDoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime DateAppointments { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public bool? SendEmailConfirmed { get; set; }

        public virtual AspNetUser AccountDoctor { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual ICollection<TranckingAppointment> TranckingAppointments { get; set; }
    }
}
