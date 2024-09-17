using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Appointment : BaseEntity
    {
        public DateTime AppintmentDataTime { get; set; }  //Time slot booked

        public int ClientId { get; set; }  // Foreign Key
        public Client Client { get; set; }  // Navigation Property
        public int? VetId { get; set; }  // Nullable Foreign Key (either a Vet or Grooming)
        public Vet Vet { get; set; }  // Navigation Property
        public int? GroomingId { get; set; }  // Nullable Foreign Key
        public Grooming Grooming { get; set; }  // Navigation Property

    }
}
