using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockerManager.Core.Handlers.Player.AddNewForward
{
    public class AddNewGoalieRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly BirthDate { get; set; }
        public int Goals { get; set; }
    }
}
