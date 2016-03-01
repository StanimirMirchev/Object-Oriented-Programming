using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstraction
{
    class Teacher : People
    {
        private List<Discipline> disciplines;

        public Teacher(string name, List<Discipline> disciplines)
            :base(name)
        {
            this.Disciplines = disciplines;
        }
        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                this.disciplines = value;
            }
        }
        public string ToStringTeachers()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\nTeacher: " + this.Name);
            foreach (var item in disciplines)
            {
                result.Append(item.ToStringDiscipline());
            }
            return result.ToString();
        }


    }
}
