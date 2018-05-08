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
    public class FacultyService
    {
        private readonly testttEntities1 _avnDb;
        private readonly ScheduleDBContext _scheduleDb;

        public FacultyService()
        {
            _avnDb = new testttEntities1();
            _scheduleDb = new ScheduleDBContext();
        }

        public async Task Migration()
        {
            try
            {
                var faculties = await _avnDb.faculty.ToListAsync();

                foreach (var faculty in faculties)
                {
                    var department = faculty;
                    _scheduleDb.Faculties.Add(new Faculty()
                    {
                        Name = faculty.NameFaculty == null ? "_" : faculty.NameFaculty,
                        FullName = faculty.p23_2,
                    });
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
