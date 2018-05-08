using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleKSTUMigration.Service;

namespace ScheduleKSTUMigration
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //AuditoriumServise auditorium = new AuditoriumServise();
            //auditorium.Migration().Wait();
            //BuildingService buildingService = new BuildingService();
            //buildingService.Migration().Wait();
            //FacultyService facultyService = new FacultyService();
            //facultyService.Migration().Wait();
            //DepartmentService departmentService = new DepartmentService();
            //departmentService.Migration().Wait();
            //AuditoriumService auditoriumServise = new AuditoriumService();
            //auditoriumServise.Migration().Wait();
            TeacherService teacherService = new TeacherService();
            teacherService.Migration().Wait();
            //GroupService groupService = new GroupService();
            //groupService.Migration().Wait();

        }
    }
}
