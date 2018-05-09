namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVN_TEST_SREZ
    {
        [Key]
        public int id_AVN_TEST_SREZ { get; set; }

        public int? id_student { get; set; }

        public int? id_fac { get; set; }

        public int? ig_group { get; set; }

        public int? id_semestr { get; set; }

        public int? id_disciplina { get; set; }

        public int? id_examination { get; set; }

        public int? ball { get; set; }

        [StringLength(50)]
        public string pole { get; set; }

        public int? attempt { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public DateTime? GenerateDate { get; set; }

        [StringLength(20)]
        public string Status { get; set; }
    }
}
