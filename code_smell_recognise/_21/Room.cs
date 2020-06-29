using System.Collections.Generic;

namespace code_smell_recognise._21
{
    public class Room
    {
        public string RoomNo { get; set; }
        public float Square { get; set; }
        public List<Person> Persons { get; set; }
    }
}