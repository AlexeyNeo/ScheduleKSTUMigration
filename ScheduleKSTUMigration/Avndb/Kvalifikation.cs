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
    
    public partial class Kvalifikation
    {
        public int id_kvalification { get; set; }
        public Nullable<int> kvalifikation1 { get; set; }
        public string place { get; set; }
        public Nullable<int> id_trudoem { get; set; }
        public string sertifikate { get; set; }
        public Nullable<int> id_teacher { get; set; }
        public Nullable<System.DateTime> date_1 { get; set; }
        public Nullable<System.DateTime> date_2 { get; set; }
        public string AVN_user { get; set; }
        public Nullable<System.DateTime> AVN_update { get; set; }
        public string theme { get; set; }
    
        public virtual teacher teacher { get; set; }
    }
}
