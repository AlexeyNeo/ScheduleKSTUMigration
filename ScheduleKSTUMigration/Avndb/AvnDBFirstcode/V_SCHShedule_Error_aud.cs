namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_SCHShedule_Error_aud
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AcadYearID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string p32 { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool IsSemestrAutumn { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(16)]
        public string semester { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WeekDayID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(3)]
        public string WeekDayNameShort { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short PairNumber { get; set; }

        [StringLength(697)]
        public string discipline { get; set; }

        [StringLength(55)]
        public string s_t_fio { get; set; }

        [StringLength(20)]
        public string number { get; set; }

        [StringLength(25)]
        public string nedeli { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AuditoryID { get; set; }
    }
}
