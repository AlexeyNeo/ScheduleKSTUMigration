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
    
    public partial class University
    {
        public int IDUniversity { get; set; }
        public string NameUniversity { get; set; }
        public Nullable<short> RegionUniversity { get; set; }
        public Nullable<short> DistrictUniversity { get; set; }
        public Nullable<int> CityUniversity { get; set; }
        public Nullable<int> VillageUniversity { get; set; }
        public string StreetUniversity { get; set; }
        public string TelephoneUniversity { get; set; }
        public string FaxUniversity { get; set; }
        public string RectorSurname { get; set; }
        public string RectorName { get; set; }
        public string RectorPatronymic { get; set; }
        public string AVN_user { get; set; }
        public Nullable<System.DateTime> AVN_update { get; set; }
    }
}
