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
    
    public partial class movement_t_k
    {
        public int id_protocols { get; set; }
        public int id_group { get; set; }
        public int id_student { get; set; }
        public int id_rate { get; set; }
        public int id_semester { get; set; }
        public int id_bk { get; set; }
        public int id_come { get; set; }
        public string come_reg { get; set; }
        public Nullable<System.DateTime> come_date { get; set; }
        public string come_k { get; set; }
        public Nullable<int> id_speciality { get; set; }
        public int id_leave { get; set; }
        public string leave_reg { get; set; }
        public Nullable<System.DateTime> leave_date { get; set; }
        public string leave_k { get; set; }
        public string oper { get; set; }
        public Nullable<System.DateTime> u_date { get; set; }
        public string AVN_user { get; set; }
        public Nullable<System.DateTime> AVN_update { get; set; }
    }
}
