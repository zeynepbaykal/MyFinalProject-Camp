using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Ioc
{
    //autofac te olusturduğumuz  builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance(); bizim implimentlerimiz ama Ihttp implimenti dışardan geliyor ve core bunu okuyamıyor bunun için tool service ihtiyaç duyuyoruz
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
