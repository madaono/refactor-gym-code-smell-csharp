using System.Collections.Generic;
using System.Linq;

namespace code_smell_recognise._21
{
    public class DiseaseControlCenter
    {
        private List<Community> communities;

        public bool HasPatient() {
            return communities
                .SelectMany(community => community.Buildings)
                .SelectMany(building => building.Rooms)
                .SelectMany(room => room.Persons)
                .Any(person => person.IsInfected);
        }
    }
}