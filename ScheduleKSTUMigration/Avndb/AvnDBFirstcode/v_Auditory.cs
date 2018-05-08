namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_Auditory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_auditorium { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string name_korpus { get; set; }

        [StringLength(20)]
        public string Auditory { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int contain { get; set; }

        [StringLength(50)]
        public string specifics { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_specifics { get; set; }

        [StringLength(100)]
        public string note { get; set; }

        public double? square { get; set; }
    }
}
