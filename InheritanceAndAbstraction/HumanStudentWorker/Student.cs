using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    class Student : Human
    {
        private string firstName;
        private string lastName;
        private int faultyNumber;
        public Student(string firstName, string lastName, int faultyNumber) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FaultyNumber = faultyNumber;
        }

        public string  FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid first name!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid last name!");
                }
                this.lastName = value;
            }
        }


        public int FaultyNumber
        {
            get
            {
                return this.faultyNumber;
            }
            set
            {  
                if(value.ToString().Length < 5 || value.ToString().Length > 10 )
                {
                    throw new ArgumentException("Invalid faulty number!");
                }
                this.faultyNumber = (int)value;
            }
        }
    }
}
