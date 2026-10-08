using System;
using System.Collections.Generic;
using System.Text;

namespace Project_3.Models
{
    public  class Patient
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    }
}
