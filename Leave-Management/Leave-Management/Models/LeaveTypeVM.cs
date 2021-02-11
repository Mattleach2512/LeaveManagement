using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management.Models
{
    public class LeaveTypeVM
    {

        public int Id { get; set; }
        [Required]
  
        public string Name { get; set; }
        
        [Required]
        [Range(1,25, ErrorMessage = "The maximum amount of days is 25")]
        [DisplayName("Default number of days")]
        public int DefaultDays { get; set; }
        [Display(Name = "Date Created")]
        public DateTime? DateCreated { get; set; }
    }
   
}
