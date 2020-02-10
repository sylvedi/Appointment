using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Appointment.Models
{
    public class AppointmentModel
    {
        [Required]
        [StringLength(20, MinimumLength =4)]
        [DisplayName("Patient's full name: ")]
        public string patientName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Choose a visit date: ")]
        public DateTime appointmentDate { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("Networth: ")]
        public decimal patientNetworth { get; set; }


        [DisplayName("Recommended doctor: ")]
        public string doctorLastName { get; set; } = "CHamBerger";

        [Required]
        [Range(1, 10)]
        [DisplayName("pain level (0-10): ")]
        public int currentPainLevel { get; set; }

        public AppointmentModel(string patientName, DateTime appointmentDate, 
            decimal patientNetworth, string doctorLastName, int currentPainLevel)
        {
            this.patientName = patientName;
            this.appointmentDate = appointmentDate;
            this.patientNetworth = patientNetworth;
            this.doctorLastName = doctorLastName;
            this.currentPainLevel = currentPainLevel;
        }

        public AppointmentModel()
        {
        }
    }
}