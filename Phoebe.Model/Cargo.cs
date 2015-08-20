//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Phoebe.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cargo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cargo()
        {
            this.StockInDetails = new HashSet<StockInDetail>();
        }
    
        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public int FirstCategoryID { get; set; }
        public int SecondCategoryID { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<double> Volume { get; set; }
        public string OriginPlace { get; set; }
        public int ShelfLife { get; set; }
        public int ContractID { get; set; }
        public System.DateTime RegisterTime { get; set; }
        public int UserID { get; set; }
        public string Remark { get; set; }
        public int Status { get; set; }
    
        public virtual FirstCategory FirstCategory { get; set; }
        public virtual SecondCategory SecondCategory { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockInDetail> StockInDetails { get; set; }
        public virtual Contract Contract { get; set; }
    }
}
