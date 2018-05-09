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
        private readonly avn.avn _avnDb;
        private readonly ScheduleDBContext _scheduleDb;

        public TeacherService()
        {
            _avnDb = new avn.avn();
            _scheduleDb = new ScheduleDBContext();
        }

        public async Task Migration()
        {
            try
            {
                var td = _avnDb.RRNK_pps.Where(c => c.id_a_year == 17);
                var teachers = await _avnDb.teacher.ToListAsync();

                foreach (var teacher in teachers)
                {             
                    var r = td.Where(c => c.id_teacher == teacher.id_teacher).ToList();

                   var t = new Teacher
                    {
                        FirstName = (teacher.p27 + " " + teacher.p28) ?? "-",
                        LastName = teacher.p26 ?? "-"
                    };
                    _scheduleDb.Teachers.Add(t);
                    foreach (var rr in r)
                    {
                        var kaf = _avnDb.kafedra.FirstOrDefault(c => c.id_kafedra == rr.id_kafedra);
                        if (kaf == null) continue;
                        var department = _scheduleDb.Departments.FirstOrDefault(c => c.FullName.Equals(kaf.f1));
                        if (department == null) continue;
                        var teacherDepartment = _scheduleDb.TeacherDepartments.FirstOrDefault(c =>
                            c.DepartmentId == department.Id && c.TeacherId == t.Id);
                        if(teacherDepartment != null) continue;
                        t.TeacherDepartments.Add(new TeacherDepartment
                        {
                            TeacherId = t.Id,
                            DepartmentId = department.Id
                        });
                        await _scheduleDb.SaveChangesAsync();
                    }

                    
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
