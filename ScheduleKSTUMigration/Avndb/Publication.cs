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
    
    public partial class Publication
    {
        public int id_publication { get; set; }
        public int id_publicationType { get; set; }
        public string theme { get; set; }
        public Nullable<System.DateTime> PublicationDate { get; set; }
        public int id_teacher { get; set; }
        public Nullable<int> Pages { get; set; }
        public string Primech { get; set; }
    }
}
