using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstraction
{
    class Discipline
    {
         private string name;
        private int numberLectures;
        private int numberStudents;

        public Discipline(string name, int numberLectures, int numberStudents)
        {
            this.Name = name;
            this.NumberLectures = numberLectures;
            this.NumberStudents = numberStudents;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name is empty");
                }
                this.name = value;
            }
        }
        public int NumberLectures
        {
            get
            {
                return this.numberLectures;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The number of lectures can't be negative");
                }
                this.numberLectures = value;
            }
        }
        public int NumberStudents
        {
            get
            {
                return this.numberStudents;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid number of students");
                }
                this.numberStudents = value;
            }
        }
        public string ToStringDiscipline()
        {
            return string.Format("\nName of discipline: {0} \nNumber of lectures: {1} \nNumber of student: {2}",
                this.name, this.numberLectures, this.numberStudents);
        }
    }
}
