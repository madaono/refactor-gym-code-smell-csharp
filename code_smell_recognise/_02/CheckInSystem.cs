using System.Collections.Generic;
using System.Linq;

namespace code_smell_recognise._02
{
    public class CheckInSystem
    {
        private readonly Dictionary<string, string> checkInRecords = new Dictionary<string, string>();
        
        public bool CheckIn(string fingerprint){
            Employee employee = EmployeeRepository.Query(fingerprint);
            var type = employee.Type;
            string record;
            switch (type) 
            {
                case Employee.Engineer:
                    record = "I am an Engineer, My Name is" + employee.Name;
                    break;
                case Employee.Salesman:
                    record = "I am a Salesman, My Name is" + employee.Name;
                    break;
                case Employee.Manager:
                    record = "I am a Manager, My Name is" + employee.Name;
                    break;
                default:
                    record = "";
                    break;
            }
            
            if (checkInRecords.Any()) {
                return false;
            }
            checkInRecords.Add(fingerprint, record);

            return true;
        }
    }
}