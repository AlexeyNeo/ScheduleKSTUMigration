namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_PermittedFacultyForOnlinePayment
    {
        [Key]
        [Column(Order = 0)]
        public int id_permittedFacultyForOnlinePayment { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }
    }
}
