using System;
using System.Collections.Generic;

#nullable disable

namespace Salud.Web.App.Models
{
    public partial class TranckingAppointment
    {
        public int TranckingId { get; set; }
        public int? AppointmentId { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }

        public virtual Appointment Appointment { get; set; }
    }
}
