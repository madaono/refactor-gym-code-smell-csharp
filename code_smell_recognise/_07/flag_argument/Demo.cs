
using System;

namespace code_smell_recognise._07.flag_argument
{
    public class Demo
    {
        public static void Main(string[] args)
        {
            var demo = new Demo();
            var user = new User();

            demo.FindUser(user, user.Name);
        }

        User FindUser(User user, string name)
        {
            if(string.IsNullOrEmpty(name)) {
                throw new Exception("Invalid name");
            }
            return null;
        }
    }

    internal class User
    {
        internal string Name;
        internal string Gender;
    }
}