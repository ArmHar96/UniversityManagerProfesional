using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagerProfesional.Models;

namespace UniversityManagerProfesional.Managers
{
    public class UniversityManager
    {
        public List<TeacherModel> InsertStudentsToTeacher(List<TeacherModel> teachers, List<StudentModel> students)
        {
            int studentsCount = students.Count / teachers.Count;
            int lastTeacherStudentsCount = studentsCount +  students.Count % teachers.Count;
            int lastTeacherPoss = teachers.Count - 1;
            for (int i = 0; i < lastTeacherPoss; i++)
            {
                teachers[i]._students = new List<StudentModel>(studentsCount);
                for (int j = 0; j < studentsCount; j++)
                {
                    teachers[i]._students.Add(students[i * studentsCount + j]);


                }
            }
            teachers[lastTeacherPoss]._students = new List<StudentModel>(lastTeacherStudentsCount);
            for (int i = 0; i < lastTeacherStudentsCount; i++)
            {
                teachers[lastTeacherPoss]._students.Add(students[studentsCount * lastTeacherPoss + i]);

            }
            return teachers; 
        }

        public List<StudentModel> InsertTeacherToStudent (List<TeacherModel> teachers ,List<StudentModel> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                var currStId = students[i]._id;
                for (int j = 0; j < teachers.Count; j++)
                {
                    for (int k = 0; k < teachers[j]._students.Count; k++)
                    {
                        if(teachers[j]._students[k]._id==currStId)
                        {
                            students[i]._teacher = teachers[j];
                        }

                    }
                }
            }
            return students;
        }













    }
}
