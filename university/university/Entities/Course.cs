using university.enums;
namespace university.Entities;

internal class Course
{
    public int Id { get; set; }
    public string MajorGroup { get; set; }

    public string CourseType { get; set; }
    public string CourseName { get; set; }
    public string Day { get; set; }
    public DateTime Time { get; set; }
    public DateTime QuizTime { get; set; }
    public bool IsDelete { get; set; }
    public  int Master { get; set; }
    public Student Student { get; set; }
    public  int ClassCapasity { get; set; }

}
