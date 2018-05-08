using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleKSTUMigration.Avndb;
using ScheduleKSTUMigration.ScheduleDB;

namespace ScheduleKSTUMigration.Service
{
    class TeacherService
    {
        private readonly testttEntities1 _avnDb;
        private readonly ScheduleDBContext _scheduleDb;

        public TeacherService()
        {
            _avnDb = new testttEntities1();
            _scheduleDb = new ScheduleDBContext();
        }

        public async Task Migration()
        {
            try
            {

                var teachers = await _avnDb.teacher.ToListAsync();

                foreach (var teacher in teachers)
                {
                    var td = _avnDb.RRNK_pps.Where(c => c.id_a_year == 17);
                    var r = td.Where(c => c.id_teacher == teacher.id_teacher);

                   
                   var t = new Teacher
                    {
                        FirstName = (teacher.p27 + " " + teacher.p28) ?? "-",
                        LastName = teacher.p26 ?? "-"
                    };
                    foreach (var rr in r)
                    {
                        var kaf = _avnDb.kafedra.FirstOrDefault(c => c.id_kafedra == rr.id_kafedra);
                        if (kaf == null) continue;
                        var department = _scheduleDb.Departments.FirstOrDefault(c => c.FullName.Equals(kaf.f1));
                        if(department == null) continue;
                        t.TeacherDepartments.Add(new TeacherDepartment
                        {
                            TeacherId = t.Id,
                            DepartmentId = department.Id
                        });
                    }

                    //_scheduleDb.Teachers.Add(
                }

                await _scheduleDb.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
