using StudentApi.Models;

namespace StudentApi.DataStimulation
{
    public class DataStimulus
    {
        public static readonly List<Student> Students = new List<Student>
        {
            new Student {Id = 1, Name = "Ali Ahmed", Age = 20, Grade = 67 },
            new Student {Id = 2, Name = "Fadi Khalil", Age = 17, Grade = 77 },
            new Student {Id = 3, Name = "Ola Jaber", Age = 21, Grade = 45 },
            new Student {Id = 4, Name = "Alia Maher", Age = 24, Grade = 86 }
        };
    }
}
