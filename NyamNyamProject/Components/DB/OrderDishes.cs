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
    
    public partial class OrderDishes
    {
        public int order_dish_id { get; set; }
        public Nullable<int> order_id { get; set; }
        public Nullable<int> dish_id { get; set; }
        public Nullable<int> serving_qnt { get; set; }
        public Nullable<System.DateTime> cooking_start_time { get; set; }
        public string cooking_end_time { get; set; }
    
        public virtual Dishes Dishes { get; set; }
        public virtual Order Order { get; set; }
    }
}
