namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Work")]
    public partial class Work
    {
        [Key]
        public int id_Work { get; set; }

        [StringLength(50)]
        public string Doljnost { get; set; }

        [StringLength(50)]
        public string Name_org { get; set; }

        [StringLength(50)]
        public string Adress { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [StringLength(60)]
        public string FIO_Dir { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Salary { get; set; }

        public DateTime? Date_Enter { get; set; }

        public DateTime? Date_Quit { get; set; }

        public int? id_type_job { get; set; }

        public int? id_teacher { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [StringLength(50)]
        public string descr { get; set; }

        [StringLength(50)]
        public string Enter_numPrikaz { get; set; }

        [StringLength(50)]
        public string Quit_numPrikaz { get; set; }

        public bool First_Check { get; set; }

        public virtual _base _base { get; set; }

        public virtual teacher teacher { get; set; }
    }
}
