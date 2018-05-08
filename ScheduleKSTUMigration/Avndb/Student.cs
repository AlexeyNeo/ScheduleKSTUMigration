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
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.movement_t = new HashSet<movement_t>();
            this.InfoOnEdIns = new HashSet<InfoOnEdIns>();
        }
    
        public int id_student { get; set; }
        public Nullable<int> nenujen { get; set; }
        public string idid { get; set; }
        public string first_p1 { get; set; }
        public string num_date_f_p1 { get; set; }
        public string p1 { get; set; }
        public string p2 { get; set; }
        public string place_work { get; set; }
        public string p3 { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public bool Male { get; set; }
        public Nullable<bool> Lonely { get; set; }
        public Nullable<bool> Orphan { get; set; }
        public Nullable<bool> Invalid12Group { get; set; }
        public Nullable<int> id_republicBirth { get; set; }
        public int RegionBirth { get; set; }
        public int DistrictBirth { get; set; }
        public int CityBirth { get; set; }
        public int VillageBirth { get; set; }
        public string Streetbirth { get; set; }
        public Nullable<int> id_republicHome { get; set; }
        public int RegionHomeAddress { get; set; }
        public int DistrictHomeAddress { get; set; }
        public int CityHomeAddress { get; set; }
        public int VillageHomeAddress { get; set; }
        public string StreetHomeAddress { get; set; }
        public string adrhome { get; set; }
        public string TelephoneHomeAddress { get; set; }
        public Nullable<int> id_republicNow { get; set; }
        public int RegionNow { get; set; }
        public int DistrictNow { get; set; }
        public int CityNow { get; set; }
        public Nullable<int> VillageNow { get; set; }
        public string StreetNow { get; set; }
        public string adrnow { get; set; }
        public string TelephoneNow { get; set; }
        public string SerialPas { get; set; }
        public string NumberPas { get; set; }
        public Nullable<System.DateTime> DateGivenPas { get; set; }
        public Nullable<int> GivenPas { get; set; }
        public int Nationality { get; set; }
        public Nullable<int> first_Citizenship { get; set; }
        public string num_date_f_Citizenship { get; set; }
        public Nullable<bool> ItnGyrg { get; set; }
        public int Citizenship { get; set; }
        public Nullable<int> id_a_year { get; set; }
        public Nullable<int> id_ws { get; set; }
        public string DateRegistr { get; set; }
        public Nullable<int> FacultiesReg { get; set; }
        public Nullable<bool> Dipend { get; set; }
        public string e_mail { get; set; }
        public string lang { get; set; }
        public string hobby { get; set; }
        public string religion { get; set; }
        public string visitKG { get; set; }
        public string aids { get; set; }
        public string AVN_user { get; set; }
        public Nullable<System.DateTime> AVN_update { get; set; }
        public Nullable<int> temp { get; set; }
        public string ZACH { get; set; }
        public string inn { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public bool needChangePsw { get; set; }
        public System.DateTime startDateForChangePsw { get; set; }
        public Nullable<byte> kol_p { get; set; }
        public Nullable<System.DateTime> endDateViza { get; set; }
        public Nullable<bool> needHome { get; set; }
        public string host { get; set; }
        public string smsAccountFromAbit { get; set; }
        public string Attribute { get; set; }
        public string op { get; set; }
        public Nullable<byte> FlagForMobile { get; set; }
        public string ist { get; set; }
    
        public virtual MilitaryInfo MilitaryInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<movement_t> movement_t { get; set; }
        public virtual ParentsInfo ParentsInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoOnEdIns> InfoOnEdIns { get; set; }
    }
}