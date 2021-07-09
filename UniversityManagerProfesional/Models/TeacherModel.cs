using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagerProfesional.Models
{
    public class TeacherModel
    {
        public Guid _id;
        public int _age;
        public string _name;
        public DateTime _BirtthDay;
        public List<StudentModel> _students;

        public TeacherModel()
        {
                
        }

        public TeacherModel(Guid id,int age,string name,DateTime birtthDay)
        {
            _id = id;
            _age = age;
            _name = name;
            _BirtthDay = birtthDay;
        }
    }
}
