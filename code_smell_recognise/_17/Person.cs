namespace code_smell_recognise._17
{
    public class Person
    {
        private Department _department;

        public Person(string name)
        {
            Name = name;
        }

        public Department Department
        {
            set => _department = value;
        }

        public Person Manager { get; }
        public string DepartmentType { get; }
        public string Name { get; }
    }
}