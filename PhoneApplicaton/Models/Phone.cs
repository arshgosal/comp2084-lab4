using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PhoneApplicaton.Models
{
    public class Phone
    {
        public Phone()
        {
            PhoneID = 0;
            PhoneName = "";
            MSRP = 0;
            ScreenSize = 0;
            DateReleased = DateTime.Now;
        }
        [Key]
        public int PhoneID { get; set; }
        public string PhoneName { get; set; }
        
        public virtual Manufacturer Manufacturer { get; set; }
        public double MSRP { get; set; }
        [ForeignKey("Manufacturer")]
        public int ManufacturerID { get; set; }
        public double ScreenSize { get; set; }
        public DateTime DateReleased { get; set; }
    }
}