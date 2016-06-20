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
    
    public partial class IceSale
    {
        public System.Guid Id { get; set; }
        public int CustomerId { get; set; }
        public System.Guid FlowId { get; set; }
        public System.DateTime SaleTime { get; set; }
        public int IceType { get; set; }
        public int SaleCount { get; set; }
        public decimal SaleWeight { get; set; }
        public decimal SaleFee { get; set; }
        public string Remark { get; set; }
        public int Status { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual IceFlow IceFlow { get; set; }
    }
}
