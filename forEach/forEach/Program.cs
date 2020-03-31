using System;
using System.Collections.Generic;

namespace forEach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> l = new List<Person>();
            l.Add(new Person ( Name:"Prem", age:50 ));
            l.Add(new Person(Name: "Manjula", age: 49));
            l.Add(new Person(Name: "Santosh", age: 29));
            l.Add(new Person(Name: "Preeti", age: 22));
            foreach(var it in l){
                Console.WriteLine(it.Name);
            }
        }
    }
    class Person
    {
        public String Name;
        public int age;

        public Person(String Name,int age)
        {
            this.Name = Name;
            this.age = age;
        }
    }
}
