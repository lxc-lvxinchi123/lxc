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
    
    public partial class CMRC_Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CMRC_Products()
        {
            this.CMRC_Reviews = new HashSet<CMRC_Reviews>();
            this.CMRC_ShoppingCart = new HashSet<CMRC_ShoppingCart>();
        }
    
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ModelNumber { get; set; }
        public string ModelName { get; set; }
        public string ProductImage { get; set; }
        public decimal UnitCost { get; set; }
        public string Description { get; set; }
    
        public virtual CMRC_Categories CMRC_Categories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CMRC_Reviews> CMRC_Reviews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CMRC_ShoppingCart> CMRC_ShoppingCart { get; set; }
    }
}
