using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    class MainExample
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Georgi", "Georgiev", 90324);
            Student student2 = new Student("Petar", "Peshev", 80324);
            Student student3 = new Student("Vladislav", "Vladimirov", 903324);
            Student student4 = new Student("Samuil", "Samuilov", 9044324);
            Student student5 = new Student("Svetlin", "Nakov", 10324);
            Student student6 = new Student("Ivailo", "Ivailov", 945324);
            Student student7 = new Student("Hristo", "Hristov", 60324);
            Student student8 = new Student("Ilian", "Iliev", 90924);
            Student student9 = new Student("Ivan", "Ivanov", 10324);
            Student student10 = new Student("Stanislav", "Stanislavov", 19324);
            
            List<Student> listOfStudents = new List<Student>();
            listOfStudents.Add(student1);
            listOfStudents.Add(student2);
            listOfStudents.Add(student3);
            listOfStudents.Add(student4);
            listOfStudents.Add(student5);
            listOfStudents.Add(student6);
            listOfStudents.Add(student7);
            listOfStudents.Add(student8);
            listOfStudents.Add(student9);
            listOfStudents.Add(student10);


            
            var sortStudents =
                from student in listOfStudents
                orderby student.FaultyNumber ascending
                select student;

            foreach (Student student in sortStudents)
            {
                Console.WriteLine("{0} - {1} - {2}", student.FirstName, student.LastName, student.FaultyNumber);
            }


            Worker worker1 = new Worker("someone1", "lastName", 400, 6);
            Worker worker2 = new Worker("someone2", "lastName", 500, 5);
            Worker worker3 = new Worker("someone3", "lastName", 300, 6);
            Worker worker4 = new Worker("someone4", "lastName", 1000, 8);
            Worker worker5 = new Worker("someone5", "lastName", 450, 3);
            Worker worker6 = new Worker("someone6", "lastName", 4000, 6);
            Worker worker7 = new Worker("someone7", "lastName", 300, 6);
            Worker worker8 = new Worker("someone8", "lastName", 800, 8);
            Worker worker9 = new Worker("someone9", "lastName", 660, 6);
            Worker worker10 = new Worker("someone10", "lastName", 220, 11);

            List<Worker> workers = new List<Worker>();
            workers.Add(worker1);
            workers.Add(worker2);
            workers.Add(worker3);
            workers.Add(worker4);
            workers.Add(worker5);
            workers.Add(worker6);
            workers.Add(worker7);
            workers.Add(worker8);
            workers.Add(worker9);
            workers.Add(worker10);

            var sortWorkers =
                from worker in workers
                orderby worker.PaymentPerHour descending
                select worker;


            foreach (Worker worker in sortWorkers)
            {
                Console.WriteLine("{0} - {1} - {2} - {3}", worker.FirstName, worker.LastName, worker.WeekSalary, worker.WorkHoursPerDay);
            }



            
        }
    }

}
