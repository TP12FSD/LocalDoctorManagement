using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDoctorManagement.Shared.Domain
{
    public class Patient : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name does not meet length requirements")]
        public string Name { get; set; }
        [Required]
        public string PillTime { get; set; }
        [Required]
        public string WaterTime { get; set; }
        [Required]
        public string FoodRestrictions { get; set; }
    }
}
