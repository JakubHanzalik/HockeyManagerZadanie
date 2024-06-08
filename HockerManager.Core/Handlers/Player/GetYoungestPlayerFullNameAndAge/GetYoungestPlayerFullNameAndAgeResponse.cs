using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockerManager.Core.Handlers.Player.GetYoungestPlayerFullNameAndAge
{
    public class GetYoungestPlayerFullNameAndAgeResponse
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
