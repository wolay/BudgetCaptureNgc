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
    
    public partial class AssetType
    {
        public AssetType()
        {
            this.Assets = new HashSet<Asset>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string GLCode { get; set; }
        public Nullable<bool> isActive { get; set; }
    
        public virtual ICollection<Asset> Assets { get; set; }
    }
}
