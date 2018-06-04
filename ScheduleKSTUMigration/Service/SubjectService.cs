using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleKSTUMigration.Avndb;
using ScheduleKSTUMigration.ScheduleDB;

namespace ScheduleKSTUMigration.Service
{
    public class SubjectService
    {
        private readonly avn.avn _avnDb;
        private readonly ScheduleDBContext _scheduleDb;

        public SubjectService()
        {
            _avnDb = new avn.avn();
            _scheduleDb = new ScheduleDBContext();
        }

        public async Task Migration()
        {
            try
            {
                int count = 0;
                var disciplineKafedra = await _avnDb.RRNKkrdt.Where(c => c.id_a_year==17).ToListAsync();
                var kafavn = _avnDb.kafedra;
                var discipline = await _avnDb.discipline.ToListAsync();
                var departments = _scheduleDb.Departments;
                foreach (var d in discipline)
                {
                    Console.Clear();
                    Console.WriteLine(count++);
                    if(d.p34.Length >=80)
                        System.Console.WriteLine(d.p34);
                    var subject = new Subject
                    {
                        Name = d.s_p34 ?? "-",
                        FullName = d.p34 ?? "-"
                    };

                    _scheduleDb.Subjects.Add(subject);

                    var disciplineKafedralist= disciplineKafedra.Where(c => c.id_discipline == d.id_discipline).ToList();

                    if (!disciplineKafedralist.Any()) continue;

                    foreach (var disciplinekaf in disciplineKafedralist)
                    {
                        var kaf = kafavn.FirstOrDefault(c => c.id_kafedra == disciplinekaf.id_kafedra);

                        if (kaf == null) continue;

                        var department = departments.FirstOrDefault(c => c.FullName.Equals(kaf.f1));

                        if (department == null) continue;

                        var valid = _scheduleDb.SubjectDepartments.FirstOrDefault(c =>
                            c.Department.Id == department.Id && c.SubjectId == subject.Id);
                        if(valid != null) continue;
                        

                        subject.SubjectDepartments.Add( new SubjectDepartment
                        {
                            DepartmentId = department.Id,
                            SubjectId = subject.Id
                        });
                    }

                   // await _scheduleDb.SaveChangesAsync();
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