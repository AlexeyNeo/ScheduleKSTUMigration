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
    
    public partial class Holiday
    {
        public int id_vacation { get; set; }
        public Nullable<int> id_teacher { get; set; }
        public Nullable<int> id_vacation_t { get; set; }
        public Nullable<System.DateTime> from_d { get; set; }
        public Nullable<System.DateTime> to_d { get; set; }
        public Nullable<System.DateTime> Date_begin { get; set; }
        public Nullable<System.DateTime> Date_End { get; set; }
        public Nullable<int> n_days { get; set; }
        public string n_prikaz { get; set; }
        public Nullable<System.DateTime> date_prikaz { get; set; }
        public Nullable<System.DateTime> otz_from_d { get; set; }
        public string otz_prik { get; set; }
        public Nullable<System.DateTime> otz_pr_date { get; set; }
        public Nullable<int> not_used_days { get; set; }
        public Nullable<int> not_used_pay_days { get; set; }
        public string AVN_user { get; set; }
        public Nullable<System.DateTime> AVN_update { get; set; }
    
        public virtual Holliday_t Holliday_t { get; set; }
        public virtual teacher teacher { get; set; }
    }
}
