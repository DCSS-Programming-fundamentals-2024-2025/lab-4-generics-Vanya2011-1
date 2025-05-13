using generics.Interfaces;
using generics.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics.Entities
{
    class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }

        IRepository<int, Group> _groups = new InMemoryRepository<int, Group>();
        public void AddGroup(Group g)
        {
            if (g != null)
            {
                _groups.Add(g.Id, g);
            }
            else
            {
                throw new Exception();
            }
        }

        public void RemoveGroup(int id)
        {
            Group group = _groups.Get(id);
            if (group != null)
            {
                _groups.Remove(id);
            }
            else
            {
                throw new Exception();
            }
        }

        public IEnumerable<Group> GetAllGroups()
        {
            return _groups.GetAll();
        }

        public Group GetGroup(int id)
        {
            Group group = _groups.Get(id);
            if (group != null)
            {
                return group;
            }
            else
            {
                throw new Exception();
            }
        }

        public void AddStudentToGroup(int groupId, Student s)
        {
            Group group = _groups.Get(groupId);
            if (group != null)
            {
                group.AddStudent(s);
            }
            else
            {
                throw new Exception();
            }
        }

        public void RemoveStudentFromGroup(int groupId, int studentId)
        {
            Group group = _groups.Get(groupId);
            if (group != null)
            {
                group.RemoveStudent(studentId);
            }
            else
            {
                throw new Exception();
            }
        }
        public IEnumerable<Student> GetAllStudentsInGroup(int groupId)
        {
            Group group = _groups.Get(groupId);
            if (group != null)
            {
                return group.GetAllStudents();
            }
            else
            {
                throw new Exception();
            }
        }

        public Student FindStudentInGroup(int groupId, int studentId)
        {
            Group group = _groups.Get(groupId);
            if (group != null)
            {
                return group.FindStudent(studentId);
            }
            else
            {
                throw new Exception();
            }
        }




    }
}
