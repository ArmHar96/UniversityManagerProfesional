using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagerProfesional.Managers;
using UniversityManagerProfesional.Models; 

namespace UniversityManagerProfesional
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager st = new StudentManager();
            List<StudentModel> students = st.GetStutents(70);
            TeacherManager tch = new TeacherManager();
            List<TeacherModel> teachers = tch.GetTeachers(6);

            UniversityManager um = new UniversityManager();
            List<TeacherModel> updateTeachers = um.InsertStudentsToTeacher(teachers, students);
            List<StudentModel> updatestudents = um.InsertTeacherToStudent(updateTeachers, students);

            for (int i = 0; i < teachers.Count; i++)
            {
                Console.WriteLine($"TEacher {teachers[i]._name}");
                Console.WriteLine("*****************************************************");
                for (int j = 0; j < teachers[i]._students.Count; j++)
                {
                    Console.WriteLine($"Student {teachers[i]._students[j]._name} ");
                }
                Console.WriteLine("*****************************************************");
            }


            Console.ReadKey();

        }
    }
}
