//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LogiManage.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StockAdjustmentRequests
    {
        public int StockAdjustmentID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> WarehouseID { get; set; }
        public Nullable<int> ExpectedQuantity { get; set; }
        public Nullable<int> CurrentQuantity { get; set; }
        public string AdjustmentRStatus { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
    
        public virtual Products Products { get; set; }
        public virtual Warehouses Warehouses { get; set; }
    }
}
