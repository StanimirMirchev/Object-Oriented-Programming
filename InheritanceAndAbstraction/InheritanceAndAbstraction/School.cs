using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstraction
{
    class School
    {
        static void Main(string[] args)
        {
            Discipline geography = new Discipline("geography", 3, 20);
            Discipline math = new Discipline("math", 1, 25);
            Discipline IT = new Discipline("IT", 3, 23);
            Discipline chess = new Discipline("chess", 4, 30);

            List<Discipline> disciplisnesOne = new List<Discipline>();
            disciplisnesOne.Add(geography);
            disciplisnesOne.Add(math);
            disciplisnesOne.Add(IT);

            List<Discipline> disciplisnesTwo = new List<Discipline>();
            disciplisnesTwo.Add(geography);
            disciplisnesTwo.Add(IT);
            disciplisnesTwo.Add(chess);
            disciplisnesTwo.Add(math);

            Teacher teacher1 = new Teacher("Ludmila", disciplisnesOne);
            Teacher teacher2 = new Teacher("Stefan", disciplisnesTwo);

            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(teacher1);
            teachers.Add(teacher2);

          
        }
    }
}
