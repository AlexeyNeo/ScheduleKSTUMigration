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
    
    public partial class T_Exceptions
    {
        public long id_exception { get; set; }
        public int ERROR_NUMBER { get; set; }
        public int ERROR_SEVERITY { get; set; }
        public int ERROR_STATE { get; set; }
        public int ERROR_LINE { get; set; }
        public string ERROR_PROCEDURE { get; set; }
        public string ERROR_MESSAGE { get; set; }
        public string additionalInfo { get; set; }
        public System.DateTime date { get; set; }
    }
}