namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Spravka")]
    public partial class Spravka
    {
        [Key]
        public int id_spravka { get; set; }

        public int? id_group { get; set; }

        public int? id_student { get; set; }

        public int? id_semester { get; set; }

        [StringLength(20)]
        public string numSpravka { get; set; }

        public DateTime? outDate { get; set; }

        [StringLength(30)]
        public string placeWork { get; set; }

        [StringLength(20)]
        public string post { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
