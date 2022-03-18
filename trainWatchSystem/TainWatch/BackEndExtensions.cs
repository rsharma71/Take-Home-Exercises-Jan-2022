using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainWatchSystem.BLL;
using TrainWatchSystem.DAL;

namespace TrainWatchSystem
{
    public static class BackEndExtensions
    {
        public static void TWBackendDependencies(this IServiceCollection services, Action<DbContextOptionsBuilder> options)
        {
            //within this method, we will register all the services
            //that will be used by our system (context setup)
            //and will be provided by the system

            //setup the context service
            services.AddDbContext<TrainWatchContext>(options);

            //register the services classes

            //add any business logic layer class to the service collection
            //allow the web app to access the methods (services) within the BLL class

            //the argument for the AddTransient is called a factory
            //adding a localize method to get access to the services
            services.AddTransient<TrainWatchServices>((serviceProvider) =>
            {
                // get the dbcontext class that has been registered
                var context = serviceProvider.GetService<TrainWatchContext>();

                //create an instance of the service class (BuildVersionServices/BLL)
                //supply the context reference to this service class and return it.
                return new TrainWatchServices(context);
            });

           

        }
    }
}

