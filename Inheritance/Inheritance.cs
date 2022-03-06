using System;

namespace Inheritance
{
    //Base class
    class Person
    {
        public string _name;
        public string _surname;
        public int _age;
        public void PersonData(string name,string surname,int age)
        {
            _name=name;
            _surname=surname;
            _age=age;
        }
        public void PersonDataWriter()
        {
            Console.WriteLine("Name: " + _name /*or base.name*/);
            Console.WriteLine("Surname: " + _surname);
            Console.WriteLine("Age: " + _age);
        }

    }
    //Inheriting Person class using:
    class Student : Person
    {
        float _studentGrade;
        int _classYear;
        int _studentNumber;
        public void StudentData(float studentGrade,int classYear,int studentNumber)
        {
            _studentGrade=studentGrade;
            _classYear=classYear;
            _studentNumber=studentNumber;
        }
        public void StudentDataWriter()
        {
            //as seen bellow , sub class (student) can use super class data.
            Console.WriteLine("Name: " + _name /*or base.name*/);
            Console.WriteLine("Surname: " + _surname);
            Console.WriteLine("Age: " + _age);
            Console.WriteLine("Student Grade: "+_studentGrade);
            Console.WriteLine("Class Year: "+_classYear);
            Console.WriteLine("Student Number: " +_studentNumber);

        }

    }
    //Inheriting Person class another using:
    class Teacher : Person
    {
        int teacherNumber;
        string department;
    }
    class Inheritance
    {
        static void Main(string[] args)
        {
            var obj=new Student();
            obj.PersonData("Enes","Gunduz",24);
            obj.StudentData(3.13f, 4,209);
            Console.WriteLine("Student Class Writer:\n--------------------");
            obj.StudentDataWriter();
            Console.WriteLine("\nPerson Class Writer:\n--------------------");
            obj.PersonDataWriter();
        }
    }
}
