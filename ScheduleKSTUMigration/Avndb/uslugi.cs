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
    
    public partial class uslugi
    {
        public int id_uslug { get; set; }
        public string uslugi1 { get; set; }
        public Nullable<double> proc1 { get; set; }
        public Nullable<double> proc2 { get; set; }
        public Nullable<int> id_shet { get; set; }
        public string oper { get; set; }
        public System.DateTime u_date { get; set; }
        public string AVN_user { get; set; }
        public Nullable<System.DateTime> AVN_update { get; set; }
        public Nullable<float> procent { get; set; }
        public string shet { get; set; }
        public Nullable<bool> is_visible { get; set; }
        public Nullable<int> id_kassa { get; set; }
        public Nullable<int> code_pay { get; set; }
        public string @short { get; set; }
    
        public virtual shet shet1 { get; set; }
    }
}
