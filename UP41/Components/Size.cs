//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UP41.Components
{
    using System;
    using System.Collections.Generic;
    
    public partial class Size
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> SizeValue { get; set; }
        public Nullable<int> IdUnit { get; set; }
        public Nullable<int> IdProduct { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
