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
    
    public partial class Visitings
    {
        public int id_visitings { get; set; }
        public Nullable<int> id_a_year { get; set; }
        public Nullable<byte> monthID { get; set; }
        public Nullable<byte> dayID { get; set; }
        public Nullable<int> id_student { get; set; }
        public Nullable<int> id_group { get; set; }
        public Nullable<int> id_discipline { get; set; }
        public Nullable<bool> was { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<bool> hasSpravka { get; set; }
        public string descr { get; set; }
    }
}