using generics.Interfaces;
using generics.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics.Entities
{
    class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        IRepository<int, Student> _students = new InMemoryRepository<int, Student>();
        public void AddStudent(Student s)
        {
            if (s != null)
            {
                _students.Add(s.Id, s);
            }
            else
            {
                throw new Exception();
            }
        }
        public void RemoveStudent(int studentId)
        {
            Student student = _students.Get(studentId);
            if (student != null)
            {
                _students.Remove(studentId);
            }
            else
            {
                throw new Exception();
            }
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return _students.GetAll();
        }
        public Student FindStudent(int studentId)
        {
            return _students.Get(studentId);
        }



    }
}
