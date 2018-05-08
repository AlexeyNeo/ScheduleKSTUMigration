namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_UmkType
    {
        [Key]
        public int id_typeUmk { get; set; }

        [StringLength(100)]
        public string umkName { get; set; }

        public int order { get; set; }
    }
}
