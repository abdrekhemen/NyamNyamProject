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
    
    public partial class Dishes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dishes()
        {
            this.OrderDishes = new HashSet<OrderDishes>();
            this.StageOfCooking = new HashSet<StageOfCooking>();
        }
    
        public int dish_id { get; set; }
        public string dish_name { get; set; }
        public Nullable<int> base_servings_count { get; set; }
        public Nullable<int> category_id { get; set; }
        public string image_path { get; set; }
        public byte[] image { get; set; }
        public string dish_description { get; set; }
        public Nullable<decimal> dish_final_price_for_client { get; set; }
        public string dish_source_link { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDishes> OrderDishes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StageOfCooking> StageOfCooking { get; set; }
    }
}
