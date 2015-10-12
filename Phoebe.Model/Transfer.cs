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
    
    public partial class Transfer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transfer()
        {
            this.TransferDetails = new HashSet<TransferDetail>();
        }
    
        public System.Guid ID { get; set; }
        public System.Guid OldCargoID { get; set; }
        public System.Guid NewCargoID { get; set; }
        public System.DateTime TransferTime { get; set; }
        public Nullable<System.DateTime> ConfirmTime { get; set; }
        public int UserID { get; set; }
        public string Remark { get; set; }
        public int Status { get; set; }
    
        public virtual Cargo OldCargo { get; set; }
        public virtual Cargo NewCargo { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransferDetail> TransferDetails { get; set; }
    }
}