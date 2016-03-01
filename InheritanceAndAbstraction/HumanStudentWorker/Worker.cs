using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    class Worker : Human
    {
        private int weekSalary;
        private int workHoursPerDay;
        private string firstName;
        private string lastName;
        private int paymentPerHour;
        private void MoneyPerHour()
        {
            this.paymentPerHour = (weekSalary / 5) / this.workHoursPerDay;
        }

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int PaymentPerHour 
        {
            get
            {
                return this.paymentPerHour;
            }
            private set { }
        }

        public string FirstName 
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
        public int WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid week salary!");
                }
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid faulty number!");
                }
                this.workHoursPerDay = value;
            }
        }

        
    }
}
