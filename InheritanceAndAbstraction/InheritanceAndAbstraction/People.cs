using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstraction
{
    class People
    {
        private string name;

        public People(string name)
        {
            this.Name = name;
        }

        public string Name 
        {
            get
            {
                return this.name;
            } 
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                this.name = value;
            }
        }
    }
}
