namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Wbr_Rooms
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ident { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int OM_Room_Id { get; set; }

        public bool IsActive { get; set; }

        public bool isDynamic { get; set; }

        public int id_humanFrom { get; set; }

        public int id_humanTypeFrom { get; set; }

        public DateTime beginDate { get; set; }
    }
}
