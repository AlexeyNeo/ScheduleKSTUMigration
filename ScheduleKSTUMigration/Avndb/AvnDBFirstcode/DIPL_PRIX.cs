namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIPL_PRIX
    {
        [Key]
        public int ID_D { get; set; }

        [Required]
        [StringLength(70)]
        public string S_FIO { get; set; }

        public DateTime d_oprix { get; set; }

        [Required]
        [StringLength(12)]
        public string NOMER { get; set; }

        public float SENA { get; set; }

        public int ID_STUD { get; set; }
    }
}
