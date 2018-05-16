using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public class University
    {
        private List<Student> students;
        private List<Teacher> teachers;

        public University()
        {
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }
    }
}
