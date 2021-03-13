namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-11-edmo3000-dykstra2] - Grade enum which holds letter grades 
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        //tinfo200:[2021-03-11-edmo3000-dykstra2] - EnrollmentID prop which is the primary key
        public int EnrollmentID { get; set; }

        //tinfo200:[2021-03-11-edmo3000-dykstra2] - CourseId prop FK with nav prop "Course" 
        public int CourseID { get; set; }

        //tinfo200:[2021-03-11-edmo3000-dykstra2] - StudentId prop FK with nav prop "Student" 
        public int StudentID { get; set; }

        //tinfo200:[2021-03-11-edmo3000-dykstra2] - Grade prop which uses the enum Grade, the ? signifies the prop is nullable
        public Grade? Grade { get; set; }
        public Student Student { get; set; }


    }
}