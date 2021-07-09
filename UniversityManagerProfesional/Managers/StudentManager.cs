using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagerProfesional.Models;

namespace UniversityManagerProfesional.Managers
{
    public class StudentManager
    {
        public List<StudentModel> GetStutents(int Count)
        {
            List<StudentModel> students = new List<StudentModel>(Count);
            Random rd = new Random();
            for (int i = 0; i < Count; i++)
            {
                var student = new StudentModel(Guid.NewGuid(), rd.Next(16, 80), $"st-{i + 1}", DateTime.Now.Date);
                students.Add(student);
            }
            return students;
        }
    }
}
