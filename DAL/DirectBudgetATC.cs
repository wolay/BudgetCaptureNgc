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
    
    public partial class DirectBudgetATC
    {
        public int ID { get; set; }
        public string ATCBatchId { get; set; }
        public Nullable<int> BudgetItemId { get; set; }
        public string BudgetItem { get; set; }
        public Nullable<decimal> ATCAmount { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
