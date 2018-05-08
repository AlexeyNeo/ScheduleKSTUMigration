namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SemestrShcedule")]
    public partial class SemestrShcedule
    {
        [Key]
        public int id_shcedule { get; set; }

        public int? kod_prepod { get; set; }

        public int? id_auditorium { get; set; }

        [StringLength(50)]
        public string id_potok { get; set; }

        public int? id_day { get; set; }

        public int? id_time { get; set; }

        public int? kod_predmet { get; set; }

        public int? id_rab { get; set; }

        public bool? znamenatel { get; set; }

        public int? id_nedeli { get; set; }

        public int? id_year { get; set; }

        public int? id_semestr { get; set; }

        public virtual discipline discipline { get; set; }

        public virtual nedeli nedeli { get; set; }

        public virtual teacher teacher { get; set; }

        public virtual Time_ Time_ { get; set; }
    }
}
