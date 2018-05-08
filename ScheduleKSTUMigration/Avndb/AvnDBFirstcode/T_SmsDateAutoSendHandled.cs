namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_SmsDateAutoSendHandled
    {
        [Key]
        public long id_smsDateAutoSendHandled { get; set; }

        public byte id_smsAutoSendKind { get; set; }

        public byte month { get; set; }

        public byte day { get; set; }

        public int year { get; set; }
    }
}
