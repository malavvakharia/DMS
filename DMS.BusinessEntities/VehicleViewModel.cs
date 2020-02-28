using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.BusinessEntities
{
    public class VehicleViewModel
    {
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public string VehicleName { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }

    }
}
