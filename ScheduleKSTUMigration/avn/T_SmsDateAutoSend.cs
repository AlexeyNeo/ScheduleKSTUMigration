namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_SmsDateAutoSend
    {
        [Key]
        public int id_smsDateAutoSend { get; set; }

        public byte id_smsAutoSendKind { get; set; }

        public byte month { get; set; }

        public byte day { get; set; }
    }
}
