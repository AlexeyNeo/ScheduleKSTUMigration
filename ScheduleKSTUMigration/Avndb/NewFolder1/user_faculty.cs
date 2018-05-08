namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user_faculty
    {
        public int id { get; set; }

        [StringLength(50)]
        public string f_user_name { get; set; }

        [StringLength(50)]
        public string user { get; set; }

        [StringLength(20)]
        public string user_name { get; set; }

        public int? faculty { get; set; }

        public int? id_login { get; set; }

        [StringLength(10)]
        public string OKS { get; set; }

        [StringLength(10)]
        public string OKPPS { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
