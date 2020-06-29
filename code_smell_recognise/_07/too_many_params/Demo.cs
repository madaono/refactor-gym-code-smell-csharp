using System;

namespace code_smell_recognise._07.too_many_params
{
    public class Demo
    {
        
    }
    
    internal class User {
        public User(string name, DateTime birthday, string location, string username, string phoneNumber, string hobbies) {
            this.name = name;
            this.birthday = birthday;
            this.location = location;
            this.username = username;
            this.phoneNumber = phoneNumber;
            this.hobbies = hobbies;
        }

        private string name;
        private DateTime birthday;
        private string location;
        private string username;
        private string phoneNumber;
        private string hobbies;
    }
}