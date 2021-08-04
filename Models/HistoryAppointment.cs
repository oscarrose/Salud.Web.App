using System;
using System.Collections.Generic;

#nullable disable

namespace Salud.Web.App.Models
{
    public partial class HistoryAppointment
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public int? DurationAppointmentMinutes { get; set; }
        public string CommentAppointment { get; set; }

        public virtual Appointment Appointment { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
