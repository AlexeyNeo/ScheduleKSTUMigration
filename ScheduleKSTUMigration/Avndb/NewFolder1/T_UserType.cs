namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_UserType
    {
        [Key]
        public int id_userType { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }
    }
}