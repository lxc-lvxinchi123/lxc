//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CMRC_ShoppingCart
    {
        public int RecordID { get; set; }
        public string CartID { get; set; }
        public int Quantity { get; set; }
        public int ProductID { get; set; }
        public System.DateTime DateCreated { get; set; }
    
        public virtual CMRC_Products CMRC_Products { get; set; }
    }
}
