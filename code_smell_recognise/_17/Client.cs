using System;

namespace code_smell_recognise._17
{
    public class Client
    {
        public static void Main(string[] args)
        {
            var person = new Person("SJ");
            Department department = new Department(new Person("XJ"));
            department.Type = "Capability";

            person.Department = department;

            Person manager = person.Manager;
            string departmentType = person.DepartmentType;

            Console.WriteLine(manager.Name + "is working in a department of " + departmentType);
        }
    }
}