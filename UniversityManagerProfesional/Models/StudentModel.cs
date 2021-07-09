using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagerProfesional.Models
{
   public class StudentModel
    {
        public Guid _id;
        public int _age;
        public string _name;
        public DateTime _birthDate;
        public TeacherModel _teacher;
        public StudentModel()
        {

        }
        public StudentModel(Guid id,int age,string name,DateTime birthDate)
        {
            _id = id;
            _age = age;
            _name = name;
            _birthDate = birthDate;
        }
    }
}
