using CourseManagementApp;

public class Program
{
    public static void Main()
    {
        Course onlineCourse = new OnlineCourse { CourseId = 1, Title = "Curso Virtual 101" };
        Course offlineCourse = new OfflineCourse { CourseId = 2, Title = "Curso Presencial 101" };
        Course hybridCourse = new HybridCourse { CourseId = 3, Title = "Curso Híbrido 101" };

        Student student = new Student { Name = "Emmanuel Soto" };

        SubscribeToCourse(onlineCourse, student);
        SubscribeToCourse(offlineCourse, student);
        SubscribeToCourse(hybridCourse, student);

        Console.WriteLine(onlineCourse.GetCourseDetails());
        Console.WriteLine(offlineCourse.GetCourseDetails());
        Console.WriteLine(hybridCourse.GetCourseDetails());
    }

    public static void SubscribeToCourse(Course course, Student student)
    {
        course.Subscribe(student);
    }
}