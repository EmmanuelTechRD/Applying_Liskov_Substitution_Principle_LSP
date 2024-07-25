
namespace CourseManagementApp
{
    public class OnlineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            // Código para suscribirse a un curso en línea
            Console.WriteLine($"El estudiante {std.Name} se ha suscrito al curso virtual \"{Title}\".");
        }

        public override string GetCourseDetails()
        {
            return $"Curso en línea: {Title} (ID: {CourseId})";
        }
    }
}
