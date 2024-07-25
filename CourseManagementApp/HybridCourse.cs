
namespace CourseManagementApp
{
    public class HybridCourse : Course
    {
        public override void Subscribe(Student std)
        {
            // Código para suscribirse a un curso híbrido
            Console.WriteLine($"El estudiante {std.Name} se ha suscrito al curso híbrido \"{Title}\".");
        }

        public override string GetCourseDetails()
        {
            return $"Curso híbrido: {Title} (ID: {CourseId})";
        }
    }
}
