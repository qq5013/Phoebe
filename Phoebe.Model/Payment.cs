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
    
    public partial class Payment
    {
        public System.Guid Id { get; set; }
        public int CustomerId { get; set; }
        public decimal PaidFee { get; set; }
        public System.DateTime PaidTime { get; set; }
        public int UserId { get; set; }
        public string Remark { get; set; }
        public int Status { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual User User { get; set; }
    }
}
