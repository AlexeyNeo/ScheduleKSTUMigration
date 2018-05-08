namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVNLOG_1_1
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_user { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string surname { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string patronymic { get; set; }
    }
}
