using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        //tinfo200:[2021-03-11-edmo3000-dykstra2] - ID prop which is the primary key for the corresponding database column
        public int ID { get; set; }

        //tinfo200:[2021-03-11-edmo3000-dykstra2] - First and last name and DateTime student properties 
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //tinfo200:[2021-03-11-edmo3000-dykstra2] - Navigation property "Enrollments" conatains all "Student" related "Enrollment" items
        //tinfo200:[2021-03-11-edmo3000-dykstra2] - Contains a students primary key in the columns "StudentID" foreign key
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
