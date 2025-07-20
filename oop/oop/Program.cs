using System.Net.Sockets;

namespace oop
{
    internal class Program
    {
        struct Person
        {
            public string name;
            public int age;
            public int birthMonth;
            public long number;

            public Person(String name,int age,int birthMonth,long number)
            {
                this.name = name;
                this.age = age; 
                this.birthMonth = birthMonth;
                this.number = number;
            }
            public Person()
            {
                Console.WriteLine("used");
            }
        }
        class People
        {
            private string name;
            private int age;
            public string Name
            {
                get { return name; }
                set { name = (string.IsNullOrEmpty(name)) ? "INvalid name" : value; }

            }
            public int Age;

            //public People()
            //{

            //}public People(string name)
            //{
            //    this.name=name;
            //    this.age = 0;

            //}public People(int age
            //    )
            //{
            //    this.name = "";
            //    this.age = age;
            //}
            public People(string name, int age)
            {
                Name = name;
                Age = age;

                
            }

            public void SetName(string name)
            {
                
                this.name = (string.IsNullOrEmpty(name)) ? "Invalid Name" : name;
                    
            } 
            public string getName()
            {
                return this.name;
            }
            public void SetAge(int age)
            {
                this.age = (age>0 && age<150) ? age : -1;
                    
            }
            public long getAge() => this.age;
            

            public string ReturnDetails()
            {
                return $"Name:{this.name}\nAge:{this.age}";
            }

            public override string ToString()
            {
                return $"name = {Name}\nAge = {Age}";
                ;

            }
           
        }
        static void Main(string[] args)
        {
            string name = "Ronish";
            int age = 23;

            Person person= new Person("Ronish",18,09,436659);

            People people = new People("Ronish",21);
            Console.Write(people.ReturnDetails());

            People people3 = new People("getter name",12);
            Console.Write(people3.ReturnDetails());
            name = people3.Name;
            Console.Write("getter");
            Console.Write(name);
           

            
            
           

        }

        static Person returnPerson()
        {
            return new Person("Ronish",18,09,4376650360);
        }
    }
}
