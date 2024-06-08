using HockerManager.Core.Handlers.Player.AddNewDefender;
using HockerManager.Core.Handlers.Player.AddNewForward;
using HockerManager.Core.Handlers.Player.AddNewGoalie;
using HockerManager.Core.Handlers.Player.GetYoungestPlayerFullNameAndAge;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager.Application
{
    public class HockeyManager
    {
        private readonly IMediator mediator;

        public HockeyManager(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void AddNewForward()
        {
            mediator.Send(new AddNewForwardRequest()
            {
                Name = "John",
                Surname = "Doe",
                BirthDate = new DateTime(1990, 1, 1),
                Goals = 10
            });
        }
        public void AddNewDefender()
        {
            mediator.Send(new AddNewDefenderRequest()
            {
                Name = "John",
                Surname = "Doe",
                BirthDate = new DateTime(1990, 1, 1),
                Hits = 10
            });
        }
        public void AddNewGoalie()
        {
            mediator.Send(new AddNewGoalieRequest()
            {
                Name = "John",
                Surname = "Doe",
                BirthDate = new DateTime(1990, 1, 1),
                Wins = 10
            });
        }
        public async void PrintNameAndAgeOfTheYoungestPlayer()
        {
            var response = await mediator.Send(new GetYoungestPlayerFullNameAndAgeRequest());
            Console.WriteLine($"The youngest player is {response.Name} {response.Surname} and he is {response.Age} years old.");
        }
    }
}
