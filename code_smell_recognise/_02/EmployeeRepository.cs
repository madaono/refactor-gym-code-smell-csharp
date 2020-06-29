using System.Collections.Generic;
using System.IO;

namespace code_smell_recognise._02
{
    public class EmployeeRepository
    {
        private static Dictionary<string, Employee> employees = new Dictionary<string, Employee>();
        public static Employee Query(string fingerprint)
        {
            if (!employees.ContainsKey(fingerprint)) {
                throw new EmployeeNotExistException();
            }
            return employees[fingerprint];
        }
    }
}