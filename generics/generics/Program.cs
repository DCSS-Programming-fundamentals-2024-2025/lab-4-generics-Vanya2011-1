using generics.Entities;
using generics.Interfaces;
using generics.Repository;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args) //Кушнірчук Іван КП-41
    {
        Faculty fpm = new Faculty();
        fpm.AddGroup(new Group { Id = 1, Name = "KP-41" });
        fpm.AddGroup(new Group { Id = 2, Name = "KP-42" });
        fpm.AddGroup(new Group { Id = 3, Name = "KP-43" });

        fpm.GetGroup(1).AddStudent(new Student { Id = 1, Name = "Ivan" });
        fpm.GetGroup(1).AddStudent(new Student { Id = 2, Name = "Nazar" });
        fpm.GetGroup(1).AddStudent(new Student { Id = 3, Name = "Misha" });

        fpm.GetGroup(2).AddStudent(new Student { Id = 4, Name = "Sasha" });
        fpm.GetGroup(2).AddStudent(new Student { Id = 5, Name = "Oleg" });
        fpm.GetGroup(2).AddStudent(new Student { Id = 6, Name = "Masha" });

        fpm.GetGroup(3).AddStudent(new Student { Id = 7, Name = "Yaroslav" });
        fpm.GetGroup(3).AddStudent(new Student { Id = 8, Name = "Sasha" });
        fpm.GetGroup(3).AddStudent(new Student { Id = 9, Name = "Vanya" });

        Console.WriteLine(string.Join(", ", fpm.GetGroup(1).GetAllStudents().Select(s => s.Name)));
        Console.WriteLine(string.Join(", ", fpm.GetGroup(2).GetAllStudents().Select(s => s.Name)));
        Console.WriteLine(string.Join(", ", fpm.GetGroup(3).GetAllStudents().Select(s => s.Name)));


        IReadOnlyRepository<int, Student> studRepo = new InMemoryRepository<int, Student>();
        IReadOnlyRepository<int, Person> persRepo = studRepo;  // має компілюватися
        var a = new InMemoryRepository<int, Person>();
        IWriteRepository<int, Person> persWrite = a;
        IWriteRepository<int, Student> studWrite = persWrite;  // має компілюватися




    }

}