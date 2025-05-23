using university.enums;
namespace university.Entities;

internal class Lesson
{
    public StudyGroup StudyGroup { get; set; }
    public string Title { get; set; }

    public DateTime StartAt { get; set; }

    public DateTime FinishAt { get; set; }

    public  Master Master { get; set; }

    public  int term { get; set; }

}
