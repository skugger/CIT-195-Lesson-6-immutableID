namespace CIT_195_Lesson_6_immutableID
{
    internal class Program
    {
        class Student
        {
            public int Id { get; init; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Student()
            {
                Id = 0;
                FirstName = "";
                LastName = "";
            }
            public Student(int i, string First, string Last)
            {
                Id = i;
                FirstName = First;
                LastName = Last;
            }
            public Student(int id)
            {
                Id = id;
                FirstName = string.Empty;
                LastName = string.Empty;
            }
        }
        static void Main(string[] args)
        {
            Student student1 = new Student(1234);
            student1.FirstName = "Typhoid";
            student1.LastName = "Gary";

            Student student2 = new Student(2345, "William", "Budd");

            Console.WriteLine($"Student 1 - ID: {student1.Id}, Name: {student1.FirstName} {student1.LastName}");
            Console.WriteLine($"Student 2 - ID: {student2.Id}, Name: {student2.FirstName} {student2.LastName}");
        }
    }
}