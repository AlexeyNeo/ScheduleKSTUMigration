using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleKSTUMigration.Avndb;
using ScheduleKSTUMigration.ScheduleDB;

namespace ScheduleKSTUMigration.Service
{
    public class GroupService
    {
        private readonly testttEntities1 _avnDb;
        private readonly ScheduleDBContext _scheduleDb;

        public GroupService()
        {
            _avnDb = new testttEntities1();
            _scheduleDb = new ScheduleDBContext();
        }

        public async Task Migration()
        {
            try
            {
                var groups = await _avnDb.group.Where(c => c.id_kafedra != null).ToListAsync();
                foreach (var @group in groups)
                {
                    if(@group.id_kafedra == 0) continue;
                    
                    var avnKafedra = _avnDb.kafedra.FirstOrDefault(c => c.id_kafedra == @group.id_kafedra);
                    var department = _scheduleDb.Departments.FirstOrDefault(c => c.FullName.Equals(avnKafedra.f1));
                    if (department == null) continue;
                    _scheduleDb.Groups.Add(new Group
                    {
                        DepartmentId = department.Id,
                        Name = @group.p20 ?? "-"
                    });
                    await _scheduleDb.SaveChangesAsync();
                }

                
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
