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
    
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.OrderDetails = new HashSet<OrderDetails>();
            this.ProductMovements = new HashSet<ProductMovements>();
            this.WarehouseStocks = new HashSet<WarehouseStocks>();
            this.WarehouseTransfers = new HashSet<WarehouseTransfers>();
        }
    
        public string ProductName { get; set; }
        public string Category { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> StockQuantity { get; set; }
        public Nullable<int> CriticalStockLevel { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public int ProductID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductMovements> ProductMovements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WarehouseStocks> WarehouseStocks { get; set; }
        public virtual Suppliers Suppliers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WarehouseTransfers> WarehouseTransfers { get; set; }
    }
}
