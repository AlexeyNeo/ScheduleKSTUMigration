namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVN_reports
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_reports { get; set; }

        [StringLength(200)]
        public string n_reports { get; set; }

        [StringLength(50)]
        public string clic { get; set; }

        public int? id_otdel { get; set; }

        [StringLength(50)]
        public string n_otdel { get; set; }

        public double? sort { get; set; }
    }
}
