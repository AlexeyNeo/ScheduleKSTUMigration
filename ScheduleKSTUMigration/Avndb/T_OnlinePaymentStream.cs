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
    
    public partial class T_OnlinePaymentStream
    {
        public long id_onlinePaymentStream { get; set; }
        public string account { get; set; }
        public int id_onlinePaymentAccountType { get; set; }
        public int id_bank { get; set; }
        public string @operator { get; set; }
        public string txn_id { get; set; }
        public System.DateTime txn_date { get; set; }
        public float sum { get; set; }
        public int id_uslug { get; set; }
        public int id_user { get; set; }
        public short id_userType { get; set; }
        public string payerName { get; set; }
        public string fromAddress { get; set; }
        public string request { get; set; }
        public bool isCanceled { get; set; }
        public bool isTest { get; set; }
    }
}
