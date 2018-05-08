namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Books
    {
        [Key]
        public int id_books { get; set; }

        [Required]
        [StringLength(255)]
        public string fileName { get; set; }

        public int id_semester { get; set; }

        public int id_discipline { get; set; }

        public int id_examination { get; set; }

        public int id_speciality { get; set; }

        public int id_user { get; set; }

        public int id_human { get; set; }

        public int id_humanType { get; set; }

        public int id_typeUmk { get; set; }

        public bool isHTMLBook { get; set; }

        public bool isDeleted { get; set; }

        [StringLength(300)]
        public string name { get; set; }

        [StringLength(200)]
        public string author { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        public short? totalPages { get; set; }

        public int? id_bookCategory { get; set; }

        public bool? isForEBooks { get; set; }

        public int id_booksShare { get; set; }

        public bool isSharedBookFromEBooks { get; set; }

        public DateTime created { get; set; }

        public int kredits { get; set; }

        public short id_forStudentKind { get; set; }

        public bool isTempDel { get; set; }

        public DateTime updatedFileDate { get; set; }
    }
}
