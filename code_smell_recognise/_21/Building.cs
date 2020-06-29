using System.Collections.Generic;

namespace code_smell_recognise._21
{
    public class Building
    {
        public string BuildingNo { get; set; }
        public Person BuildingManager { get; set; }
        public List<Room> Rooms { get; set; }
    }
}