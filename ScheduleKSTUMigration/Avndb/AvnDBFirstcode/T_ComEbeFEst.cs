namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_ComEbeFEst
    {
        [Key]
        public int id_comEbe_fEst { get; set; }

        public int id_ebe_var { get; set; }

        public int id_f_est { get; set; }

        [Required]
        [StringLength(300)]
        public string Definition { get; set; }
    }
}
