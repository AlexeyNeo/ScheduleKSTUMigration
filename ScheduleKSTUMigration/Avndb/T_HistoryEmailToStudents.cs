//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScheduleKSTUMigration.Avndb
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_HistoryEmailToStudents
    {
        public int id_historyEmailToStudent { get; set; }
        public int id_avn_user_sender { get; set; }
        public int id_student { get; set; }
        public string student_email { get; set; }
        public System.DateTime date { get; set; }
        public string message { get; set; }
        public bool isSuccess { get; set; }
    }
}
