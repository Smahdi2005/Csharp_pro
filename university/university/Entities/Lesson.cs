using university.enums;
namespace university.Entities;

internal class Lesson
{
    public int StudyGroup { get; set; }
    public string Title { get; set; }
    public DateTime StartAt { get; set; }
    public DateTime ExamTime { get; set; }
    public bool IsDelete { get; set; }
    public  Master Master { get; set; }
    public Student Student { get; set; }
    public  int term { get; set; }

}
