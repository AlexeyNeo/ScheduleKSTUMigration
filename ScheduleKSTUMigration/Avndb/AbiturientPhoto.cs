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
    
    public partial class AbiturientPhoto
    {
        public int id_photo { get; set; }
        public byte[] photo { get; set; }
        public Nullable<int> id_student { get; set; }
        public string AVN_user { get; set; }
        public Nullable<System.DateTime> AVN_update { get; set; }
    }
}
