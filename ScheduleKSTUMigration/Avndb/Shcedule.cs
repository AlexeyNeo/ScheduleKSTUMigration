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
    
    public partial class Shcedule
    {
        public int id_shcedule { get; set; }
        public Nullable<int> id_year { get; set; }
        public Nullable<int> id_ws { get; set; }
        public Nullable<int> id_semester { get; set; }
        public Nullable<int> id_discipline { get; set; }
        public Nullable<int> id_faculty { get; set; }
        public Nullable<int> id_speciality { get; set; }
        public Nullable<int> kredit { get; set; }
        public Nullable<int> id_auditorium { get; set; }
        public Nullable<int> id_nedeli { get; set; }
        public Nullable<int> id_day { get; set; }
        public Nullable<int> id_time { get; set; }
        public Nullable<int> id_teacher { get; set; }
        public Nullable<int> id_rrnk { get; set; }
        public Nullable<byte> rrnkType { get; set; }
        public Nullable<int> id_teacherOwner { get; set; }
        public Nullable<int> id_vid_zaniatiy { get; set; }
        public Nullable<System.DateTime> udate { get; set; }
    
        public virtual discipline discipline { get; set; }
        public virtual Time_ Time_ { get; set; }
    }
}
