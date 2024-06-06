using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockerManager.Core.Handlers.Player.AddNewDefender
{
    public class AddNewDefenderRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly BirthDate { get; set; }
        public int Hits { get; set; }
    }
}
