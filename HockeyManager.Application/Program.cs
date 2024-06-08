using HockerManager.Core.Handlers.Player.AddNewDefender;
using HockeyManager.Application;
using HockeyManager.Db;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace HockeyManager.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddMediatR(cfg =>
                {
                    cfg.RegisterServicesFromAssemblies(new Assembly[] { Assembly.GetExecutingAssembly(), typeof(AddNewDefenderHandler).Assembly });
                })
                .AddSingleton<HockeyManager>()
                .AddSingleton<IPlayersResouce, PlayersResource>()
                .BuildServiceProvider();

            serviceProvider.GetService<HockeyManager>()?.PrintNameAndAgeOfTheYoungestPlayer();
        }
    }
}
