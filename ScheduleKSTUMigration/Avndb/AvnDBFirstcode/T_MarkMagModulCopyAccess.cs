namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_MarkMagModulCopyAccess
    {
        [Key]
        public int id_markMagModulCopyAccess { get; set; }

        public int id_f_est { get; set; }

        public int id_modul { get; set; }

        public int id_ebe_var { get; set; }

        public bool doCopy { get; set; }
    }
}
