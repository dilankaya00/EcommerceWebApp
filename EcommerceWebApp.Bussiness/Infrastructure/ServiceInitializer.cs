using EcommerceWebApp.Bussiness.Services;
using EcommerceWebApp.Database.JWT;
using EcommerceWebApp.Database.Entity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebApp.Bussiness.Infrastructure
{
  public static class ServiceInitializer
    {
        public static void AddEngines(this IServiceCollection services)
        {
            object p = services.AddAutoMapper(typeof(AutoMapperConfig));
            services.AddScoped<ITokenHelper, JwtHelper>();

            //var baseEngineType = typeof(IEngineBase);
            //var assembly = baseEngineType.Assembly;
            //var allTypes = assembly.GetTypes();
            //var engineInterfaces = allTypes.Where(t => t.IsInterface && baseEngineType.IsAssignableFrom(t) && t != baseEngineType);
            //foreach (var engineInterface in engineInterfaces)
            //{
            //    var implementationClass = allTypes.Where(t => t.IsClass && engineInterface.IsAssignableFrom(t)).FirstOrDefault();
            //    if (implementationClass != null)
            //    {
            //        services.AddScoped(engineInterface, implementationClass);
            //    }
            //    else
            //    {
            //        throw new Exception("There is no implementation class for " + engineInterface.Name);
            //    }
            //}
        }
      
    }
}
