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
    public class AuditoriumServise
    {
        private readonly testttEntities1 _avnDb;
        private readonly ScheduleDBContext _scheduleDb;

        public AuditoriumServise()
        {
            _avnDb = new testttEntities1();
            _scheduleDb = new ScheduleDBContext();
        }

        public async Task Migration()
        {
            try
            {

            var auditoriumsTypeAvn = await _avnDb.Specifics.ToListAsync();

            foreach (var type in auditoriumsTypeAvn)
            {
                _scheduleDb.AuditoriumTypes.Add(new AuditoriumType
                {
                    Name = type.short_specifics,
                    FullName = type.specifics1
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
