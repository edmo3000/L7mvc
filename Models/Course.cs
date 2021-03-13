using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Course
    {
        //tinfo200:[2021-03-11-edmo3000-dykstra2] - Attribute allows for PK entry rather than generation by the database
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        //tinfo200:[2021-03-11-edmo3000-dykstra2] - Course props which relate to enrollment items
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
