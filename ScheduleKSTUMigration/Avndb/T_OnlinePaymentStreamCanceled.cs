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
    
    public partial class T_OnlinePaymentStreamCanceled
    {
        public long id_onlinePaymentStreamCanceled { get; set; }
        public long id_onlinePaymentStream { get; set; }
        public string @operator { get; set; }
        public System.DateTime canceled { get; set; }
        public string request { get; set; }
        public string fromAddress { get; set; }
    }
}
