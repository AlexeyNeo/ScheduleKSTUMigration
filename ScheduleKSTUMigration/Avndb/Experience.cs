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
    
    public partial class Experience
    {
        public int id_experience { get; set; }
        public string specialty { get; set; }
        public Nullable<double> Gov_Service { get; set; }
        public Nullable<double> On_Owners { get; set; }
        public Nullable<double> specialty_s { get; set; }
        public Nullable<double> Total_s { get; set; }
        public Nullable<double> Unbreakable { get; set; }
        public Nullable<int> id_teacher { get; set; }
        public string AVN_user { get; set; }
        public Nullable<System.DateTime> AVN_update { get; set; }
        public Nullable<double> teacher_s { get; set; }
        public Nullable<System.DateTime> Total_sDate { get; set; }
        public Nullable<System.DateTime> teacher_sDate { get; set; }
        public string vis_gor { get; set; }
    
        public virtual teacher teacher { get; set; }
    }
}
