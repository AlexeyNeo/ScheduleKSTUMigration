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
    
    public partial class ReceptInfo
    {
        public int IDStudent { get; set; }
        public bool Recepted { get; set; }
        public Nullable<bool> OrderRecept { get; set; }
        public string NumberOrder { get; set; }
        public Nullable<System.DateTime> DateOrder { get; set; }
        public string NumberProtocol { get; set; }
        public Nullable<System.DateTime> DateProtocol { get; set; }
        public Nullable<int> Faculties { get; set; }
        public Nullable<bool> not_came { get; set; }
        public Nullable<int> Directions { get; set; }
        public Nullable<int> temp_abit_spec { get; set; }
        public Nullable<int> Speciality { get; set; }
        public Nullable<bool> test_failed { get; set; }
        public string RegNum { get; set; }
        public Nullable<bool> DayForm { get; set; }
        public byte tour { get; set; }
        public bool Recom_for_reccept { get; set; }
        public Nullable<byte> C__Recom_num { get; set; }
        public Nullable<System.DateTime> Recom_date { get; set; }
        public string Recom_protokol { get; set; }
        public Nullable<System.DateTime> DateResept { get; set; }
        public Nullable<System.DateTime> DateDeliveryDoc { get; set; }
        public bool confirm_date_for_reccept { get; set; }
        public Nullable<bool> LanguageRus { get; set; }
        public short FormContract { get; set; }
        public Nullable<int> Payment_fr_kass { get; set; }
        public Nullable<System.DateTime> DatePayment_fr_kass { get; set; }
        public Nullable<int> Payment { get; set; }
        public Nullable<System.DateTime> DatePayment { get; set; }
        public Nullable<int> id_category { get; set; }
        public Nullable<System.DateTime> category_date { get; set; }
        public bool Takebackdocs { get; set; }
        public Nullable<System.DateTime> Takebackdocsdate { get; set; }
        public Nullable<System.DateTime> DateReg { get; set; }
        public string AVN_user { get; set; }
        public Nullable<System.DateTime> AVN_update { get; set; }
        public string AVN_User_Update { get; set; }
        public bool Pay { get; set; }
        public int ResultSobesedovania { get; set; }
        public bool ORT_AfterTehnicum { get; set; }
        public Nullable<double> atestat { get; set; }
        public Nullable<double> atestat_exzamen { get; set; }
    }
}