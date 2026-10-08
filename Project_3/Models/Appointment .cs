using System;
using System.Collections.Generic;
using System.Text;

namespace Project_3.Models
{
    public class Appointment
    {
        public DateTime AppointmentDate { get; set; }

        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}
