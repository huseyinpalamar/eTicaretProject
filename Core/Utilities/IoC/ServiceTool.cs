using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.IoC
{
    /// <summary>
    /// Aspect'lerde dependency injection yapısı kullanılmaz. Bu yüzden IHttpContextAccesor kullanılabilmesi için tool yazıldı
    /// Bu tool sayesinde Autofac işlemini kolaylıkla yapıcak.
    /// </summary>
    public static class ServiceTool
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }

}
