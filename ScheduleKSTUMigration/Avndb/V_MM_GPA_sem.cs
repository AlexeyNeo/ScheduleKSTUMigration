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
    
    public partial class V_MM_GPA_sem
    {
        public int id_group { get; set; }
        public int id_student { get; set; }
        public Nullable<double> chislitel { get; set; }
        public Nullable<int> znamenatel { get; set; }
        public Nullable<double> GPA { get; set; }
        public Nullable<int> DOLG { get; set; }
        public int id_semester { get; set; }
    }
}
