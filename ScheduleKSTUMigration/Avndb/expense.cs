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
    
    public partial class expense
    {
        public int id_expense { get; set; }
        public int pe { get; set; }
        public Nullable<int> id_student { get; set; }
        public Nullable<int> id_teacher { get; set; }
        public Nullable<int> id_abiturient { get; set; }
        public string dopol { get; set; }
        public Nullable<int> id_faculty { get; set; }
        public string osnovanie { get; set; }
        public string primech { get; set; }
        public Nullable<int> id_speciality { get; set; }
        public Nullable<int> id_rate { get; set; }
        public Nullable<int> id_group { get; set; }
        public Nullable<int> id_a_year { get; set; }
        public Nullable<int> id_uslug { get; set; }
        public Nullable<int> id_payment { get; set; }
        public double p102 { get; set; }
        public System.DateTime p103 { get; set; }
        public int p104 { get; set; }
        public string p104_1 { get; set; }
        public int id_v_opl { get; set; }
        public Nullable<System.DateTime> data_prikaz { get; set; }
        public string dop_info { get; set; }
        public string num_prikaz { get; set; }
        public Nullable<bool> Onul { get; set; }
        public string oper { get; set; }
        public Nullable<System.DateTime> u_date { get; set; }
        public string AVN_user { get; set; }
        public Nullable<System.DateTime> AVN_update { get; set; }
        public int id_kassa { get; set; }
        public Nullable<int> id_slushatel { get; set; }
        public Nullable<int> id_group_slushatel { get; set; }
    }
}
