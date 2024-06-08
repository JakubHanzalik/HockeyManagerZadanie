using System;
using System.Reflection;
using HockerManager.Core.Handlers.Player.AddNewDefender;
using HockeyManager.Application;
using HockeyManager.Db;
using Microsoft.Extensions.DependencyInjection;

namespace HockeyManager.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddMediatR(cfg =>
                {
                    cfg.RegisterServicesFromAssemblies(
                        new Assembly[]
                        {
                            Assembly.GetExecutingAssembly(),
                            typeof(AddNewDefenderHandler).Assembly
                        }
                    );
                })
                .AddSingleton<HockeyManager>()
                .AddSingleton<IPlayersResouce, PlayersResource>()
                .BuildServiceProvider();

            // Testing code
            //serviceProvider.GetService<HockeyManager>()?.AddNewForward();
            //serviceProvider.GetService<HockeyManager>()?.AddNewDefender();
            //serviceProvider.GetService<HockeyManager>()?.AddNewGoalie();
            //serviceProvider.GetService<HockeyManager>()?.PrintNameAndAgeOfTheYoungestPlayer();
        }
    }
}
