namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Wbr_Students
    {
        [Key]
        public int Ident { get; set; }

        public int Room_Id { get; set; }

        public int Student_Id { get; set; }
    }
}
