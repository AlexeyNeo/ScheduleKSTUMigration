namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Organization_member
    {
        [Key]
        public int id_organization_Member { get; set; }

        public int id_teacher { get; set; }

        public int id_organization { get; set; }
    }
}
