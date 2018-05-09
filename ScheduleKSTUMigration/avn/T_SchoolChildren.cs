namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_SchoolChildren
    {
        [Key]
        public long id_schoolChildren { get; set; }

        public long id_schoolClass { get; set; }

        [Required]
        [StringLength(50)]
        public string surname { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(50)]
        public string patronymic { get; set; }

        [Required]
        [StringLength(20)]
        public string parentPhone { get; set; }
    }
}
