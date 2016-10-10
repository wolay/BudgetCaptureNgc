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
    
    public partial class MonthOfYear
    {
        public MonthOfYear()
        {
            this.ExpenseProjections = new HashSet<ExpenseProjection>();
            this.AssetBudgets = new HashSet<AssetBudget>();
            this.RevenueProjections = new HashSet<RevenueProjection>();
            this.GSS_Invoice = new HashSet<GSS_Invoice>();
        }
    
        public int ID { get; set; }
        public string MonthName { get; set; }
        public Nullable<int> MonthNumber { get; set; }
    
        public virtual ICollection<ExpenseProjection> ExpenseProjections { get; set; }
        public virtual ICollection<AssetBudget> AssetBudgets { get; set; }
        public virtual ICollection<RevenueProjection> RevenueProjections { get; set; }
        public virtual ICollection<GSS_Invoice> GSS_Invoice { get; set; }
    }
}
