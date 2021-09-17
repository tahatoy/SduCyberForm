using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SduCyberForm.Models
{
    public class CyberForm
    {
        [Key]
        public int Id { get; set; }

        //[Required]
        public string UnitName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Degree { get; set; }
        public int TelNo { get; set; }
        public string Email { get; set; }
        public bool EventType { get; set; }
        public bool SysOutage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DetectionDate { get; set; }
        public string Etc { get; set; }

    }
}
