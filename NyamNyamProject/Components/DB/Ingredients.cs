//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NyamNyamProject.Components.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ingredients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ingredients()
        {
            this.StageIngredient = new HashSet<StageIngredient>();
        }
    
        public int ingredient_id { get; set; }
        public string ingredient_name { get; set; }
        public Nullable<decimal> ingredient_cost_per_unit { get; set; }
        public Nullable<int> ingredient_instock_count { get; set; }
        public Nullable<int> unit_id { get; set; }
    
        public virtual MainUnits MainUnits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StageIngredient> StageIngredient { get; set; }
    }
}