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
    
    public partial class DirectBudget
    {
        public int ID { get; set; }
        public Nullable<int> DirectItemID { get; set; }
        public Nullable<int> BudgetYrID { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Justification { get; set; }
        public string AddeBy { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
        public string ApprovedBy { get; set; }
        public Nullable<System.DateTime> DateApproved { get; set; }
        public Nullable<int> Status { get; set; }
        public string EDApprover { get; set; }
        public string MDApprover { get; set; }
        public Nullable<System.DateTime> EDApprovalDate { get; set; }
        public Nullable<System.DateTime> MDApprovalDate { get; set; }
        public Nullable<bool> ATCApproved { get; set; }
        public string ATCBatchID { get; set; }
        public Nullable<int> ATCStatus { get; set; }
        public Nullable<decimal> ATCAmount { get; set; }
    
        public virtual BudgetYear BudgetYear { get; set; }
        public virtual Department Department { get; set; }
        public virtual DirectExpenseItem DirectExpenseItem { get; set; }
    }
}
