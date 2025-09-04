namespace TallinnaRakenduslikKolledšTARpe24.Models
{
    public enum Grade
    {
       A,B,C,D,F,X,MA
    }
    public class Enrollment
    {
        public int Id { get; set; }
        public string CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade CurrentGrade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
