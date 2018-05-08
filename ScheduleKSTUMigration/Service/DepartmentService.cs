using ScheduleKSTUMigration.Avndb;
using ScheduleKSTUMigration.ScheduleDB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleKSTUMigration.Service
{
    public class DepartmentService
    {
        private readonly testttEntities1 _avnDb;
        private readonly ScheduleDBContext _scheduleDb;

        public DepartmentService()
        {
            _avnDb = new testttEntities1();
            _scheduleDb = new ScheduleDBContext();
        }

        public async Task Migration()
        {
            try
            {
                var departments = await _avnDb.kafedra.ToListAsync();

                foreach (var department in departments)
                {
                    if (department.id_faculty != null)
                    {
                        if (department.id_faculty == -1) continue;
                        
                        var departmentKSTU = _scheduleDb.Departments.FirstOrDefault(d => d.FullName.Equals(department.f1));
                        var fac = _avnDb.faculty.FirstOrDefault(c => c.id_faculty == department.id_faculty);
                        
                        var f = _scheduleDb.Faculties.FirstOrDefault(c => c.FullName.Equals(fac.p23_2));
                        if (f != null) departmentKSTU.FacultyId = f.Id;
                        await _scheduleDb.SaveChangesAsync();
                    }

                    //_scheduleDb.Departments.Add(new ScheduleKSTUMigration.ScheduleDB.Department
                    //{

                    //    //FacultyId = (short?)f,
                    //    Name = department.sn_f1 ?? "-",
                    //    FullName = department.f1

                    //    //Name = faculty.NameFaculty == null ? "_" : faculty.NameFaculty,
                    //    //FullName = faculty.p23_2,
                    //});
                }

               
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
