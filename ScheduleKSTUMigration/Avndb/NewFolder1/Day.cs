namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Day")]
    public partial class Day
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_day { get; set; }

        public int? number { get; set; }

        [StringLength(30)]
        public string Naimenovanie { get; set; }

        public int? Chislitel_Znamenatel { get; set; }

        [StringLength(10)]
        public string briefName { get; set; }

        [StringLength(10)]
        public string Day_name { get; set; }
    }
}
