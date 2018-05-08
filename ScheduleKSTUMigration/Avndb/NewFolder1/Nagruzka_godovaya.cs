namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Nagruzka_godovaya
    {
        [StringLength(72)]
        public string id_n { get; set; }

        public int? id_a_year { get; set; }

        public int? Semestr { get; set; }

        public int? id_group { get; set; }

        public int? Kod_pred { get; set; }

        public int? Kod_prepod { get; set; }

        public int? groupstreamNum { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Kod_rab { get; set; }

        public double? Chasy { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kafedra { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int aud_specific { get; set; }

        [StringLength(64)]
        public string potok { get; set; }
    }
}
