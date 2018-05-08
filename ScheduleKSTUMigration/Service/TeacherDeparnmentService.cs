//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ScheduleKSTUMigration.Avndb;
//using ScheduleKSTUMigration.ScheduleDB;

//namespace ScheduleKSTUMigration.Service
//{
//   public class TeacherDeparnmentService
//    {
//        private readonly testttEntities _avnDb;
//        private readonly ScheduleDBContext _scheduleDb;

//        public TeacherDeparnmentService()
//        {
//            _avnDb = new testttEntities();
//            _scheduleDb = new ScheduleDBContext();
//        }

//        public async Task Migration()
//        {
//            try
//            {
//                var teacherDepartAvn = _avnDb.RRNK_pps.Where(c => c.id_a_year== 17);

//                foreach (var t in teacherDepartAvn)
//                {
//                    var teacher = _avnDb.teacher.FirstOrDefault(n => n.id_teacher == t.id_teacher);
//                    if(teacher == null) continue;
//                    //var teacherKSTU = _scheduleDb.Teachers.FirstOrDefault(c => c.FirstName ==)
//                }
//                await _scheduleDb.SaveChangesAsync();
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e);
//                throw;
//            }
//        }
//    }
//}
