﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Pet : BaseEntity
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Sex { get; set; }

        //Relation to Owner
        public Guid OwnerId { get; set; }
        public Owner Owner { get; set; }
        //Relation to Appointment
        public ICollection<Appointment> Appointments { get; set; }
        //Relation to MedicalRecord
        public ICollection<MedicalRecord> MedicalRecords { get; set; }
    }
}
