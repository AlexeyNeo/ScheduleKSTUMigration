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
    
    public partial class ParentsInfo
    {
        public int id_parentsInfo { get; set; }
        public int IDStudent { get; set; }
        public string SurnameFather { get; set; }
        public string NameFather { get; set; }
        public string PatronymicFather { get; set; }
        public string PlaceJobFather { get; set; }
        public string PostFather { get; set; }
        public string SurnameMother { get; set; }
        public string NameMother { get; set; }
        public string PatronymicMother { get; set; }
        public string PlaceJobMother { get; set; }
        public string PostMother { get; set; }
        public Nullable<int> id_reoublicParents { get; set; }
        public Nullable<int> RegionHomeAddress { get; set; }
        public Nullable<int> DistrictHomeAddress { get; set; }
        public Nullable<int> CityHomeAddress { get; set; }
        public Nullable<int> VillageHomeAddress { get; set; }
        public string StreetHomeAddress { get; set; }
        public string TelephoneHomeAddress { get; set; }
        public string AVN_user { get; set; }
        public Nullable<System.DateTime> AVN_update { get; set; }
        public string E_MailFather { get; set; }
        public string TelephoneFather { get; set; }
        public string E_MailMother { get; set; }
        public string TelephoneMother { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
