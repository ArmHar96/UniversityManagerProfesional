using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagerProfesional.Models;

namespace UniversityManagerProfesional.Managers
{
    public class TeacherManager
    {
        public List<TeacherModel> GetTeachers(int count)
        {
            List<TeacherModel> teachers = new List<TeacherModel>(count);
            Random rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                var teacher = new TeacherModel(Guid.NewGuid(), rnd.Next(30, 55), $"teacher {i + 1}", DateTime.Now.Date);
                teachers.Add(teacher);
            }

            return teachers;
        }
        



    }
}
