using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Ioc
{
    public interface ICoreModule //Core gördüğün zaman framework olduğunu anla.
    {
        void Load(IServiceCollection serviceCollection);
    }
}
