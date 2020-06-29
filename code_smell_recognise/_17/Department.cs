namespace code_smell_recognise._17
{
    public class Department
    {
        public Department(Person manager)
        {
            Manager = manager;
        }

        private string name;
        private long membersCount;
        public Person Manager { get; }
        public string Type { get; set; }
    }
}