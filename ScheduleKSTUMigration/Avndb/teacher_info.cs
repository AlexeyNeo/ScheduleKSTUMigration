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
    
    public partial class teacher_info
    {
        public int id_teacher_info { get; set; }
        public int id_teacher { get; set; }
        public Nullable<int> id_uch_stepen { get; set; }
        public Nullable<int> id_uch_zvanie { get; set; }
        public Nullable<System.DateTime> D_b { get; set; }
        public string Phon_w { get; set; }
        public string Phone { get; set; }
        public string phone_mobile { get; set; }
        public Nullable<System.DateTime> D_z { get; set; }
        public Nullable<int> id_nationality { get; set; }
        public Nullable<int> id_citizenship { get; set; }
        public Nullable<int> id_pol { get; set; }
        public string nauch_r { get; set; }
        public Nullable<int> id_rang { get; set; }
        public Nullable<int> id_soc_pr { get; set; }
        public string AVN_user { get; set; }
        public Nullable<System.DateTime> AVN_update { get; set; }
        public string eMail { get; set; }
        public string first_p26 { get; set; }
        public string num_date_f_p26 { get; set; }
    
        public virtual Nationality Nationality { get; set; }
        public virtual pol pol { get; set; }
        public virtual Rang Rang { get; set; }
        public virtual Soc_pr Soc_pr { get; set; }
        public virtual teacher teacher { get; set; }
        public virtual uch_step uch_step { get; set; }
        public virtual uch_zvanie uch_zvanie { get; set; }
    }
}
