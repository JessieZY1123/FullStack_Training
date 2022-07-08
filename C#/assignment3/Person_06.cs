using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_HW
{
    interface IPersonService {
        public int calculateAge();
        public decimal calculateSalary();
        public string[] getAddress();
    }

    interface IInstructorService : IPersonService
    {
        public void getDepartment();
        public decimal updateBonus(DateTime joinDate);
    }

    interface IStudentService<T> : IPersonService
    {
        public void getCourse();
        public decimal calculateGPA();
        public char[] getGrades();

    }

    interface ICourseService {
        public string[] enrollLec(int sId, string sName);
    
    }

    interface IDepartmentService {
        public string getLeader();
        public decimal getBudget(DateTime startTime, DateTime endTime);
        public string[] offerCourses();

}
}
