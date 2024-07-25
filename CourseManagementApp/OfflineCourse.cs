
namespace CourseManagementApp
{
    public class OfflineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            // Código para suscribirse a un curso presencial
            Console.WriteLine($"El estudiante {std.Name} se ha suscrito al curso presencial \"{Title}\".");
        }

        public override string GetCourseDetails()
        {
            return $"Curso presencial: {Title} (ID: {CourseId})";
        }
    }
}
