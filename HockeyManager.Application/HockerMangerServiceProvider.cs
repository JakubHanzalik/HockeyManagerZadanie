using HockeyManager.Db;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager.Application
{
    public class HockerMangerServiceProvider
    {
        public static ServiceProvider CreateServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IPlayersResouce, PlayersResource>();
            return services.BuildServiceProvider();
        }
    }
}
