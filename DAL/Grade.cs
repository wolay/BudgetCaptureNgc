//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BudgetCapture.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grade
    {
        public Grade()
        {
            this.ExistingStaffs = new HashSet<ExistingStaff>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> CostPerMonth { get; set; }
        public Nullable<decimal> CostPerYear { get; set; }
        public Nullable<bool> isActive { get; set; }
    
        public virtual ICollection<ExistingStaff> ExistingStaffs { get; set; }
    }
}