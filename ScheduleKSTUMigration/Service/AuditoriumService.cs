using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleKSTUMigration.Avndb;
using ScheduleKSTUMigration.ScheduleDB;

namespace ScheduleKSTUMigration.Service
{
    public class AuditoriumService
    {
        private readonly testttEntities1 _avnDb;
        private readonly ScheduleDBContext _scheduleDb;

        public AuditoriumService()
        {
            _avnDb = new testttEntities1();
            _scheduleDb = new ScheduleDBContext();
        }

        public async Task Migration()
        {
            try
            {

                var AuditoriumsAvn = await _avnDb.Auditoriums.ToListAsync();

                foreach (var auditorium in AuditoriumsAvn)
                {
                    var aud = new ScheduleDB.Auditorium();
                    if (auditorium.id_kafedra != null)
                    {
                        var kaf = _avnDb.kafedra.FirstOrDefault(c => c.id_kafedra == auditorium.id_kafedra);
                        var k = _scheduleDb.Departments.FirstOrDefault(c => c.Name.Equals(kaf.sn_f1));
                        if (k != null) aud.DepartmentId = k.Id;
                    }

                    if (auditorium.id_korpus != null)
                    {
                        var kor = _avnDb.korpus.FirstOrDefault(c => c.id_korpus == auditorium.id_korpus);
                        var k = _scheduleDb.Buildings.FirstOrDefault(c => c.FullName.Equals(kor.name_korpus));
                        if (k != null) aud.BuildingId = k.Id;
                    }

                    if (auditorium.specific != null)
                    {
                        var spec = _avnDb.Specifics.FirstOrDefault(c => c.id_specifics == auditorium.specific);
                        var s = _scheduleDb.AuditoriumTypes.FirstOrDefault(c => c.FullName.Equals(spec.specifics1));
                        if (s != null) aud.AuditoriumTypeId = s.Id;
                    }

                    aud.SeatingCapacity = (short) auditorium.contain;
                    if (auditorium.number == null) continue;

                    aud.Name = auditorium.number;

                    _scheduleDb.Auditoriums.Add(aud);
                }

                await _scheduleDb.SaveChangesAsync();
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
