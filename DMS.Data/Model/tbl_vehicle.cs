//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DMS.Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_vehicle
    {
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public string VehicleName { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
    
        public virtual tbl_cutomer tbl_cutomer { get; set; }
    }
}