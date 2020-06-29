using System;

namespace code_smell_recognise._02
{
    public class Employee
    {
        public const int Engineer = 0;
        public const int Salesman = 1;
        public const int Manager = 2;
        public string Name { get; }
        public int Type { get; }
        
        private int monthlySalary;
        private int commission;
        private int bonus;

        public Employee(int type)
        {
            Type = type;
        }
        
        public int PayAmount() {
            switch (Type) {
                case Engineer:
                    return monthlySalary;
                case Salesman:
                    return monthlySalary + commission;
                case Manager:
                    return monthlySalary + bonus;
                default:
                    throw new Exception("Invalid employee");
            }
        }
    }
}