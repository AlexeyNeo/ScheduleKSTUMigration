namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VisibleCallEduc")]
    public partial class VisibleCallEduc
    {
        [Key]
        public int id_visibleCallEduc { get; set; }

        public int? id_republic { get; set; }

        public int? id_city { get; set; }

        public int? id_village { get; set; }

        public int? id_district { get; set; }

        public int? id_region { get; set; }

        public int? id_typeProcSchool { get; set; }

        public int? id_schollProcScholl { get; set; }

        public bool? visible { get; set; }
    }
}
