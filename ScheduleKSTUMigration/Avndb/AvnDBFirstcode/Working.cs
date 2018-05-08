namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Working")]
    public partial class Working
    {
        [Key]
        public int id_working { get; set; }

        public int id_teacher { get; set; }

        public int id_stavka { get; set; }

        public int id_vakansiya { get; set; }

        public int id_base_over { get; set; }

        public int? razr { get; set; }

        public int id_prikaz_come { get; set; }

        [Required]
        [StringLength(30)]
        public string Num_prikaz_Enter { get; set; }

        public DateTime date_come { get; set; }

        public DateTime? from_d { get; set; }

        public int? temp_leave { get; set; }

        public int id_leave { get; set; }

        [StringLength(30)]
        public string Num_prikaz_leave { get; set; }

        public DateTime? Date_leave { get; set; }

        [StringLength(100)]
        public string Reason_quit { get; set; }

        public DateTime? off_date { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public double? hourFond { get; set; }

        public virtual _base _base { get; set; }

        public virtual Prikaz_come Prikaz_come { get; set; }

        public virtual Prikaz_leave Prikaz_leave { get; set; }

        public virtual Stavka Stavka { get; set; }

        public virtual teacher teacher { get; set; }

        public virtual Vakansii Vakansii { get; set; }
    }
}
