using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDoctorManagement.Shared.Domain
{
    public class Patient : BaseDomainModel
    {
        public string Name { get; set; }
        public string PillTime { get; set; }
        public string WaterTime { get; set; }
        public string FoodRestrictions { get; set; }
    }
}
