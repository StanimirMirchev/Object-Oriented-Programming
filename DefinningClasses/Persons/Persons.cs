using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Persons
{
    private string name;
    private int age;
    private string email;


    public Persons(string name, int age, string email= " "){
        this.Name = name;
        this.Age = age;
        this.Email = email; 
    }


    public string Name {   
        get
        {
            return this.name;
        }
        set
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Empty name!");
            }
            else
            {
                this.name = value;
            }
        }
    }

    public int Age {
        get
        {
            return this.age;
        }
        set
        {
            if(value >= 1 && value<=100)
            {
                this.age = value;
            }
            else
            {
                throw new ArgumentException("Invalid age!");
            }
        }
    }

    public string Email {
        get
        {
            return this.email;
        }
        set
        {
            if(string.IsNullOrEmpty(value) ||  value.Contains("@") )
            {
                this.email = value;
            }
            else
            {
                throw new ArgumentException("Invalid email!");
            }
        }
    }

    public override string ToString()
    {
        return string.Format("Name: {0} ,Age: {1},Email: {2} !",this.name,this.age,this.email);
    }


}

