namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Abroad")]
    public partial class Abroad
    {
        [Key]
        public int id_abroad { get; set; }

        [StringLength(50)]
        public string purchose { get; set; }

        public DateTime? date_begin { get; set; }

        public DateTime? date_end { get; set; }

        public int? id_teacher { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [StringLength(10)]
        public string orderNum { get; set; }

        public DateTime? orderDate { get; set; }

        [StringLength(100)]
        public string country { get; set; }

        public virtual teacher teacher { get; set; }
    }
}
