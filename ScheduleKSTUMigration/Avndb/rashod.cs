//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScheduleKSTUMigration.Avndb
{
    using System;
    using System.Collections.Generic;
    
    public partial class rashod
    {
        public int id_rashod { get; set; }
        public int id_student { get; set; }
        public Nullable<int> id_teacher { get; set; }
        public int id_faculty { get; set; }
        public string osnovanie { get; set; }
        public Nullable<int> id_usluga_rashod { get; set; }
        public double summa { get; set; }
        public System.DateTime date_r { get; set; }
        public Nullable<int> ord_f { get; set; }
        public int id_v_opl { get; set; }
        public string dopol { get; set; }
        public string oper { get; set; }
        public Nullable<System.DateTime> u_date { get; set; }
        public string AVN_user { get; set; }
        public Nullable<System.DateTime> AVN_update { get; set; }
    }
}