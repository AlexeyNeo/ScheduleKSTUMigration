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
    
    public partial class T_AvnLog
    {
        public long id_avnLog { get; set; }
        public int id_human { get; set; }
        public int id_humanType { get; set; }
        public int id_logAction { get; set; }
        public string tableName { get; set; }
        public string fieldName { get; set; }
        public long id_key { get; set; }
        public string logMessage { get; set; }
        public System.DateTime created { get; set; }
    }
}
